using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DrinkLink.Data.DrinkLink;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;

namespace DrinkLink.Data
{
    public class DrinkLinkProductDataService 
    {
        private readonly DrinkLinkContext _context;
        public DrinkLinkProductDataService(DrinkLinkContext context)
        {
            _context = context;
        }
 

 

        public Task<List<DrinkLinkProductCategory>>
         GetDlProductCategoryData()
        {
            List<DrinkLinkProductCategory> drinkLinkProductCategories =
                new List<DrinkLinkProductCategory>();

            drinkLinkProductCategories =
                (from drinkLinkProductCategory in _context.DrinkLinkProductCategory


                 select drinkLinkProductCategory).ToList();
            return Task.FromResult(drinkLinkProductCategories);
        }



        public Task<List<DrinkLinkProducts>>
        GetDlProductData()
        {
            List<DrinkLinkProducts> drinkLinkProducts =
                new List<DrinkLinkProducts>();

            drinkLinkProducts =
                (from drinkLinkProduct in _context.DrinkLinkProducts


                 select drinkLinkProduct).ToList();
            return Task.FromResult(drinkLinkProducts);
        }


        [Authorize(Roles = "AdminO,Operations")]
        public Task<List<DrinkLinkOrderCurrentCustomer>>
        GetDlCurrentOrders(int orderStatus)
        {
            List<DrinkLinkOrderCurrentCustomer> drinkLinkOrders =
                new List<DrinkLinkOrderCurrentCustomer>();

       



            drinkLinkOrders = _context.DrinkLinkCurrentOrderCustomer.FromSqlRaw("EXECUTE dbo.sp_Dl_ReturnAllOrders @p0", orderStatus).ToList();
    
            return Task.FromResult(drinkLinkOrders);
        }


        [Authorize(Roles = "AdminO,Operations")]
        public Task<List<DrinkLinkOrderCurrentProduct>>
        GetDlCurrentOrderDetails(string OrderId)
        {
            List<DrinkLinkOrderCurrentProduct> drinkLinkOrderDetails =
                new List<DrinkLinkOrderCurrentProduct>();

            drinkLinkOrderDetails = _context.DrinkLinkCurrentOrderProduct.FromSqlRaw("EXECUTE dbo.sp_Dl_ReturnAllOrderDetails @p0", OrderId).ToList();
      
            return Task.FromResult(drinkLinkOrderDetails);
        }


        [Authorize(Roles = "Customers")]
        public bool
        SubmitNewOrder(DrinkLinkOrder dlOrder)
        {
            try
            {
                var customerId = GetDlCustomerId(dlOrder.DlOrderCustomerId).Result;
                dlOrder.DlOrderCustomerId = customerId;
                _context.DrinkLinkOrder.Add(dlOrder);
                _context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                Log.Error(e.Message);
                return false;
            }
        }

      public Task<string>
     GetDlCustomerId(string customerName)
        {

            string customerId = (from dlContact in _context.DrinkLinkContacts.Where(x => x.DlContactEmail == customerName)
                                 select dlContact.DlContactId).FirstOrDefault().ToString();
                 




                      


 
            return Task.FromResult<string>(customerId);
        }
        [Authorize(Roles = "AdminO, Operations")]
        public bool UpdateOrderStatus(string orderId, int status)
        {
            try
            {
                _context.Database.ExecuteSqlRaw("Update DrinkLinkOrderStatus SET DlOrderStatusStatus =  @p0 WHERE DlOrderStatusOrderId = @p1", status, orderId);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        [Authorize(Roles = "AdminO")]

        public bool
        CreateNewDlProductinDB(DrinkLinkProducts dlProduct)
        {
            try
            {
                _context.DrinkLinkProducts.Add(dlProduct);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

