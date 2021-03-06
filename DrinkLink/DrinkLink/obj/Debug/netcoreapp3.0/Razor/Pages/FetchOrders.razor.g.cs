#pragma checksum "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a41d5826d7bf846b1b338f3497f193c457e2c33e"
// <auto-generated/>
#pragma warning disable 1591
namespace DrinkLink.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using DrinkLink;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\_Imports.razor"
using DrinkLink.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
using DrinkLink.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
using DrinkLink.Data.DrinkLink;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
           [Authorize(Roles = "AdminO,Operations")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchorders")]
    public class FetchOrders : OwningComponentBase<DrinkLinkProductDataService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Orders</h1>\r\n");
#nullable restore
#line 14 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
 if (drinkLinkOrderCurrents == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 17 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <td>Order Reference</td>\r\n                <td>Customer Name</td>\r\n                <td>Customer Address</td>\r\n                <td>Date of Order</td>\r\n\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 31 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
             foreach (var dlCurrentOrder in drinkLinkOrderCurrents)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.AddContent(15, 
#nullable restore
#line 35 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                         dlCurrentOrder.DlOrderId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.AddContent(20, 
#nullable restore
#line 40 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                         dlCurrentOrder.DlOrderCustomerNames

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddContent(25, 
#nullable restore
#line 44 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                         dlCurrentOrder.DlOrderCustomerAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.AddContent(30, 
#nullable restore
#line 47 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                         dlCurrentOrder.DlOrderDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddMarkupContent(34, "\r\n\r\n                        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "data-toggle", "tooltip");
            __builder.AddAttribute(37, "title", "Show Order Items ");
            __builder.AddAttribute(38, "class", "btn btn-outline-dark");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                          (() =>  ShowOrderItems(dlCurrentOrder.DlOrderId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n                            <span class=\"iconify\" data-icon=\"ls:view\" data-inline=\"false\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 61 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 66 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
     if (ShowPopup == 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "        \r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal");
            __builder.AddAttribute(50, "tabindex", "-1");
            __builder.AddAttribute(51, "style", "display:block");
            __builder.AddAttribute(52, "role", "dialog");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-dialog modal-dialog-scrollable modal-lg");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-content");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-header");
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "h3");
            __builder.AddAttribute(64, "class", "modal-title");
            __builder.AddContent(65, 
#nullable restore
#line 73 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                 modalHeader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        \r\n                        ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "close");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                          ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.AddMarkupContent(72, "<span aria-hidden=\"true\">X</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    \r\n                    ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-body");
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "table");
            __builder.AddAttribute(79, "class", "table");
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.AddMarkupContent(81, @"<thead>
                                <tr>
                                    <td>Product Id</td>
                                    <td>Product</td>
                                    <td>Pack Quantity</td>
                                    <td>Order Quantity</td>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(82, "tbody");
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 92 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                 foreach (var currentOrderProduct in drinkLinkOrderCurrentProducts)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                                    ");
            __builder.OpenElement(85, "tr");
            __builder.AddMarkupContent(86, "\r\n                                        ");
            __builder.AddContent(87, 
#nullable restore
#line 95 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                         currentOrderProduct.DlOrderCurrentOrderId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, "\r\n                                        \r\n                                        ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 97 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                             currentOrderProduct.DlOrderCurrentProduct

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n                                        ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 99 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                             currentOrderProduct.DlOrderCurrentProductQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n                                        ");
            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 101 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                             currentOrderProduct.DlOrderCurrentQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n                                        ");
            __builder.AddMarkupContent(98, "<td>\r\n                                        </td>\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                    ");
            __builder.OpenElement(100, "tr");
            __builder.AddMarkupContent(101, "\r\n                                        <td></td>\r\n                                        <td></td>\r\n                                        <td></td>\r\n                                        ");
            __builder.OpenElement(102, "td");
            __builder.AddMarkupContent(103, "\r\n                                            ");
            __builder.OpenElement(104, "label");
            __builder.AddMarkupContent(105, "\r\n                                                Order Status\r\n                                                ");
            __builder.OpenElement(106, "select");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 114 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                               currentOrderProduct.DlOrderStatusStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentOrderProduct.DlOrderStatusStatus = __value, currentOrderProduct.DlOrderStatusStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(109, "\r\n\r\n");
#nullable restore
#line 116 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                     foreach (var selectOption in availableStati)
                                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                                                        ");
            __builder.OpenElement(111, "option");
            __builder.AddAttribute(112, "value", 
#nullable restore
#line 118 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                                       selectOption

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(113, 
#nullable restore
#line 118 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                                                     selectOption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 119 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                    ");
            __builder.OpenElement(120, "tr");
            __builder.AddMarkupContent(121, "\r\n                                        <td></td>\r\n                                        <td></td>\r\n                                        <td></td>\r\n                                        ");
            __builder.OpenElement(122, "td");
            __builder.AddMarkupContent(123, "\r\n                                            ");
            __builder.OpenElement(124, "button");
            __builder.AddAttribute(125, "data-toggle", "tooltip");
            __builder.AddAttribute(126, "title", "Order");
            __builder.AddAttribute(127, "class", "btn btn-outline-dark");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 134 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
                                                              (() => ChangeOrderStatus(currentOrderProduct.DlOrderCurrentOrderId, currentOrderProduct.DlOrderStatusStatus))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(129, "\r\n\r\n                                                Update Order\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 140 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"

                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(133, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.AddMarkupContent(136, "<p>\r\n                        \r\n                        </p>\r\n             \r\n\r\n\r\n\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 159 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, "<p></p>\r\n");
#nullable restore
#line 162 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 165 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchOrders.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState>
    authenticationStateTask
    { get; set; }

    string modalHeader = "";
    int ShowPopup = 0;

    //string orderStatus;



    List<string> availableStati = new List<string>();


    DrinkLinkOrderCurrentCustomer dlCurrentOrder = new DrinkLinkOrderCurrentCustomer();
    List<DrinkLinkOrderCurrentCustomer> drinkLinkOrderCurrents = new List<DrinkLinkOrderCurrentCustomer>();


    List<DrinkLinkOrderCurrentProduct> drinkLinkOrderCurrentProducts = new List<DrinkLinkOrderCurrentProduct>();

    void ClosePopup()
    {
        // Close the Popup

        ShowPopup = 0;

    }

    protected override async Task OnInitializedAsync()
    {
        int orderStatus = 5;
        var user = (await authenticationStateTask).User;
        if (user.IsInRole("AdminO"))
        {
            orderStatus = 0;
            availableStati = Constants.DropDownOptions.availableStatusAdmin;
        }
        else if (user.IsInRole("Operations"))
        {
            orderStatus = 1;
            availableStati = Constants.DropDownOptions.availableStatusOps;
        }


        drinkLinkOrderCurrents = await @Service.GetDlCurrentOrders(orderStatus);



    }


    async Task ShowOrderItems(string OrderId)
    {
        modalHeader = Constants.ModalContent.modalHeaderOrderDetails;
        drinkLinkOrderCurrentProducts = await @Service.GetDlCurrentOrderDetails(OrderId);
        ShowPopup = 1;

    }

    void ChangeOrderStatus(string orderId, string orderStatus)
    {

        int shrtStati;
        Dictionary<string, int> availableStatiShrt = Constants.DropDownOptions.availableStatusShrt;
        availableStatiShrt.TryGetValue(orderStatus, out shrtStati);

        var result = @Service.UpdateOrderStatus(orderId,shrtStati);
        if(result)
        {
            ClosePopup();

            NavigationManager.NavigateTo("/fetchorders");


        }

    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
