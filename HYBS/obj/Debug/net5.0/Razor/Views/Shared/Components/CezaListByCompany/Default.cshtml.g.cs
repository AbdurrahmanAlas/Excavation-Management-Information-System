#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27040d82eb3ba814a250bb3be2b11ae35d4618c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CezaListByCompany_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CezaListByCompany/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27040d82eb3ba814a250bb3be2b11ae35d4618c2", @"/Views/Shared/Components/CezaListByCompany/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CezaListByCompany_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Punishment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;width:260px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"" style=""color:blue""><b> FİRMA CEZALARI LİSTESİ</b></h3>
    </div>
    <!-- /.card-header -->
    <div class=""card-body"">
        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                  
              
             
               

                    <th>Ceza YazanEkip</th>
                    <th>Açıklama</th>

                    <th>Döküman Adı</th>
                    
                    <th>Ceza Miktarı</th>
                    <th>Ceza Tarihi</th>
                  
                    <th>Sil</th>
                    <th>Görüntüle</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    \r\n\r\n                \r\n                    <td>");
#nullable restore
#line 44 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                   Write(k.CezaTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                   Write(k.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                   Write(k.DocumentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                   Write(k.CezaAmont);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                   Write(k.CezaDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1258, "\"", 1308, 2);
            WriteAttributeValue("", 1265, "/Company/DeleteCompanyDocument/", 1265, 31, true);
#nullable restore
#line 51 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
WriteAttributeValue("", 1296, k.CompanyId, 1296, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""badge btn-danger"" style=""font-size: 15px;"" , new { onclick=""return confirm('Silmek istiyor musunuz?')"" }>Sil</a>


                    </td>
                    <td>

                        <div class=""col-md-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27040d82eb3ba814a250bb3be2b11ae35d4618c27441", async() => {
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27040d82eb3ba814a250bb3be2b11ae35d4618c27696", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1616, "~/imageFiles/", 1616, 13, true);
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
AddHtmlAttributeValue("", 1629, k.CezaPhoto, 1629, 12, false);

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
            AddHtmlAttributeValue("", 1575, "~/imageFiles/", 1575, 13, true);
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
AddHtmlAttributeValue("", 1588, k.CezaPhoto, 1588, 12, false);

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
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 64 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Shared\Components\CezaListByCompany\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n           \r\n        </table>\r\n    </div>\r\n    <!-- /.card-body -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Punishment>> Html { get; private set; }
    }
}
#pragma warning restore 1591