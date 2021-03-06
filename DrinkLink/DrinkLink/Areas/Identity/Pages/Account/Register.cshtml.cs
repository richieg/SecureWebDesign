﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using DrinkLink.Data.DrinkLink;
using DrinkLink.Data;
using Microsoft.AspNetCore.Components;


namespace DrinkLink.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly DrinkLinkUserDataService _dluserService;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            DrinkLinkUserDataService dluserService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _dluserService = dluserService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel //: OwningComponentBase<DrinkLinkUserDataService> 

        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$",ErrorMessage ="Invalid Characters Entered")]




            [StringLength(60)]
            [Display(Name = "Company Name")]
            public string CompanyName { get; set; }


            [RegularExpression(@"^[a-zA-Z""'\s-]*$", ErrorMessage = "Invalid Characters Entered")]
            [Required]
            [StringLength(60)]
            [Display(Name = "Applicants Full Name")]
            public string FullName { get; set; }

            [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Invalid Characters Entered")]
            [Required]
            [StringLength(60)]
            [Display(Name = "Address Line 1")]
            public string AddressLine1 { get; set; }

            [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Invalid Characters Entered")]
            [Required]
            [StringLength(60)]
            [Display(Name = "Address Line 2")]
            public string AddressLine2 { get; set; }
            [Required]
            [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Invalid Characters Entered")]
          
            [StringLength(60)]
            [Display(Name = "Address Line 3")]
            public string AddressLine3 { get; set; }



            [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Invalid Characters Entered")]
            [Required]
            [StringLength(60)]
            [Display(Name = "Post Code")]
            public string PostCode { get; set; }

            [RegularExpression(@"^[0-9]*$", ErrorMessage = "Must only contain numbers")]
            [DataType(DataType.PhoneNumber, ErrorMessage ="Must only contain numbers")]
            [Required]
            [Display(Name = "Phone Number")]
            public int PhoneNumber { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                   
                    
                    DrinkLinkContacts dlContact = new DrinkLinkContacts();
                    dlContact.DlContactId = Guid.NewGuid().ToString();
                    dlContact.DlContactOwnership = user.Id;
                    dlContact.DlContactName = Input.FullName;
                    dlContact.DlContactAddressLine1 = Input.AddressLine1;
                    dlContact.DlContactAddressLine2 = Input.AddressLine2;
                    dlContact.DlContactAddressLine3 = Input.AddressLine3;
                    dlContact.DlContactAddressPostCode = Input.PostCode;
                    dlContact.DlContactEmail = Input.Email;
                    dlContact.DlContactPhoneNumber = Input.PhoneNumber;
                    dlContact.DlContactsIsConfirmed = false;

                    bool insertResult = false;

                    try {

                       insertResult =  _dluserService.CreateNewDlContactinDB(dlContact);
           


                    }
                    catch(Exception e)
                    {
                        _logger.LogInformation(e.Message);
                    }
                    if (insertResult)
                    {
                        _logger.LogInformation("User created a new account with password.");

                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = user.Id, code = code },
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        {
                            return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                        }
                        else
                        {
                            await _signInManager.SignInAsync(user, isPersistent: false);
                            return LocalRedirect(returnUrl);
                        }
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
