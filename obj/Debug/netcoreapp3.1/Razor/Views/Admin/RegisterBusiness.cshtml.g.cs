#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1b693f1eb3e04ca882664756887ba5809ab98d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RegisterBusiness), @"mvc.1.0.view", @"/Views/Admin/RegisterBusiness.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1b693f1eb3e04ca882664756887ba5809ab98d", @"/Views/Admin/RegisterBusiness.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegisterBusiness : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Locate_closest_business.Models.BusinessModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/autoComplete.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addAdminForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script src=\"https://maps.googleapis.com/maps/api/js?libraries=places&key=AIzaSyCsrxUyNDXzcp31HUoSxsLg3wlSHGvww3g\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1b693f1eb3e04ca882664756887ba5809ab98d4770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
Write(Html.Partial("~/Views/Admin/Sidenav.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"new-business-container\" class=\"new-business-container\">\r\n    <div class=\"addBusiness\">\r\n        <br/>\r\n        <h2><b>Register your business as an essential service</b></h2>\r\n        <br/>\r\n        <div style=\"text-align: center;\">\r\n");
#nullable restore
#line 14 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
             using (Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1b693f1eb3e04ca882664756887ba5809ab98d6654", async() => {
                WriteLiteral("  \r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 17 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.CompanyName, new { htmlAttributes = new { @class = "form-control", @placeholder="Registered Company Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 18 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.RegistrationNumber, new { htmlAttributes = new { @class = "form-control", @placeholder="Company Registration Number" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 21 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.DropDownListFor(model => model.Category,                
                            new List<SelectListItem> { 
                                new SelectListItem { Value = "Agriculture, hunting, forestry, fishing" , Text = "Agriculture, hunting, forestry, fishing" },
                                new SelectListItem { Value = "Electricity, Gas, Water supply" , Text = "Electricity, Gas, Water supply" },
                                new SelectListItem { Value = "Manufacturing" , Text = "Manufacturing" },
                                new SelectListItem { Value = "Construction and related services" , Text = "Construction and related services" },
                                new SelectListItem { Value = "Wholesale, Retail trade, Spaza shops" , Text = "Wholesale, Retail trade, Spaza shops" },
                                new SelectListItem { Value = "Information and Communication services" , Text = "Information and Communication services" },
                                new SelectListItem { Value = "Media and Entertainment" , Text = "Media and Entertainment" },
                                new SelectListItem { Value = "Financial and Business services" , Text = "Financial and Business services" },
                                new SelectListItem { Value = "Accommodation for quarantine, essential services" , Text = "Accommodation for quarantine, essential services" },
                                new SelectListItem { Value = "Food services (Deliveries)" , Text = "Food services (Deliveries)" },
                                new SelectListItem { Value = "Transport, Storage, Communication services" , Text = "Transport, Storage, Communication services" },
                                new SelectListItem { Value = "Mining and Quarrying" , Text = "Mining and Quarrying" },
                                new SelectListItem { Value = "Repair and Related Emergency services" , Text = "Repair and Related Emergency services" },
                                new SelectListItem { Value = "Supply Chain" , Text = "Supply Chain" },
                                new SelectListItem { Value = "Health, Social and Personal services" , Text = "Health, Social and Personal services" }
                                },
                            new { @class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 40 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.NumEmployees, new { htmlAttributes = new { @class = "form-control", @placeholder="Number Of Employees" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 43 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control address-control", @placeholder="Company's physical address", @id = "Address" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.HiddenFor(model => model.AddressLatitude, new { @id = "AddressLatitude" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n                        ");
#nullable restore
#line 45 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.HiddenFor(model => model.AddressLongitude, new { @id = "AddressLongitude" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                        ");
#nullable restore
#line 46 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.HiddenFor(model => model.AddressTown, new { @id = "AddressTown" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                        ");
#nullable restore
#line 47 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
                   Write(Html.HiddenFor(model => model.UserId, new { @id = "BusinessCreatorUserId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    </div>\r\n                    <br/>\r\n                    <input type=\"submit\" class=\"register-new-business-button\" value=\"REGISTER BUSINESS\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <br/><br/>\r\n");
#nullable restore
#line 53 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"display-error-message\"></div>\r\n<div class=\"display-success-message\"></div>\r\n\r\n");
#nullable restore
#line 61 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
 if(ViewBag.SuccessMessage != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1b693f1eb3e04ca882664756887ba5809ab98d14953", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4715, "~/js/successMessage.js?", 4715, 23, true);
#nullable restore
#line 62 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
AddHtmlAttributeValue("", 4738, ViewBag.SuccessMessage, 4738, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
}
else if(ViewBag.ErrorMessage != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1b693f1eb3e04ca882664756887ba5809ab98d16869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4856, "~/js/errorMessage.js?", 4856, 21, true);
#nullable restore
#line 65 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
AddHtmlAttributeValue("", 4877, ViewBag.ErrorMessage, 4877, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(document).ready(function () {  \r\n            $(\'.display-success-message\').css(\"display\", \"none\"); \r\n            $(\'.display-error-message\').css(\"display\", \"none\");\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 74 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Admin\RegisterBusiness.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Locate_closest_business.Models.BusinessModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
