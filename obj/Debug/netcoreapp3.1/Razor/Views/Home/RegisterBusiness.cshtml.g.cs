#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8dfa63e509a6f29e21fc7fee4a00940c0da6690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterBusiness), @"mvc.1.0.view", @"/Views/Home/RegisterBusiness.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8dfa63e509a6f29e21fc7fee4a00940c0da6690", @"/Views/Home/RegisterBusiness.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterBusiness : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Locate_closest_business.Models.BusinessModel>
    {
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
#nullable restore
#line 1 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""modal fade"" tabindex=""-1"" id=""registerBusinessModal"" data-keyboard=""false"" data-backdrop=""static"">  
    <div class=""modal-dialog modal-lg"" id=""step1"">  
        <div class=""modal-content"">  
            <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>  
            <h4 class=""modal-title"">Register your business as an essential service</h4>  
            <h3>
                <i>
                    “All enterprises operating within the borders of the Republic of South Africa are expected to be closed during the lockdown period. Only enterprises which produce and/or provide, and/or distribute goods and services listed are exempted from the restrictions contemplated in the regulation issued in terms of the Disaster Management Act. Note, absolute minimum staff necessary to operate safely.”
                </i>
            </h3>  
            <button type=""submit"" class=""nextButton"">NEXT</button>   
            <br/>
        </div>  
    </div>  

");
#nullable restore
#line 22 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
     using (Html.BeginForm("RegisterBusiness", "Home", FormMethod.Post)){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal-dialog modal-lg"" id=""step2"">  
        <div class=""modal-content"">  
            <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>  
            <h4 class=""modal-title"">Register your business as an essential service</h4><br/>  
            <h4>Director/Member Details</h4>
            <br/><br/>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8dfa63e509a6f29e21fc7fee4a00940c0da66905405", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 31 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", @placeholder="First Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("          \r\n                    ");
#nullable restore
#line 32 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control", @placeholder="Last Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("      \r\n                </div>\r\n                <div class=\"errorSpace\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger errorText" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger errorLeftText" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\"> \r\n                    ");
#nullable restore
#line 39 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @placeholder="Email" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    ");
#nullable restore
#line 40 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control", @placeholder="Phone" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"errorSpace\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger errorText" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger errorLeftText2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                </div>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 47 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.TextAreaFor(model => model.MemberIds, new { htmlAttributes = new { @class = "form-control", @placeholder="Provide all ID/Passport numbers of the current directors/members" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"errorSpace\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.MemberIds, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                </div>\r\n\r\n                <br/><h4>Company Details</h4><br/>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 55 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.CompanyName, new { htmlAttributes = new { @class = "form-control", @placeholder="Registered Company Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 56 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.RegistrationNumber, new { htmlAttributes = new { @class = "form-control", @placeholder="Company Registration Number" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"errorSpace\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.CompanyName, "", new { @class = "text-danger errorText" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 60 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.RegistrationNumber, "", new { @class = "text-danger errorLeftText3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 63 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.DropDownListFor(model => model.Category,                
                        new List<SelectListItem> { 
                            new SelectListItem { Value = "0" , Text = "Agriculture, hunting, forestry, fishing" },
                            new SelectListItem { Value = "1" , Text = "Electricity, Gas, Water supply" },
                            new SelectListItem { Value = "2" , Text = "Manufacturing" },
                            new SelectListItem { Value = "3" , Text = "Construction and related services" },
                            new SelectListItem { Value = "4" , Text = "Wholesale, Retail trade, Spaza shops" },
                            new SelectListItem { Value = "5" , Text = "Information and Communication services" },
                            new SelectListItem { Value = "6" , Text = "Media and Entertainment" },
                            new SelectListItem { Value = "7" , Text = "Financial and Business services" },
                            new SelectListItem { Value = "8" , Text = "Accommodation for quarantine, essential services" },
                            new SelectListItem { Value = "9" , Text = "Food services (Deliveries)" },
                            new SelectListItem { Value = "10" , Text = "Transport, Storage, Communication services" },
                            new SelectListItem { Value = "11" , Text = "Mining and Quarrying" },
                            new SelectListItem { Value = "12" , Text = "Repair and Related Emergency services" },
                            new SelectListItem { Value = "13" , Text = "Supply Chain" },
                            new SelectListItem { Value = "14" , Text = "Health, Social and Personal services" }
                            },
                        new { @class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 82 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.NumEmployees, new { htmlAttributes = new { @class = "form-control", @placeholder="Number Of Employees" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"errorSpace\">\r\n                    ");
#nullable restore
#line 85 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.Category, "", new { @class = "text-danger errorText" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 86 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.NumEmployees, "", new { @class = "text-danger errorLeftText" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 89 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.TextAreaFor(model => model.Address, new { htmlAttributes = new { @class = "form-control", @placeholder="Company's physical address" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"errorSpace\">\r\n                    ");
#nullable restore
#line 92 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n            <input type=\"submit\" class=\"submitRequestButton\" value=\"SUBMIT REQUEST\" />   \r\n            <br/>\r\n        </div>  \r\n    </div>\r\n");
#nullable restore
#line 99 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
