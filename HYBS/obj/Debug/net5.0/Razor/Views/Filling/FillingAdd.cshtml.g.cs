#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ef06b030270c54dafaa23838aa27ccbc474a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filling_FillingAdd), @"mvc.1.0.view", @"/Views/Filling/FillingAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ef06b030270c54dafaa23838aa27ccbc474a83", @"/Views/Filling/FillingAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_Filling_FillingAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Filling>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
  
    ViewData["Title"] = "FillingAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"


<div class=""card card-default"">
    <div class=""card-header"">
        <h3 class=""card-title"">İnşaat Dolgu iş Talebi Ekleme Sayfası</h3>

        <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                <i class=""fas fa-minus""></i>
            </button>
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                <i class=""fas fa-times""></i>
            </button>
        </div>
    </div>
    <!-- /.card-header -->
");
#nullable restore
#line 26 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
     using (Html.BeginForm("FillingAdd", "Filling", FormMethod.Post))
    {









#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-12 col-sm-6"">

                <div class=""card card-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Yapı Bilgileri</h3>
                    </div>
                    <div class=""card-body"">
                        <!-- Date dd/mm/yyyy -->
                        <div class=""form-group"">
                            <label>Firma Adı:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-laptop""></i></span>
                                </div>
                                ");
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.DropDownListFor(x => x.CompanyId, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->
                        <!-- Date mm/dd/yyyy -->
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <label>Onay tarihi:</label>
                                <div class=""input-group"">

                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text""><i class=""far fa-calendar-alt""></i></span>
                                    </div>
                                    ");
#nullable restore
#line 67 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                               Write(Html.TextBoxFor(x => x.Tarih, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <label>Telefon No:</label>
                                <div class=""input-group"">

                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text""><i class=""far fa-calendar-alt""></i></span>
                                    </div>
                                    ");
#nullable restore
#line 81 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                               Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label> Nereden:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-phone""></i></span>
                                </div>
                                ");
#nullable restore
#line 94 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.Nereden, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->
                        <!-- phone mask -->
                        <div class=""form-group"">
                            <label>Nereye:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-book""></i></span>
                                </div>
                                ");
#nullable restore
#line 107 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.Nereye, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->
                        <!-- phone mask -->

                        <div class=""form-group"">
                            <label>Talep Eden:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""far fa-list-alt""></i></span>
                                </div>
                                ");
#nullable restore
#line 122 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.TalepEden, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <!-- /.input group -->
                        </div>

                        <div class=""form-group"">
                            <label>Kazı Miktarı:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""far fa-list-alt""></i></span>
                                </div>
                                ");
#nullable restore
#line 135 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.Kazı, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <!-- /.input group -->
                        </div>

                        <div class=""form-group"">
                            <label>Dolgu Miktarı:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""far fa-list-alt""></i></span>
                                </div>
                                ");
#nullable restore
#line 148 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.Dolgu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <!-- /.input group -->
                        </div>







                    </div>
                    
                </div>
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6"">
                <div class=""card card-success"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Hafriat Adres  Bilgileri</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label>Üretici Adres:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 178 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.StartParcel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>

                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label>Başlangıç ilçe:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 191 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.StartDistrict, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>

                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label>Başlangıç Ada:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 204 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.StartIsland, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>

                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label>Başlangıç Parsel:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 217 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.StartParcel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>

                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label>Dolgu yapılan ilçe:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 230 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.FınıshDıstrıct, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>

                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label>Dolgu yapılan Ada:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 243 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.FınıshIsland, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>

                            <!-- /.input group -->
                        </div>
                        <div class=""form-group"">
                            <label>Dolguyapılan parsel:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 256 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.FınıshParcel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>


                        </div>

                        <div class=""form-group"">
                            <label>Kullanılan araç plakaları:</label>

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                                </div>
                                ");
#nullable restore
#line 270 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
                           Write(Html.TextBoxFor(x => x.Vehicle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>


                        </div>





                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.form-group -->
            </div>

            <!-- /.col -->
        </div>
        <!-- /.row -->
");
            WriteLiteral("        <button class=\"btn btn-info\" style=\"margin-left:600px;\"> + Firmayı Kaydet</button>\r\n        <br />\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 297 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Filling\FillingAdd.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Filling> Html { get; private set; }
    }
}
#pragma warning restore 1591