#pragma checksum "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8684041424883feac1f911e64039759187b043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Friends), @"mvc.1.0.view", @"/Views/Account/Friends.cshtml")]
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
#line 1 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyAppAccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8684041424883feac1f911e64039759187b043", @"/Views/Account/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9e7b0206103215518dd409bfeed9c6fc2e46b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KombniyApp.Core.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Henüz hiç arkadaşınız bulunmamakta</h2>\r\n");
#nullable restore
#line 7 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Ad </th>\r\n            <th scope=\"col\">Soyad</th>\r\n            <th scope=\"col\">Handle</th>\r\n            <th scope=\"col\">#</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 25 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8684041424883feac1f911e64039759187b0436456", async() => {
                WriteLiteral("Arkadaşlıktan çıkar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
                                                                    WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 35 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Friends.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KombniyApp.Core.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
