#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34f249cd499e2091682d4c0f8ad40cb05c254fe3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f249cd499e2091682d4c0f8ad40cb05c254fe3", @"/Views/Home/RegisterBusiness.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterBusiness : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Locate_closest_business.Models.BusinessModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registrationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
  
    var formSubmitSuccess = ViewBag.SuccessfulSubmit;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var success = \'");
#nullable restore
#line 8 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
              Write(formSubmitSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    if(success == true){
        alert('Your request has been successfully submitted');
    }
</script>

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
            <br/>
           ");
            WriteLiteral(" <span><button class=\"viewBusinessesButton\">VIEW MY BUSINESS REQUESTS</button><button class=\"nextButton\">NEXT</button> </span> \r\n            <br/><br/>\r\n        </div>  \r\n    </div>  \r\n\r\n");
#nullable restore
#line 30 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
     using (Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""modal-dialog modal-lg"" id=""step2"">  
            <div class=""modal-content"">  
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>  
                <h4 class=""modal-title"">Register your business as an essential service</h4><br/>  
                <br/>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34f249cd499e2091682d4c0f8ad40cb05c254fe36273", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 38 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                   Write(Html.TextAreaFor(model => model.MemberIds, new { @class = "form-control", placeholder="Provide all ID/Passport numbers of the current directors/members"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <br/><h4>Company Details</h4><br/>\r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 43 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.CompanyName, new { htmlAttributes = new { @class = "form-control", @placeholder="Registered Company Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.RegistrationNumber, new { htmlAttributes = new { @class = "form-control", @placeholder="Company Registration Number" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 47 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
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
#line 66 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                   Write(Html.EditorFor(model => model.NumEmployees, new { htmlAttributes = new { @class = "form-control", @placeholder="Number Of Employees" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">  \r\n                        ");
#nullable restore
#line 69 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                   Write(Html.TextAreaFor(model => model.Address, new { @class = "form-control", placeholder="Company's physical address" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <input type=\"submit\" class=\"submitRequestButton\" value=\"SUBMIT REQUEST\" />   \r\n                <br/><br/>\r\n            </div>  \r\n        </div>\r\n");
#nullable restore
#line 76 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
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
