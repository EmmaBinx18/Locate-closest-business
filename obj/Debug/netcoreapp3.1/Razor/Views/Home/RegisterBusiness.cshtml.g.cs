#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee55ef56a85a56c5f4117b3e740fb7f21b00ab85"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee55ef56a85a56c5f4117b3e740fb7f21b00ab85", @"/Views/Home/RegisterBusiness.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterBusiness : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Locate_closest_business.Models.BusinessManagementModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/autoComplete.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registrationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/RemoveBusiness"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
  
    var formSubmitSuccess = ViewBag.SuccessfulSubmit;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<script src=\"https://maps.googleapis.com/maps/api/js?libraries=places&key=AIzaSyCsrxUyNDXzcp31HUoSxsLg3wlSHGvww3g\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee55ef56a85a56c5f4117b3e740fb7f21b00ab855373", async() => {
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
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    var success = \'");
#nullable restore
#line 11 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
              Write(formSubmitSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    if(success == true){
        alert('Your request has been successfully submitted');
    }
</script>

<div class=""modal fade"" tabindex=""-1"" id=""register-business-modal"" data-keyboard=""false"" data-backdrop=""static"">  
    <div class=""modal-dialog modal-lg"" id=""step1"">  
        <div class=""modal-content"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            <h4 class=""modal-title"">Register your business as an essential service</h4>
            <h3>
                <i>
                    “All enterprises operating within the borders of the Republic of South Africa are expected to be closed during the lockdown period. Only enterprises which produce and/or provide, and/or distribute goods and services listed are exempted from the restrictions contemplated in the regulation issued in terms of the Disaster Management Act. Note, absolute minimum staff necessary to operate safely.”
                </i>
            </h3>
            <br />
            <spa");
            WriteLiteral("n><button class=\"view-businesses-button\">VIEW MY BUSINESS REQUESTS</button><button class=\"next-button\">NEXT</button> </span>\r\n            <br /><br />\r\n        </div>  \r\n    </div>  \r\n\r\n");
#nullable restore
#line 33 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
     using (Html.BeginForm("RegisterBusiness", "Home", FormMethod.Post)){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""modal-dialog modal-lg"" id=""step2"">  
            <div class=""modal-content"">  
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>  
                <h4 class=""modal-title"">Register your business as an essential service</h4><br/>  
                <br/>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee55ef56a85a56c5f4117b3e740fb7f21b00ab858671", async() => {
                WriteLiteral("\r\n                <h4>Company Details</h4><br/>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 42 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.NewBusiness.CompanyName, new { htmlAttributes = new { @class = "form-control input", @placeholder="Registered Company Name" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.NewBusiness.RegistrationNumber, new { htmlAttributes = new { @class = "form-control input", @placeholder="Company Registration Number" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 46 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.DropDownListFor(model => model.NewBusiness.Category,                
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
                        new { @class="form-control input"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 65 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.NewBusiness.NumEmployees, new { htmlAttributes = new { @class = "form-control input", @placeholder="Number Of Employees" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">  \r\n                    ");
#nullable restore
#line 68 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.EditorFor(model => model.NewBusiness.Address, new { htmlAttributes = new { @class = "form-control address-control", @placeholder="Company's physical address", @id = "Address" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 69 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.HiddenFor(model => model.NewBusiness.AddressLatitude, new { @id = "AddressLatitude" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n                    ");
#nullable restore
#line 70 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.HiddenFor(model => model.NewBusiness.AddressLongitude, new { @id = "AddressLongitude" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    ");
#nullable restore
#line 71 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.HiddenFor(model => model.NewBusiness.AddressTown, new { @id = "AddressTown" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    ");
#nullable restore
#line 72 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
               Write(Html.HiddenFor(model => model.NewBusiness.UserId, new { @id = "BusinessCreatorUserId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                </div>\r\n            ");
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
            WriteLiteral(" \r\n            <input type=\"submit\" class=\"submit-request-button\" value=\"SUBMIT REQUEST\" />   \r\n            <br/><br/>\r\n        </div>  \r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""requests-modal-dialog"" id=""view-requests"">  
        <div class=""requests-modal-content"">  
            <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>  
            <h4 class=""modal-title"">Your Businesses</h4>  
            <br/><br/>
");
#nullable restore
#line 86 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
             if(Model.Businesses.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>You do not currently have any businesses registered</h2>\r\n");
#nullable restore
#line 88 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""requestsTable table table-striped"">
                    <thead>
                        <th scope=""col"">Company Name</th>
                        <th scope=""col"">Registration Number</th>
                        <th scope=""col"">Category</th>
                        <th scope=""col"">No. Employees</th>
                        <th scope=""col"">Address</th>
                        <th scope=""col"">Request Status</th>
                        <th scope=""col""></th>
                    </thead>
                    <tbody>
");
#nullable restore
#line 101 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                         foreach(var business in Model.Businesses){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr scope=\"row\">\r\n                                <td>");
#nullable restore
#line 103 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                               Write(business.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 104 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                               Write(business.RegistrationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 105 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                               Write(business.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 106 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                               Write(business.NumEmployees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 107 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                               Write(business.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 108 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                               Write(business.RequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee55ef56a85a56c5f4117b3e740fb7f21b00ab8520466", async() => {
                WriteLiteral("\r\n                                        <input name=\"removeBusiness\" style=\"display: none;\"");
                BeginWriteAttribute("value", " value=\"", 7678, "\"", 7714, 1);
#nullable restore
#line 111 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
WriteAttributeValue("", 7686, business.RegistrationNumber, 7686, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input class=\"deny-button\" type=\"submit\" value=\"Remove Business\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 116 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 119 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Home\RegisterBusiness.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br/><br/>\r\n        </div>  \r\n    </div> \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Locate_closest_business.Models.BusinessManagementModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
