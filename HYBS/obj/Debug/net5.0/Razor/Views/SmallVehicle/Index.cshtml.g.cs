#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1ae61cd9b86c702720203e8a853bed710476cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SmallVehicle_Index), @"mvc.1.0.view", @"/Views/SmallVehicle/Index.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ae61cd9b86c702720203e8a853bed710476cdd", @"/Views/SmallVehicle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_SmallVehicle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmallVehicle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header card-warning card-outline"">
        <h1 class=""card-title"" style=""color:blue""><b>S??STEMDEK?? K??????K ARA?? L??STES??</b><a href=""/SmallVehicle/Balance"" class=""badge btn-primary"" style=""margin-left:900px;font-size:18px;""> Yap??lan i?? listesi</a> <br /> <a href=""/SmallVehicle/AddSmallVehicle"" class=""badge btn-success"" style=""margin-left:900px;font-size:18px;""> +K??????k Ara?? Ekle</a></h1>
  
    
    
    </div>
    <!-- /.card-header -->
    <div class=""card-body "">
        <table id=""example1"" class=""table table-hover table-striped"">
            <thead>
                <tr>
                    <th>AdSoyad</th>

                    <th>T.C/VergiNo</th>
                    <th>Telefon No</th>
                    <th>Arac Plaka</th>
                    <th>Ara?? Tipi</th>

                    <th>Bakiye Sil</th>
                    <th>Kalan Stok Say??s??(Arac)</th>
                    <th>BakiyeY??kle</th>
                    <th>Sil</th>


           ");
            WriteLiteral("     </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><b> ");
#nullable restore
#line 39 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                       Write(k.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                               Write(k.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                   Write(k.VergiNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                   Write(k.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                   Write(k.Plaka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                   Write(k.SmallVehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1648, "\"", 1703, 2);
            WriteAttributeValue("", 1655, "/SmallVehicle/EditSmallVehicle/", 1655, 31, true);
#nullable restore
#line 51 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
WriteAttributeValue("", 1686, k.SmallVehicleId, 1686, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-primary\" style=\"font-size: 14px;\">-BakiyeSil</a>\r\n\r\n\r\n                    </td>\r\n                    <td style=\"color:blue\">\r\n                        <h5> ");
#nullable restore
#line 56 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                        Write(k.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adet</h5>\r\n\r\n                    </td>\r\n\r\n\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1986, "\"", 2035, 2);
            WriteAttributeValue("", 1993, "/SmallVehicle/AddBalance/", 1993, 25, true);
#nullable restore
#line 63 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
WriteAttributeValue("", 2018, k.SmallVehicleId, 2018, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-success\" style=\"font-size: 14px;\">???BakiyeY??kle</a>\r\n\r\n\r\n                    </td>\r\n\r\n\r\n                    <td>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2195, "\"", 2252, 2);
            WriteAttributeValue("", 2202, "/SmallVehicle/DeleteSmallVehicle/", 2202, 33, true);
#nullable restore
#line 71 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
WriteAttributeValue("", 2235, k.SmallVehicleId, 2235, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge btn-danger\" style=\"font-size: 15px;\" , new { onclick=\"return confirm(\'Silmek istiyor musunuz?\')\" }>Sil</a>\r\n                    </td>\r\n\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <th>AdSoyad</th>

                    <th>T.C/VergiNo</th>
                    <th>Telefon No</th>
                    <th>Arac Plaka</th>
                    <th>Ara?? Tipi</th>

                    <th>Bakiye Sil</th>
                    <th>Kalan Stok Say??s??(Arac)</th>
                    <th>BakiyeY??kle</th>
                    <th>Sil</th>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmallVehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
