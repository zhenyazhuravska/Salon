#pragma checksum "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef438728c8a9421e183f1042617111e000b21d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AllCategories), @"mvc.1.0.view", @"/Views/Admin/AllCategories.cshtml")]
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
#line 1 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/_ViewImports.cshtml"
using Salon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/_ViewImports.cshtml"
using Salon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef438728c8a9421e183f1042617111e000b21d8", @"/Views/Admin/AllCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9015bd87cbd962ab5026ee09de28f21316d2a663", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AllCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/nicepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-script"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("defer", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/nicepage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
  
    ViewData["Title"] = "?????? ??????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html style=\"font-size: 16px;\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef438728c8a9421e183f1042617111e000b21d87051", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta charset=\"utf-8\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 253, "\"", 263, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"page_type\" content=\"np-template-header-footer-from-plugin\">\n    <title>Home</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ef438728c8a9421e183f1042617111e000b21d87711", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ef438728c8a9421e183f1042617111e000b21d88959", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef438728c8a9421e183f1042617111e000b21d810207", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef438728c8a9421e183f1042617111e000b21d811549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <meta name=""generator"" content=""Nicepage 3.28.7, nicepage.com"">
    <link id=""u-theme-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"">
    <meta name=""theme-color"" content=""#478ac9"">
    <meta property=""og:title"" content=""Home"">
    <meta property=""og:type"" content=""website"">
    <style>
        body {
            font-family: ""Poppins"", -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
        }
        .u-text-palette-1-base svg {
            fill: #8bc34a;
        }
        .text-primary {
            color: #8bc34a !important;
        }
        .bg-image:after {
            background: none;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef438728c8a9421e183f1042617111e000b21d814526", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row justify-content-center mb-5"">
            <div class=""col-md-8"">
                <h2 class=""site-section-heading font-weight-light text-black text-center"">???????? ?????????????????? ????????????</h2>
                <button type=""button"" style=""margin: 3px; width: 32.8%; top:5%; left: 38%;"" class=""btn btn-success col-lg-3 col-xs-3""");
                BeginWriteAttribute("onclick", " onclick=\"", 1991, "\"", 2066, 4);
                WriteAttributeValue("", 2001, "location.href=\'", 2001, 15, true);
#nullable restore
#line 43 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
WriteAttributeValue("", 2016, Url.Action("AddCategory", "Admin"), 2016, 35, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2051, "\';return", 2051, 8, true);
                WriteAttributeValue(" ", 2059, "false;", 2060, 7, true);
                EndWriteAttribute();
                WriteLiteral(@"><span style=""font-size:larger;""><span style=""margin-right: 5px"" class=""glyphicon glyphicon-plus""></span>????????????</span></button>
            </div>
        </div>
        <table class=""table table-striped table-hover table-responsive table-condensed"">
            <tr>
                <th>
                    <h3 style=""font-size: medium""><span style=""font-weight:bolder"">");
#nullable restore
#line 49 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
                                                                              Write(Html.DisplayNameFor(model => model[0].Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h3>\n                </th>\n                <th>\n                    <h3 style=\"font-size: medium\"><span style=\"font-weight:bolder\">");
#nullable restore
#line 52 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
                                                                              Write(Html.DisplayNameFor(model => model[0].Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h3>\n                </th>\n                <th></th>\n            </tr>\n");
#nullable restore
#line 56 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td class=\"col-lg-2\">\n                        <span style=\"font-size: 17px;\">");
#nullable restore
#line 60 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    </td>\n                    <td class=\"col-lg-4\">\n                        <span style=\"font-size: 17px;\">");
#nullable restore
#line 63 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    </td>\n                    <td class=\"col-lg-2\">\n                        <button type=\"button\" class=\"btn btn-warning col-lg-4\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3279, "\"", 3377, 4);
                WriteAttributeValue("", 3289, "location.href=\'", 3289, 15, true);
#nullable restore
#line 66 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
WriteAttributeValue("", 3304, Url.Action("EditCategory", "Admin", new { id = item.Id }), 3304, 58, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3362, "\';return", 3362, 8, true);
                WriteAttributeValue(" ", 3370, "false;", 3371, 7, true);
                EndWriteAttribute();
                WriteLiteral("><span style=\"margin-right: 5px\" class=\"glyphicon glyphicon-pencil\"></span>Edit</button>\n                        <button type=\"button\" class=\"btn btn-danger col-lg-4 col-lg-offset-1\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3560, "\"", 3661, 5);
                WriteAttributeValue("", 3570, "location.href=\'", 3570, 15, true);
#nullable restore
#line 67 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
WriteAttributeValue("", 3585, Url.Action("DeleteCategory", "Admin", new { id = item.Id }), 3585, 60, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3645, "\'", 3645, 1, true);
                WriteAttributeValue(" ", 3646, ";return", 3647, 8, true);
                WriteAttributeValue(" ", 3654, "false;", 3655, 7, true);
                EndWriteAttribute();
                WriteLiteral("><span style=\"margin-right: 5px\" class=\"glyphicon glyphicon-trash\"></span>Delete</button>\n                    </td>\n                </tr>\n");
#nullable restore
#line 70 "/Users/zhenyazhuravska/Projects/Salon/Salon/Views/Admin/AllCategories.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </table>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
