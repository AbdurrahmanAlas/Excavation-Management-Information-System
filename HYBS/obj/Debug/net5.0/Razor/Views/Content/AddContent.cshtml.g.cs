#pragma checksum "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c144adfb49c487e4eca0750f31ce462690cb24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_AddContent), @"mvc.1.0.view", @"/Views/Content/AddContent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c144adfb49c487e4eca0750f31ce462690cb24", @"/Views/Content/AddContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282bb9470335112e619853fe721fa267c5706581", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_AddContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Content>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
  
    ViewData["Title"] = "AddContent";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h2 style=\"margin-left:420px;color:blue\">✦ Yapılan İşlem Adımı Ekleme</h2>\r\n<br />\r\n\r\n<h3 class=\"text-center btn btn-success\" style=\"max-width:30%;margin-left:430px;\">");
#nullable restore
#line 13 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
                                                                            Write(ViewBag.m);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n");
#nullable restore
#line 14 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
 using (Html.BeginForm("AddContent", "Content", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group \" style=\"margin-left:350px;color:black\">\r\n\r\n        <input type=\"hidden\" name=\"HeadingID\"");
            BeginWriteAttribute("value", " value=\"", 509, "\"", 527, 1);
#nullable restore
#line 18 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
WriteAttributeValue("", 517, ViewBag.d, 517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"HeadingName\"");
            BeginWriteAttribute("value", " value=\"", 580, "\"", 598, 1);
#nullable restore
#line 19 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
WriteAttributeValue("", 588, ViewBag.v, 588, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n        ");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
   Write(Html.Label(" Firmaya/Hafriyatçıya yapılan işlemi giriniz:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
   Write(Html.TextAreaFor(x => x.ContentValue, 4, 20, new { @class = "form-control", style = "max-width:60%" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"
   Write(Html.ValidationMessageFor(x => x.ContentValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n        <button class=\"btn btn-info\">+ Yapılan işlem Ekle</button>\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\lenovo\Desktop\HYBS12\HYBS12\HYBS\HYBS\Views\Content\AddContent.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Content> Html { get; private set; }
    }
}
#pragma warning restore 1591
