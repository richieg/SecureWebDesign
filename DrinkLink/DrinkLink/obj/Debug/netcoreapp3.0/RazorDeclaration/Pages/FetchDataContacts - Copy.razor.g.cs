#pragma checksum "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchDataContacts - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef63b4e225f5deac379b283734884bd5b1ec7e6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchDataContacts - Copy.razor"
using DrinkLink.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchDataContacts - Copy.razor"
using DrinkLink.Data.DrinkLink;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchDataContacts___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\rgalvin\source\repos\DrinkLink\DrinkLink\Pages\FetchDataContacts - Copy.razor"
       
  // DrinkLinkContacts [] dlContacts;

   List<DrinkLinkContacts> dlContacts =
                new List<DrinkLinkContacts>();

    protected override async Task OnInitializedAsync()
    {
        dlContacts = await DlUserService.GetDlUserData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DrinkLinkUserDataService DlUserService { get; set; }
    }
}
#pragma warning restore 1591
