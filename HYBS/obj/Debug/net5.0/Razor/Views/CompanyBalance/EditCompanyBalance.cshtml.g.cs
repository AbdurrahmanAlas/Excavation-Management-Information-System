#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30717537dfea565c3f9138b8b05ac80fdecea1ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyBalance_EditCompanyBalance), @"mvc.1.0.view", @"/Views/CompanyBalance/EditCompanyBalance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30717537dfea565c3f9138b8b05ac80fdecea1ee", @"/Views/CompanyBalance/EditCompanyBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_CompanyBalance_EditCompanyBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.CompanyBalance>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
  
    ViewData["Title"] = "EditCompanyBalance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30717537dfea565c3f9138b8b05ac80fdecea1ee4607", async() => {
                WriteLiteral(@"

    <div class=""row"">
        <div class=""col-12 col-sm-12"">

            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Firma Bilgileri</h3>
                </div>
                <div class=""card-body"">
                    <!-- Date dd/mm/yyyy -->
                    <div class=""form-group"">
");
                WriteLiteral(@"
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-laptop""></i></span>
                            </div>
                            ");
#nullable restore
#line 26 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.HiddenFor(x => x.CompanyBalanceID));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>
                    <div class=""form-group"">
                        <label>Firma Adı:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-laptop""></i></span>
                            </div>
                            ");
#nullable restore
#line 38 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.DropDownListFor(x => x.CompanyId, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>

                        <!-- /.input group -->
                    </div>
                    <div class=""form-group"">
                        <label>İşlem Tarihi:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-laptop""></i></span>
                            </div>
                            ");
#nullable restore
#line 50 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.DateTime, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>
                    <!--<div class=""form-group"">
                    <div class=""input-group"">
                        <label>Dekont Belge Yükle:</label>
                        <input type=""file"" name=""DocumentPhoto"" multiple class=""form-control"" />
                    </div>-->
                    <!-- /.input group -->
                    <!--</div>-->
                    <!-- phone mask -->
                    <div class=""form-group"">
                        <label>Tahakkuk Miktarı:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-book""></i></span>
                            </div>
                            ");
#nullable restore
#line 70 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.Amount, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>
                    <div class=""form-group"">
                        <label>Hafriyat Adresi:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-book""></i></span>
                            </div>
                            ");
#nullable restore
#line 82 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.District, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>
                    <div class=""form-group"">
                        <label>Ada:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-book""></i></span>
                            </div>
                            ");
#nullable restore
#line 94 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.Island, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>
                    <div class=""form-group"">
                        <label>Parsel:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-book""></i></span>
                            </div>
                            ");
#nullable restore
#line 106 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.Parcel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>
                    <div class=""form-group"">
                        <label>Açıklama:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-book""></i></span>
                            </div>
                            ");
#nullable restore
#line 118 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.FillArea, new { @class = "form-control" }));

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
                        <label>Araç Miktarı:</label>

                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fas fa-calculator""></i></span>
                            </div>
                            ");
#nullable restore
#line 134 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\CompanyBalance\EditCompanyBalance.cshtml"
                       Write(Html.TextBoxFor(x => x.miktar, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                        <!-- /.input group -->
                    </div>



                    <!-- /.col --> <button class=""btn btn-info"" style=""margin-left:600px;""> + Firmayı Kaydet</button>
                </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- /.row -->\r\n\r\n\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.CompanyBalance> Html { get; private set; }
    }
}
#pragma warning restore 1591
