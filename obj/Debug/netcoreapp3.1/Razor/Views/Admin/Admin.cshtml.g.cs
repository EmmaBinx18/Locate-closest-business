#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c5f9ffbac57fdfb67e6f57caf6248a44ddf9ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin), @"mvc.1.0.view", @"/Views/Admin/Admin.cshtml")]
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
#line 1 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\_ViewImports.cshtml"
using Locate_closest_business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\_ViewImports.cshtml"
using Locate_closest_business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c5f9ffbac57fdfb67e6f57caf6248a44ddf9ed", @"/Views/Admin/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Locate_closest_business.Models.UserManagementModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addAdminForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/AddAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/RemoveAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
Write(Html.Partial("~/Views/Admin/Sidenav.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"adminContainer\">\r\n    <div class=\"addAdmin\">\r\n        <br/>\r\n        <h2><b>Add Admin User</b></h2>\r\n        <br/>\r\n        <div style=\"text-align: center;\">\r\n");
#nullable restore
#line 11 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
             using (Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c5f9ffbac57fdfb67e6f57caf6248a44ddf9ed5993", async() => {
                WriteLiteral("  \r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 14 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                   Write(Html.EditorFor(model => model.NewAdmin.FirstName, new { htmlAttributes = new { @class = "form-control", @placeholder="First Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("          \r\n                        ");
#nullable restore
#line 15 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                   Write(Html.EditorFor(model => model.NewAdmin.LastName, new { htmlAttributes = new { @class = "form-control", @placeholder="Last Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("      \r\n                    </div> \r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 18 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                   Write(Html.EditorFor(model => model.NewAdmin.Email, new { htmlAttributes = new { @class = "form-control", @placeholder="Email" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("          \r\n                        ");
#nullable restore
#line 19 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                   Write(Html.EditorFor(model => model.NewAdmin.Phone, new { htmlAttributes = new { @class = "form-control", @placeholder="Phone" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("      \r\n                    </div> \r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 22 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                   Write(Html.EditorFor(model => model.NewAdmin.Password, new { htmlAttributes = new { @class = "form-control", @placeholder="Password", @type="password" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("          \r\n                        ");
#nullable restore
#line 23 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                   Write(Html.EditorFor(model => model.NewAdmin.ConfirmPassword, new { htmlAttributes = new { @class = "form-control", @placeholder="Confirm Password", @type="password" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("      \r\n                    </div> \r\n                    <br/>\r\n                    <input type=\"submit\" class=\"addAdminButton\" value=\"ADD ADMIN\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <br/><br/>\r\n");
#nullable restore
#line 29 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"adminUsers\">\r\n        <br/>\r\n        <h2><b>Current Admin Users</b></h2>\r\n        <br/>\r\n        <table class=\"adminTable table table-striped\">\r\n            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                 foreach(var admin in Model.AdminUsers){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr scope=\"row\">\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23c5f9ffbac57fdfb67e6f57caf6248a44ddf9ed11387", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                       Write(admin.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                                        Write(admin.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                       Write(admin.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                       Write(admin.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c5f9ffbac57fdfb67e6f57caf6248a44ddf9ed13675", async() => {
                WriteLiteral("\r\n                                <input");
                BeginWriteAttribute("name", " name=\"", 2538, "\"", 2557, 1);
#nullable restore
#line 46 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 2545, admin.Email, 2545, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\"");
                BeginWriteAttribute("value", " value=\"", 2581, "\"", 2601, 1);
#nullable restore
#line 46 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 2589, admin.Email, 2589, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input class=\"removeAdminButton\" type=\"button\" value=\"Remove Admin User\" />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\Admin.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table><br/><br/>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Locate_closest_business.Models.UserManagementModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
