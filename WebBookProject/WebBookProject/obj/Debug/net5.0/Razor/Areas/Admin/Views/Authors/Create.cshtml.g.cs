#pragma checksum "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Authors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9502e3d05e9ed4384a98c24715df08e042878b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Authors_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Authors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9502e3d05e9ed4384a98c24715df08e042878b3", @"/Areas/Admin/Views/Authors/Create.cshtml")]
    public class Areas_Admin_Views_Authors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBookProject.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Authors\Create.cshtml"
  
    ViewData["Title"] = "Yazar Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ekle</h1>

<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""AuthorName"" class=""control-label"">Yazar Adı</label>
                <input asp-for=""AuthorName"" class=""form-control"" />
                <span asp-validation-for=""AuthorName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthorLastname"" class=""control-label"">Yazar Soyadı</label>
                <input asp-for=""AuthorLastname"" class=""form-control"" />
                <span asp-validation-for=""AuthorLastname"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Biography"" class=""control-label"">Biyografi</label>
                <input asp-for=""Biography"" class=""form-control"" />
                <span asp-validation-for=");
            WriteLiteral(@"""Biography"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Ekle"" class=""btn btn-outline-success"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a class=""btn btn-info"" asp-action=""Index"">Geri Dön</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\tansu\source\repos\WebProgramlama\Web-Programlama-Projesi\WebBookProject\WebBookProject\Areas\Admin\Views\Authors\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBookProject.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
