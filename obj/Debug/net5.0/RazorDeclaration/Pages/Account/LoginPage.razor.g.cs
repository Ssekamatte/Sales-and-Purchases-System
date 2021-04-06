// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sales.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Sales.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using Microsoft.AspNetCore.Identity.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using Sales.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using Sales.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 326 "C:\MVC Projects\Blazor project\Sales\Pages\Account\LoginPage.razor"
       
    private string Errormsg { get; set; }
    private LoginViewModel InputModel = new LoginViewModel();
    protected override async Task OnInitializedAsync()
    {
        try
        {
            Errormsg = string.Empty;
            if (userManagement.IsSignedIn())
            {
                var text = await JS.InvokeAsync<string>("Logout");
            }
        }
        catch (Exception ex)
        {
            _logger.LogInformation("Login Error:-" + ex.ToString());
            Errormsg = ex.Message;
        }
    }
    private async Task LoginUser()
    {
        try
        {
            Errormsg = string.Empty;
            string email = string.Empty;
            using (var dbContext = new SalesPurchasesContext())
            {
                var exist = dbContext.AspNetUsers.FirstOrDefault(o => o.Email == InputModel.Email || o.UserName == InputModel.Email);
                if (exist != null)
                {
                    email = exist.UserName;
                    InputModel.Email = exist.UserName;
                }
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, set lockoutOnFailure: true
            //var result = await _signInManager.PasswordSignInAsync(InputModel.Email, InputModel.Password, InputModel.RememberMe, lockoutOnFailure: false);
            var result = await JS.InvokeAsync<Microsoft.AspNetCore.Identity.SignInResult>("Login", InputModel.Email, InputModel.Password, InputModel.RememberMe);

            //if (result.Succeeded)
            //{
            //    _logger.LogInformation("User logged in.");
            //    //return LocalRedirect(returnUrl);
            //    NavManager.NavigateTo("/");
            //}
            //if (result.RequiresTwoFactor)
            //{
            //    NavManager.NavigateTo("/");
            //    //return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
            //}
            //if (result.IsLockedOut)
            //{
            //    _logger.LogWarning("User account locked out.");
            //    //return RedirectToPage("./Lockout");
            //    NavManager.NavigateTo("/");
            //}
            //else
            //{
            //    //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            //    //return Page();
            //    Errormsg = "Invalid login attempt.";
            //}
        }
        catch (Exception ex)
        {
            _logger.LogInformation("Login Error:-" + ex.ToString());
            Errormsg = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManagement userManagement { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<LoginPage> _logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> _signInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesPurchasesContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591