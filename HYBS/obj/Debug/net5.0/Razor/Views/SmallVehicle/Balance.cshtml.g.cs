#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e24832cf43782e1f23756a1e7209191a96c3970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SmallVehicle_Balance), @"mvc.1.0.view", @"/Views/SmallVehicle/Balance.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e24832cf43782e1f23756a1e7209191a96c3970", @"/Views/SmallVehicle/Balance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_SmallVehicle_Balance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BalanceSmall>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
  
    ViewData["Title"] = "Balance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"" style=""color:blue""><b> KÜÇÜK ARAÇ İŞ LİSTESİ</b> </h3>
    </div>
   
    <!-- /.card-header -->
    <div class=""card-body"">
        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>

                    <th>Talep Sahibi</th>
                    <th>Tarih</th>


                    <th>Araç plaka</th>
                    <th>Araç Tipi</th>
                    <th>TelefonNo</th>


                    <th>İlçe/Mahalle</th>
                    <th>Ada/Parsel</th>
                    <th>Tahakkuk Miktar</th>
                    <th>Araç Miktar</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"background-color:#bfebea\"><b>");
#nullable restore
#line 38 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                                                           Write(k.SmallVehicle.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 38 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                                                                                 Write(k.SmallVehicle.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 40 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                        Write(((DateTime)
                          k.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.SmallVehicle.Plaka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.SmallVehicle.SmallVehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.SmallVehicle.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.Island);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /");
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                                  Write(k.Parcel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.TahakkukMiktarı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                       Write(k.miktar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\SmallVehicle\Balance.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <th>Talep Sahibi</th>
                    <th>Tarih</th>


                    <th>Araç plaka</th>
                    <th>Araç Tipi</th>
                    <th>TelefonNo</th>


                    <th>İlçe/Mahalle</th>
                    <th>Ada/Parsel</th>
                    <th>Tahakkuk Miktar</th>
                    <th>Araç Miktar</th>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BalanceSmall>> Html { get; private set; }
    }
}
#pragma warning restore 1591
