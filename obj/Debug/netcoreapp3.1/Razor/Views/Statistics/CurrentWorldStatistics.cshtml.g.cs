#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc796beb17aedc54193a3cad1b8d98db9383c916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_CurrentWorldStatistics), @"mvc.1.0.view", @"/Views/Statistics/CurrentWorldStatistics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc796beb17aedc54193a3cad1b8d98db9383c916", @"/Views/Statistics/CurrentWorldStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_CurrentWorldStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" tabindex=""-1"" id=""WorldStats"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            <h4 class=""modal-title"" style=""text-align: center; font-size: 2rem;"">Current World Statistics</h4>
            <br />
");
#nullable restore
#line 7 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
             if(ViewBag.listOfCountries != null){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-striped table-bordered table-sm"" id=""WorldStatsTable"">
                    <thead>
                        <tr>
                            <th class=""th-sm"">Country</th>
                            <th class=""th-sm"">Positive Cases</th>
                            <th class=""th-sm"">Total Recoveries</th>
                            <th class=""th-sm"">Total Deaths</th>
                            <th class=""th-sm"">New Deaths</th>
                            <th class=""th-sm"">New Recoveries</th>
                            <th class=""th-sm"">New Cases</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 21 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                         foreach (var item in ViewBag.listOfCountries)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                                           Write(item.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                               Write(item.TotalConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                               Write(item.TotalRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                               Write(item.TotalDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                               Write(item.NewDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                               Write(item.NewRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                               Write(item.NewConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 36 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>Something went wrong. Please try again later</div>\r\n");
#nullable restore
#line 39 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\CurrentWorldStatistics.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
