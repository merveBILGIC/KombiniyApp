#pragma checksum "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c93321e6e9b0f148e0449c5902bf5cb7ad221b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\_ViewImports.cshtml"
using KombniyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\_ViewImports.cshtml"
using KombniyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
using Asp.NetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c93321e6e9b0f148e0449c5902bf5cb7ad221b8", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde0cb099000a1d3912655c1fefd364ef5f3e561", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
 if (Request.IsAuthenticated)
{
    using (Html.BeginForm("LogOff", "Account", FormMethod.Post, new { id = "logoutForm", @class = "form-inline" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            ");
#nullable restore
#line 9 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("Hi " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues: null, htmlAttributes: new { title = "Manage", @class = "nav-link waves-effect waves-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"nav-item\"><a class=\"nav-link waves-effect waves-light\" href=\"javascript:document.getElementById(\'logoutForm\').submit()\">Cerrar sesión</a></li>\r\n");
#nullable restore
#line 12 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">");
#nullable restore
#line 16 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
                    Write(Html.ActionLink("Register", "Register", "Account", routeValues: null, htmlAttributes: new { id = "registerLink", @class = "nav-link waves-effect waves-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"nav-item\">");
#nullable restore
#line 17 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
                    Write(Html.ActionLink("Login", "Login", "Account", routeValues: null, htmlAttributes: new { id = "loginLink", @class = "nav-link waves-effect waves-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591