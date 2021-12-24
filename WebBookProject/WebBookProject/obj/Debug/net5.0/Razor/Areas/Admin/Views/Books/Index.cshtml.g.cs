#pragma checksum "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ac0e6d55e24b88c8d04ec61fa43c118230142a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ac0e6d55e24b88c8d04ec61fa43c118230142a", @"/Areas/Admin/Views/Books/Index.cshtml")]
    public class Areas_Admin_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBookProject.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_SidebarLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                <label>Kitap Adı</label>
            </th>
            <th>
                <label>Basım Yılı</label>
            </th>
            <th>
                <label>Açıklama</label>
            </th>
            <th>
                <label>Fotoğraf URL'i'</label>
            </th>
            <th>
                <label>Kategori</label>
            </th>
            <th>
                <label>Yayınevi</label>
            </th>
            <th>
                Güncelle
            </th>
            <th>
                Detaylar
            </th>
            <th>
                Sil
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 43 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.publishYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Publisher.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-success\" asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1772, "\"", 1799, 1);
#nullable restore
#line 65 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
WriteAttributeValue("", 1787, item.BookId, 1787, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a> \r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-dark\" asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1924, "\"", 1951, 1);
#nullable restore
#line 68 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
WriteAttributeValue("", 1939, item.BookId, 1939, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detaylar</a> \r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-danger\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2078, "\"", 2105, 1);
#nullable restore
#line 71 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
WriteAttributeValue("", 2093, item.BookId, 2093, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Books\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    <a class=\"btn btn-primary\" asp-action=\"Create\">Kitap Ekle</a>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBookProject.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
