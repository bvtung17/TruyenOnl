#pragma checksum "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/Book/ChapterList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc43104b5b837b2b401e75cc4f6404e6af867d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ChapterList), @"mvc.1.0.view", @"/Views/Book/ChapterList.cshtml")]
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
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/_ViewImports.cshtml"
using TruyenOnl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/_ViewImports.cshtml"
using TruyenOnl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc43104b5b837b2b401e75cc4f6404e6af867d9", @"/Views/Book/ChapterList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b138006130c631d7f0e088f41b3890c6d7c0eb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ChapterList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-outline-dark m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/EditBook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/ChapterList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/CreateChapter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/statistic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group input-group-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/Book/ChapterList.cshtml"
  
    Layout = "~/Views/Shared/_LayoutBook.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <div class=\"row bg-title\">\n        <div class=\"col-lg-3 col-md-4 col-sm-4 col-xs-12\">\n            <h4 class=\"page-title\"");
            BeginWriteAttribute("style", " style=\"", 210, "\"", 218, 0);
            EndWriteAttribute();
            WriteLiteral(">Quản Lý Truyện</h4>\n        </div>\n        <div class=\"col-lg-9 col-sm-8 col-md-8 col-xs-12\">\n            <ol class=\"breadcrumb\" style=\"background-color:rgb(252, 252, 252);\">\n                <li class=\"breadcrumb-item ml-auto\"><a href=\"#\"");
            BeginWriteAttribute("style", " style=\"", 458, "\"", 466, 0);
            EndWriteAttribute();
            WriteLiteral(@">Quản lý</a></li>
                <li class=""breadcrumb-item active"">Ta Thật Không Phải Là Tiên Nhị Đại</li>
            </ol>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""white-box"">
                <div>
                    <nav>
                        <ul class=""nav nav-pills nav-fill"">
                            <li class=""nav-item"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43104b5b837b2b401e75cc4f6404e6af867d96996", async() => {
                WriteLiteral("Chỉnh Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                            <li class=\"nav-item\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43104b5b837b2b401e75cc4f6404e6af867d98259", async() => {
                WriteLiteral("Danh Sách Chương");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                            <li class=\"nav-item\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43104b5b837b2b401e75cc4f6404e6af867d99529", async() => {
                WriteLiteral("Thêm Chương");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                            <li class=\"nav-item\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43104b5b837b2b401e75cc4f6404e6af867d910794", async() => {
                WriteLiteral("Thống Kê");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-12 bg-content"">
            <div class=""white-box"">
                <ul class=""nav nav-tabs"" role=""tablist"">
                    <li class=""btn btn-success mt-2 mb-3"">Đã Đăng (594)</li>
                </ul>

                <div class=""tab-content"">
                    <div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43104b5b837b2b401e75cc4f6404e6af867d912461", async() => {
                WriteLiteral("\n                            <input type=\"number\" class=\"form-control\" name=\"index\"");
                BeginWriteAttribute("value", " value=\"", 2228, "\"", 2236, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Tìm STT\">\n                            <span class=\"input-group-btn\">\n                                <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\n                            </span>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43104b5b837b2b401e75cc4f6404e6af867d914265", async() => {
                WriteLiteral(@"
                            <div>
                                <table class=""table table-hover manage-u-table"">
                                    <thead>
                                        <tr>
                                            <th width=""20""><input type=""checkbox"" id=""checkAllChapter""></th>
                                            <th width=""30"" class=""text-center"">STT</th>
                                            <th>Tên chương</th>
                                            <th>Ngày xuất bản</th>
                                            <th>Lượt xem</th>
                                            <th width=""150"">Thao tác</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <td><input type=""checkbox""></td>
                                            <td class=""text-center"">594</td>
                    ");
                WriteLiteral(@"                        <td><a href=""#"">Chương 593: Cốt Thi Vương kinh khủng</a></td>
                                            <td>23/09/2020 21:10:01</td>
                                            <td>26</td>
                                            <td>
                                                <a href=""#"" type=""button"" class=""btn btn-warning btn-outline btn-circle btn-xs m-r-5"">Sửa</a>
                                                <button type=""button"" class=""btn btn-danger btn-outline btn-circle btn-xs m-r-5"">Xóa</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td><input type=""checkbox""></td>
                                            <td class=""text-center"">593</td>
                                            <td><a href=""#"">Chương 593: Cốt Thi Vương kinh khủng</a></td>
                                            <td>23/09/2020 21:10:01</td>
  ");
                WriteLiteral(@"                                          <td>26</td>
                                            <td>
                                                <a href=""#"" type=""button"" class=""btn btn-warning btn-outline btn-circle btn-xs m-r-5"">Sửa</a>
                                                <button type=""button"" class=""btn btn-danger btn-outline btn-circle btn-xs m-r-5"">Xóa</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td><input type=""checkbox""></td>
                                            <td class=""text-center"">592</td>
                                            <td><a href=""#"">Chương 592: Cốt Thi Vương kinh khủng</a></td>
                                            <td>23/09/2020 21:10:01</td>
                                            <td>26</td>
                                            <td>
                                                <a href=""#");
                WriteLiteral(@""" type=""button"" class=""btn btn-warning btn-outline btn-circle btn-xs m-r-5"">Sửa</a>
                                                <button type=""button"" class=""btn btn-danger btn-outline btn-circle btn-xs m-r-5"">Xóa</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td><input type=""checkbox""></td>
                                            <td class=""text-center"">591</td>
                                            <td><a href=""#"">Chương 591: Cốt Thi Vương kinh khủng</a></td>
                                            <td>23/09/2020 21:10:01</td>
                                            <td>26</td>
                                            <td>
                                                <a href=""#"" type=""button"" class=""btn btn-warning btn-outline btn-circle btn-xs m-r-5"">Sửa</a>
                                                <button type=""button"" class=""");
                WriteLiteral(@"btn btn-danger btn-outline btn-circle btn-xs m-r-5"">Xóa</button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <ul class=""pagination"" role=""navigation"">
                                <li class=""page-item disabled "" aria-disabled=""true"">
                                    <span class=""page-link"" aria-hidden=""true"">‹</span>
                                </li>
                                <li class=""page-item active"" aria-current=""page""><span class=""page-link"">1</span></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">...</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">20</a></li>
                                <li class=""page-item ");
                WriteLiteral(@"disabled "" aria-disabled=""true"">
                                    <span class=""page-link"" aria-hidden=""true"">></span>
                                </li>
                            </ul>
                            <button type=""button"" class=""btn waves-effect waves-light btn-danger"">Xóa Đã Chọn</button>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
