using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkLink.Data
{
    public class Constants
    {

        public struct PopUpMessages
        {
            public static string uploadInProgress = "Upload in Progress, Please Wait....";
            public static string uploadComplete = "Upload Complete!";
            public static string uploadFailed = "Sorry, Upload Failed.";
            public static string reportGeneration = "Report Generation in Progress, Please Wait....";
            public static string reportGenerationComplete = "Report Generation Complete!";
            public static string reportGenerationFail = "Sorry, Report Generation Failed.";
            public static string actionConfirmation = "Are you sure you would like to complete this action?";







        }
        public struct ButtonText
        {

            public static string previewButton = "Preview Report";
            public static string hideButton = "Hide Report";
            public static string showExtras = "View/ Edit Custom Wordings";
            public static string hideExtras = "Hide Custom Wordings ";
            public static string showSignatureDetails = "View/ Edit Signature";
            public static string hideSignatureDetails = "Hide Signature Details ";

        }

        public struct ButtonTextDisplay
        {
            public static string buttonDisplay = "Block";
            public static string buttonHide = "None";

        }

        public struct ModalContent
        {
            public static string modalHeaderAdd = "Add New Product";
            public static string modalHeaderEdit = "Edit Product";
            public static string modalHeaderOrder = "Order Product";
            public static string modalHeaderDeleteProduct = "Delete Confirmation";
            public static string modalHeaderOrders = "Active Orders";
            public static string modalHeaderOrderDetails = "Order Details";
        }

        public struct DropDownOptions
        {
            public static readonly List<string> AvailableQuantities = new List<string>()
            {

                "12 x 500ml",
                "24 x 500ml",
                "12 x 330ml",
                "24 x 330ml",
                "12 x 70cl",
                "12 x 75cl",
                "6 x 70cl",
                "6 x 75cl",
           
            };

            public static readonly Dictionary<string, int> availableStatusShrt = new Dictionary<string, int>()
            {
                {"Pending" ,0},
                   {"Confirmed",1 },
                      {"In Progress",2 },
                         {"Dispatched",3 },
                            {"Cancelled",4 }


             };


            public static readonly List<string> availableStatusAdmin = new List<string>()
            {
                "Pending" ,
                   "Confirmed" ,
                        "Cancelled" 


             };
            public static readonly List<string> availableStatusOps = new List<string>()
            {
           
                     "In Progress" ,
                         "Dispatched" 
                          


             };

            public static readonly List<string> availableRoles = new List<string>()
            {

                     "AdminU" ,
                         "AdminO",
                            "Operations",
                            "Customer"



             };


        }

    }
}
