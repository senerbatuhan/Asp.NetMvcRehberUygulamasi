#pragma checksum "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc68e8fd2d24587a6860dd0ceae486d0399f0eeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kisi_Index), @"mvc.1.0.view", @"/Views/Kisi/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc68e8fd2d24587a6860dd0ceae486d0399f0eeb", @"/Views/Kisi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a1601c64e53ed2ed99c98dd35ff14a1141376f", @"/Views/_ViewImports.cshtml")]
    public class Views_Kisi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RehberUygulamasi.Models.Entities.Kisi>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"d-flex\">\r\n        <h2 class=\"text-center\">Telefon Rehberi</h2>\r\n    </div>\r\n    <br />\r\n    <div class=\"d-flex justify-content-end\">\r\n");
#nullable restore
#line 17 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
         using (Html.BeginForm("Index", "Kisi", FormMethod.Get))
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"input-group\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
           Write(Html.TextBox("ara", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"input-group-append\">\r\n                    <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 675, "\"", 683, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"mr-2 fa fa-search\"></i>Ara\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"margin:10px;\"></span>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 889, "\"", 923, 1);
#nullable restore
#line 30 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
WriteAttributeValue("", 896, Url.Action("Ekle", "Kisi"), 896, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">
            <i class=""fa fa-plus""></i>
            <span>
                Yeni Kişi Oluştur
            </span>
        </a>


    </div>
    <br /><br />
    <br />
    <table class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <th><b>Ad</b></th>
                <th><b>Soyad</b></th>
                <th><b>Telefon</b></th>
                <th><b>İşlemler</b></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 51 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
             foreach (var kisi in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
                   Write(kisi.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
                   Write(kisi.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
                   Write(kisi.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1709, "\"", 1739, 2);
            WriteAttributeValue("", 1716, "/Kisi/Guncelle/", 1716, 15, true);
#nullable restore
#line 59 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
WriteAttributeValue("", 1731, kisi.Id, 1731, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"mr-2 fa fa-user-edit\"></i>\r\n                            <span>Güncelle</span>\r\n                        </a>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1939, "\"", 1964, 2);
            WriteAttributeValue("", 1946, "/Kisi/Sil/", 1946, 10, true);
#nullable restore
#line 63 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
WriteAttributeValue("", 1956, kisi.Id, 1956, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick = ""return confirm('Kişiyi silmek istediğine emin misin?');"">
                            <i class=""mr-2 fa fa-trash""></i> 
                            <span>Sil</span>
                        </a>
                    </td>
                </tr>
");
#nullable restore
#line 69 "C:\Users\Canonka\source\repos\RehberUygulamasi\RehberUygulamasi\Views\Kisi\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RehberUygulamasi.Models.Entities.Kisi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
