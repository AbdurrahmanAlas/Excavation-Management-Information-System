#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23570b3becf49791f024a5977cc770fdd87593e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_VehicleListByCompany1), @"mvc.1.0.view", @"/Views/Vehicle/VehicleListByCompany1.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\_ViewImports.cshtml"
using HYBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\_ViewImports.cshtml"
using HYBS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23570b3becf49791f024a5977cc770fdd87593e3", @"/Views/Vehicle/VehicleListByCompany1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_VehicleListByCompany1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;width:310px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
  
    ViewData["Title"] = "VehicleListByCompany1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card  card-warning card-outline"">
    <div class=""card-header"">
        <h3 class=""card-title"" style=""color:blue""><b> HAFR??YAT ARA??LARI L??STES??</b>  <a href=""/Vehicle/VehicleAdd"" class=""badge btn-success"" style=""margin-left:900px;font-size:18px;""> +Ara?? Ekle</a></h3>
    </div>
    <!-- /.card-header -->
    <div class=""card  card-warning card-outline"">
        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Firma Ad??</th>

                    <th>Ara?? Plaka</th>
                    <th>Ara?? Model</th>


                    <th>HGS no</th>
                    <th>IMEI no</th>

                    <th>Model Y??l??</th>
                    <th>??zinBiti??</th>
                    <th>FirmaDetay</th>
                    <th>G??ncelle</th>
                    <th>Sil</th>
                    <th>Ara?? Fotograf</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"background-color:ivory\">\r\n\r\n\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.Company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.VehiclePlaka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.VehicleModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.VehicleHGS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.VehicleIMEI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.VehicleYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
                   Write(k.VehicleIzinBitis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                  \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1689, "\"", 1732, 2);
            WriteAttributeValue("", 1696, "/Company/CompanyReadAll/", 1696, 24, true);
#nullable restore
#line 66 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
WriteAttributeValue("", 1720, k.CompanyId, 1720, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-primary\" style=\"font-size: 14px;\">???FirmaBilgileri</a></td>\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1865, "\"", 1905, 2);
            WriteAttributeValue("", 1872, "/Vehicle/EditVehicle/", 1872, 21, true);
#nullable restore
#line 69 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
WriteAttributeValue("", 1893, k.VehicleId, 1893, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-info\" style=\"font-size: 15px;\">??? G??ncelle</a>\r\n                     </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2051, "\"", 2093, 2);
            WriteAttributeValue("", 2058, "/Vehicle/DeleteVehicle/", 2058, 23, true);
#nullable restore
#line 72 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
WriteAttributeValue("", 2081, k.VehicleId, 2081, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""badge btn-danger"" style=""font-size: 15px;"" , new { onclick=""return confirm('Silmek istiyor musunuz?')"" }>??? Sil</a>
                    </td>

                      <td>

                        <div class=""col-md-3"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23570b3becf49791f024a5977cc770fdd87593e39543", async() => {
                WriteLiteral("  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23570b3becf49791f024a5977cc770fdd87593e39796", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2408, "~/imageBalance/", 2408, 15, true);
#nullable restore
#line 79 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
AddHtmlAttributeValue("", 2423, k.VehicleBrand, 2423, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2364, "~/imageBalance/", 2364, 15, true);
#nullable restore
#line 79 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
AddHtmlAttributeValue("", 2379, k.VehicleBrand, 2379, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Vehicle\VehicleListByCompany1.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <th>Firma Ad??</th>

                    <th>Ara?? Plaka</th>
                    <th>Ara?? Model</th>


                    <th>HGS no</th>
                    <th>IMEI no</th>

                    <th>Model Y??l??</th>
                    <th>??zinBiti??</th>
                    <th>FirmaDetay</th>
                    <th>G??ncelle</th>
                    <th>Sil</th>
                    <th>Ara?? Fotograf</th>

                </tr>
            </tfoot>
        </table>
    </div>
    <!-- /.card-body -->
</div>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
