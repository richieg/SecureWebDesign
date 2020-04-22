using DrinkLink.Data.DrinkLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace DrinkLink.Data
{
    
    public  class DrinkLinkUserDataService
    {
        private readonly DrinkLinkContext _context;
        public DrinkLinkUserDataService(DrinkLinkContext context)
        {
            _context = context;
        }




        [Authorize(Roles = "AdminU")]
        public Task<List<DrinkLinkContacts>>
        GetDlUserData(string userName)
        {
            List<DrinkLinkContacts> drinkLinkContacts =
                new List<DrinkLinkContacts>();

            drinkLinkContacts =
                (from drinkLinkContact in _context.DrinkLinkContacts

                 where drinkLinkContact.DlContactEmail != userName && !drinkLinkContact.DlContactsIsConfirmed 
                 select drinkLinkContact).ToList();
            return Task.FromResult(drinkLinkContacts);
        }

        [Authorize(Roles = "AdminU")]
        public  bool
         UpdateNewDlContact(string userId, string role)
        {
            try
            {
                _context.Database.ExecuteSqlRaw("EXECUTE dbo.sp_Dl_UpdateUserRole @p0,@p1", userId, role);

                return true;
            }
            catch(Exception e)
            {
                Log.Error(e.Message);
                return false;

            }
        }

        [Authorize(Roles = "AdminU, Customer")]
        public bool
        CreateNewDlContactinDB(DrinkLinkContacts dlContact)
        {
            try
            {
                _context.DrinkLinkContacts.Add(dlContact);
                _context.SaveChanges();

                Log.Information("New user added");
                return true;
            }
            catch(Exception e)
            {
                Log.Error(e.Message);
                return false;
            }

            
        }
    }
}
