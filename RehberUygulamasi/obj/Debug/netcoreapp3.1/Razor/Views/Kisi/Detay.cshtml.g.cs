#pragma checksum "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9225ccd82f463b71655c2bba0da4d481f294f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kisi_Detay), @"mvc.1.0.view", @"/Views/Kisi/Detay.cshtml")]
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
#line 1 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\_ViewImports.cshtml"
using RehberUygulamasi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\_ViewImports.cshtml"
using RehberUygulamasi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9225ccd82f463b71655c2bba0da4d481f294f6", @"/Views/Kisi/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a1601c64e53ed2ed99c98dd35ff14a1141376f", @"/Views/_ViewImports.cshtml")]
    public class Views_Kisi_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RehberUygulamasi.Models.Entities.Kisi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container col-xl-6 col-lg-8 col-md-8 col-sm-12 p-3\">\r\n    <h2>Kişi Detay</h2>\r\n    ");
#nullable restore
#line 10 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml"
Write(Html.Hidden("id", Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"list-group-item list-group-item-action\">\r\n        <label class=\"card-title\">Ad:</label>\r\n        <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml"
                        Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"list-group-item list-group-item-action\">\r\n        <label class=\"card-title\">Soyad:</label>\r\n        <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml"
                        Write(Model.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"list-group-item list-group-item-action\">\r\n        <label class=\"card-title\">Telefon:</label>\r\n        <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml"
                        Write(Model.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"d-flex justify-content-between mt-1\">\r\n    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 908, "\"", 939, 2);
            WriteAttributeValue("", 915, "/Kisi/Guncelle/", 915, 15, true);
#nullable restore
#line 26 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml"
WriteAttributeValue("", 930, Model.Id, 930, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <i class=\"mr-2 fa fa-save\"></i>\r\n        <span>Güncelle</span>\r\n    </a>\r\n    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1054, "\"", 1080, 2);
            WriteAttributeValue("", 1061, "/Kisi/Sil/", 1061, 10, true);
#nullable restore
#line 30 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Detay.cshtml"
WriteAttributeValue("", 1071, Model.Id, 1071, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Kişiyi silmek istediğine emin misin?\');\">\r\n        <i class=\"mr-2 fa fa-trash\"></i>\r\n        <span>Sil</span>\r\n    </a>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RehberUygulamasi.Models.Entities.Kisi> Html { get; private set; }
    }
}
#pragma warning restore 1591
