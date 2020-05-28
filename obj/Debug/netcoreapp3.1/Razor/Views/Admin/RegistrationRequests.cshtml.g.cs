#pragma checksum "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7ee5fcdceb5a8e2551c16f0492aba18b10c627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RegistrationRequests), @"mvc.1.0.view", @"/Views/Admin/RegistrationRequests.cshtml")]
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
#line 1 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\_ViewImports.cshtml"
using Locate_closest_business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\_ViewImports.cshtml"
using Locate_closest_business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7ee5fcdceb5a8e2551c16f0492aba18b10c627", @"/Views/Admin/RegistrationRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegistrationRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Locate_closest_business.Models.BusinessModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/ConfirmRegistration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/DenyRegistration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
Write(Html.Partial("~/Views/Admin/Sidenav.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"business-container\">\r\n    <div class=\"businesses\">\r\n        <br/>\r\n        <h2><b>Registration Requests</b></h2>\r\n        <br/>\r\n");
#nullable restore
#line 10 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
         if(Model.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>There are currently no business registration requests</h3>\r\n");
#nullable restore
#line 12 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""requestsTable table table-striped"">
                <thead>
                    <th scope=""col"">Company Name</th>
                    <th scope=""col"">Registration Number</th>
                    <th scope=""col"">Category</th>
                    <th scope=""col"">No. Employees</th>
                    <th scope=""col"">Address</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                     foreach(var business in Model){
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                         if(business.RequestStatus == "Pending"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr scope=\"row\">\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                               Write(business.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                               Write(business.RegistrationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                               Write(business.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                               Write(business.NumEmployees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                               Write(business.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7ee5fcdceb5a8e2551c16f0492aba18b10c6278321", async() => {
                WriteLiteral("\r\n                                        <input");
                BeginWriteAttribute("name", " name=\"", 1551, "\"", 1586, 1);
#nullable restore
#line 35 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
WriteAttributeValue("", 1558, business.RegistrationNumber, 1558, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\"");
                BeginWriteAttribute("value", " value=\"", 1610, "\"", 1646, 1);
#nullable restore
#line 35 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
WriteAttributeValue("", 1618, business.RegistrationNumber, 1618, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input class=\"confirm-button\" type=\"button\" value=\"Confirm\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7ee5fcdceb5a8e2551c16f0492aba18b10c62711026", async() => {
                WriteLiteral("\r\n                                        <input");
                BeginWriteAttribute("name", " name=\"", 2015, "\"", 2050, 1);
#nullable restore
#line 41 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
WriteAttributeValue("", 2022, business.RegistrationNumber, 2022, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\"");
                BeginWriteAttribute("value", " value=\"", 2074, "\"", 2110, 1);
#nullable restore
#line 41 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
WriteAttributeValue("", 2082, business.RegistrationNumber, 2082, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input class=\"deny-button\" type=\"button\" value=\"Deny\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 50 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Admin\RegistrationRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/><br/>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Locate_closest_business.Models.BusinessModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
