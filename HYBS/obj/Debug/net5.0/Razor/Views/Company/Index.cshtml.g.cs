#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392b5e385683dd40c57f09e00919803fc68be902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392b5e385683dd40c57f09e00919803fc68be902", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Company>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"







<div class=""card  card-success card-outline"">
    <div class=""card-header"">
        <h3 class=""card-title"" style=""color:blue""><b> HAFR??YAT F??RMALARI L??STES??</b><a href=""/CompanyBalance/CompanyBalanceAdd"" class=""badge btn-warning"" style=""margin-left:600px;font-size:18px;""> +Firmaya Bakiye Y??kle</a> <a href=""/Company/CompanyAdd"" class=""badge btn-primary"" style=""margin-left:800px;font-size:18px;""> +Yeni Firma Ekle</a></h3>
    </div>
    <!-- /.card-header -->
    <div class=""card-body card  card-success card-outline"">
        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Firma Ad??</th>
                    <th>Vergi No</th>
                    <th>Vergi Dairesi</th>
                    <th>FirmaTip</th>

                    <th>Firma Address</th>
                    <th>FirmaEmail</th>

                    <th>FirmaGrup</th>
                    <th>KalanAra??Bakiye(ADET)</th>
                    <th>FirmaDetay</th>
       ");
            WriteLiteral("             <th>G??ncell/Sil</th>\n\n\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 41 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td><b>");
#nullable restore
#line 44 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
          Write(k.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\n\n\n\n\n        <td>");
#nullable restore
#line 49 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
       Write(k.TexNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 50 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
       Write(k.CompanyTaxOffice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n        <td>");
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
       Write(k.CompanyTip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 53 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
       Write(k.CompanyAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
       Write(k.CompanyEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 55 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
       Write(k.CompanyGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td style=\"color:red\" class=\"text-center\"><h5><b>");
#nullable restore
#line 56 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
                                                    Write(k.CompanyBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </b></h5></td>\n\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1672, "\"", 1715, 2);
            WriteAttributeValue("", 1679, "/Company/CompanyReadAll/", 1679, 24, true);
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
WriteAttributeValue("", 1703, k.CompanyId, 1703, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-primary\" style=\"font-size: 14px;\">???FirmaDetay</a></td>\n\n        <td>\n            <a");
            BeginWriteAttribute("href", " href=\"", 1817, "\"", 1857, 2);
            WriteAttributeValue("", 1824, "/Company/EditCompany/", 1824, 21, true);
#nullable restore
#line 61 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
WriteAttributeValue("", 1845, k.CompanyId, 1845, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-info\" style=\"font-size: 15px;\" }>G??ncelle</a>\n            <a");
            BeginWriteAttribute("href", " href=\"", 1936, "\"", 1978, 2);
            WriteAttributeValue("", 1943, "/Company/DeleteCompany/", 1943, 23, true);
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
WriteAttributeValue("", 1966, k.CompanyId, 1966, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-danger\" style=\"font-size: 15px;\" , new { onclick=\"return confirm(\'Silmek istiyor musunuz?\')\" }>Sil</a>\n        </td>\n\n\n\n\n    </tr>\n");
#nullable restore
#line 69 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <th>Firma Ad??</th>
                    <th>Vergi No</th>
                    <th>Vergi Dairesi</th>
                    <th>FirmaTip</th>

                    <th>FirmaAddress</th>
                    <th>FirmaEmail</th>

                    <th>FirmaGrup</th>
                    <th>KalanAra??Bakiye</th>
                    <th>FirmaDetay</th>
                    <th>G??ncell/Sil</th>

                </tr>
            </tfoot>
        </table>
    </div>
    <!-- /.card-body -->
</div>

");
#nullable restore
#line 93 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Company\Index.cshtml"
Write(await Component.InvokeAsync("VehicleList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
