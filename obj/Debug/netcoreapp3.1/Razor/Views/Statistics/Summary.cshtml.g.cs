<<<<<<< HEAD
#pragma checksum "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31adc630fa43b3db0ee54ada2556df9826ab5578"
=======
#pragma checksum "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06afcb58d5e4d3adda5827ac0a6f2a38fd74cacd"
>>>>>>> master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_Summary), @"mvc.1.0.view", @"/Views/Statistics/Summary.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\_ViewImports.cshtml"
>>>>>>> master
using Locate_closest_business;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\_ViewImports.cshtml"
>>>>>>> master
using Locate_closest_business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31adc630fa43b3db0ee54ada2556df9826ab5578", @"/Views/Statistics/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc49be731c63cfd7bdf45d6c1734550374f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Locate_closest_business.Models.SummaryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"global-table\">\r\n    <br/>\r\n    <h4>Global Statistics</h4>\r\n    <table>\r\n        <tr>\r\n            <td><b>New Confirmed: </b>");
#nullable restore
<<<<<<< HEAD
#line 8 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                 Write(Model.Global.NewConfirmed);
=======
#line 3 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
  
    ViewData["Title"] = "Global Summary";
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Total Confirmed: </b>");
#nullable restore
<<<<<<< HEAD
#line 11 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                   Write(Model.Global.TotalConfirmed);
=======
#line 7 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
Write(ViewData["Title"]);
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>New Deaths: </b>");
#nullable restore
<<<<<<< HEAD
#line 14 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                              Write(Model.Global.NewDeaths);
=======
#line 16 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Html.DisplayNameFor(model => model.Global.NewConfirmed));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Total Deaths: </b>");
#nullable restore
<<<<<<< HEAD
#line 17 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                Write(Model.Global.TotalDeaths);
=======
#line 16 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                                Write(Html.DisplayFor(model => @model.Global.NewConfirmed));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>New Recovered: </b>");
#nullable restore
<<<<<<< HEAD
#line 20 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                 Write(Model.Global.NewRecovered);
=======
#line 17 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Html.DisplayNameFor(model => model.Global.TotalConfirmed));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Total Recovered: </b>");
#nullable restore
<<<<<<< HEAD
#line 23 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                   Write(Model.Global.TotalRecovered);
=======
#line 17 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                                  Write(Html.DisplayFor(model => model.Global.TotalConfirmed));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table><br/>\r\n</div>\r\n<br/>\r\n<div class=\"sa-table\">\r\n    <br/>\r\n    <h4>South Africa\'s Statistics</h4>\r\n    <table>\r\n        <tr>\r\n            <td><b>New Confirmed: </b>");
#nullable restore
<<<<<<< HEAD
#line 33 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                 Write(Model.Country.NewConfirmed);
=======
#line 18 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Html.DisplayNameFor(model => model.Global.NewDeaths));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Total Confirmed: </b>");
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                   Write(Model.Country.TotalConfirmed);
=======
#line 18 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                             Write(Html.DisplayFor(model => model.Global.NewDeaths));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>New Deaths: </b>");
#nullable restore
<<<<<<< HEAD
#line 39 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                              Write(Model.Country.NewDeaths);
=======
#line 19 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Html.DisplayNameFor(model => model.Global.TotalDeaths));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Total Deaths: </b>");
#nullable restore
<<<<<<< HEAD
#line 42 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                Write(Model.Country.TotalDeaths);
=======
#line 19 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                               Write(Html.DisplayFor(model => model.Global.TotalDeaths));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>New Recovered: </b>");
#nullable restore
<<<<<<< HEAD
#line 45 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                 Write(Model.Country.NewRecovered);
=======
#line 20 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Html.DisplayNameFor(model => model.Global.NewRecovered));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Total Recovered: </b>");
#nullable restore
<<<<<<< HEAD
#line 48 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                   Write(Model.Global.TotalRecovered);
=======
#line 20 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                                Write(Html.DisplayFor(model => model.Global.NewRecovered));
>>>>>>> master

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Date Recorder: </b>");
#nullable restore
<<<<<<< HEAD
#line 51 "C:\Users\bbdnet1724\Documents\BBD\Grad Program\C# Level-Up\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                 Write(Model.Country.Date);
=======
#line 21 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Html.DisplayNameFor(model => model.Global.TotalRecovered));
>>>>>>> master

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</td>\r\n        </tr>\r\n    </table><br/>\r\n</div>");
=======
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                                  Write(Html.DisplayFor(model => model.Global.TotalRecovered));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 24 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
       Write(Model.Country.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n            <dd style=\"text-indent:50px\">New Confirmed ");
#nullable restore
#line 26 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                  Write(Model.Country.NewConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dd style=\"text-indent:50px\">Total Confirmed  ");
#nullable restore
#line 27 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                     Write(Model.Country.TotalConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dd style=\"text-indent:50px\">New Deaths ");
#nullable restore
#line 28 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                               Write(Model.Country.NewDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dd style=\"text-indent:50px\">Total Deaths  ");
#nullable restore
#line 29 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                  Write(Model.Country.TotalDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dd style=\"text-indent:50px\">New Recovered  ");
#nullable restore
#line 30 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                   Write(Model.Country.NewRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dd style=\"text-indent:50px\">Total Recovered  ");
#nullable restore
#line 31 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                     Write(Model.Country.TotalRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dd style=\"text-indent:50px\">Date Recorded  ");
#nullable restore
#line 32 "C:\Users\bbdnet2165\Documents\Grad Program\Test\Locate-closest-business\Views\Statistics\Summary.cshtml"
                                                   Write(Model.Country.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n    </dl>\r\n</div>");
>>>>>>> master
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Locate_closest_business.Models.SummaryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
