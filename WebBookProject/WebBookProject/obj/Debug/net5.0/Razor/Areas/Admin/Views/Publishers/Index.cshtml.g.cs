#pragma checksum "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b909361055f92950cb047fa69324a48dc6a0e28b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Publishers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Publishers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b909361055f92950cb047fa69324a48dc6a0e28b", @"/Areas/Admin/Views/Publishers/Index.cshtml")]
    public class Areas_Admin_Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBookProject.Models.Publisher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_SidebarLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yayınevleri</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Yayınevi Adı\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-success\" asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 629, "\"", 661, 1);
#nullable restore
#line 28 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 644, item.PublisherId, 644, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a>\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-dark\" asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 785, "\"", 817, 1);
#nullable restore
#line 31 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 800, item.PublisherId, 800, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detaylar</a>\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-danger\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 943, "\"", 975, 1);
#nullable restore
#line 34 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 958, item.PublisherId, 958, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Publishers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>\r\n    <a class=\"btn btn-primary\" asp-action=\"Create\">Yayınevi Ekle</a>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBookProject.Models.Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591