#pragma checksum "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b754346aded615762745af71a3436e8c58f82a2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b754346aded615762745af71a3436e8c58f82a2b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47462419d3f0a0cf829706ac3076f7c339468a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/h1-custom-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    HomeViewModel homeViewModel = Model;
    List<SliderImage> sliderImages = homeViewModel.SliderImages;
    Slider slider = homeViewModel.Sldier;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- SLIDER START -->\r\n\r\n<section id=\"slider\">\r\n    <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 13 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
         foreach (var item in sliderImages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b5630", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 367, "~/img/", 367, 6, true);
#nullable restore
#line 15 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 373, item.Name, 373, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 16 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"container context pl-lg-5 ml-lg-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"text\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
               Write(Html.Raw(slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p class=\"text-black-50 d-none d-sm-block\">");
#nullable restore
#line 23 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                          Write(slider.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b8281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 795, "~/img/", 795, 6, true);
#nullable restore
#line 26 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 801, slider.SignatureImage, 801, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SLIDER END -->
<!-- PRODUCTS START -->

<section id=""products"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-12 d-flex justify-content-between"">
                <ul class=""category-mobile d-md-none list-unstyled"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1241, "\"", 1248, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                        <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1467, "\"", 1474, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 46 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                             foreach (var item in homeViewModel.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1650, "\"", 1657, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 48 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                   Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 48 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1919, "\"", 1926, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 55 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                     foreach (var item in homeViewModel.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2078, "\"", 2085, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 57 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                           Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 57 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 58 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2281, "\"", 2288, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 69 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Product", 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"        </div>
    </div>
</section>

<!-- PRODUCTS END -->
<!-- ABOUT START -->

<section id=""about"">
    <div class=""container py-5"">
        <div class=""row py-5"">
            <div class=""col-lg-6"">
                <div class=""img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b14770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3819, "~/img/", 3819, 6, true);
#nullable restore
#line 102 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3825, homeViewModel.AboutImages.Name, 3825, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                        <i class=""fas fa-play fa-lg""></i>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                    ");
#nullable restore
#line 110 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
               Write(Html.Raw(homeViewModel.About.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p class=\"py-3\">\r\n                        ");
#nullable restore
#line 112 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                   Write(homeViewModel.About.Subitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 115 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                         foreach (var item in homeViewModel.Suggestions)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"mt-3\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b17857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 118 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 120 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- ABOUT END -->
<!-- EXPERTS START -->

<section id=""experts"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>");
#nullable restore
#line 136 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                   Write(homeViewModel.ExpetsTitles.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                        ");
#nullable restore
#line 138 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                   Write(homeViewModel.ExpetsTitles.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n");
#nullable restore
#line 144 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
             foreach (var item in homeViewModel.ExpertsImages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"item text-center\">\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b21143", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5662, "~/img/", 5662, 6, true);
#nullable restore
#line 149 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5668, item.Image, 5668, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"text mt-3\">\r\n                            <h6>");
#nullable restore
#line 152 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p class=\"text-black-50\">");
#nullable restore
#line 153 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 157 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-3""></div>
            <div class=""col-lg-3""></div>
            <div class=""col-lg-3""></div>
        </div>
    </div>
</section>

<!-- EXPERTS END -->
<!-- SUBSCRIBE START -->

<section id=""subscribe"">
    <div class=""container py-5"">
        <div class=""row py-5"">
            <div class=""col-12"">
                <div class=""content text-center py-5"">
                    <h3>Join The Colorful Bunch!</h3>
                    <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                        <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                        <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<style>
    {
         background: url(../img/");
#nullable restore
#line 185 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                           Write(homeViewModel.Banner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
    }
</style>

<!-- SUBSCRIBE END -->
<!-- BLOG START -->

<section id=""blog"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>");
#nullable restore
#line 197 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                   Write(homeViewModel.BlogTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                        ");
#nullable restore
#line 199 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                   Write(homeViewModel.BlogTitle.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n");
#nullable restore
#line 205 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
             foreach (var item in homeViewModel.BlogItems)
	         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b26463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7768, "~/img/", 7768, 6, true);
#nullable restore
#line 210 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7774, item.Image, 7774, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>");
#nullable restore
#line 216 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 218 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 223 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
	         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<!-- BLOG END -->
<!-- SAY START -->

<section id=""say"">
    <div class=""container"">
        <div class=""row py-5 justify-content-center"">
            <div class=""col-md-8 col-xl-6"">
                <div class=""owl-carousel say"">
");
#nullable restore
#line 236 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                     foreach (var item in homeViewModel.Carousels)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b30151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8973, "~/img/", 8973, 6, true);
#nullable restore
#line 241 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8979, item.Image, 8979, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"text text-muted pt-3 pb-5\">\r\n                                    <i>\r\n                                        ");
#nullable restore
#line 245 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </i>\r\n                                </div>\r\n                                <div class=\"author\">\r\n                                    <h6>");
#nullable restore
#line 249 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
#nullable restore
#line 250 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                                                        Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 254 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- SAY END -->\r\n<!-- INSTAGRAM START -->\r\n\r\n<section id=\"instagram\">\r\n    <div class=\"owl-carousel instagram\">\r\n");
#nullable restore
#line 266 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
         foreach (var item in homeViewModel.Socials)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b754346aded615762745af71a3436e8c58f82a2b33801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9913, "~/img/", 9913, 6, true);
#nullable restore
#line 268 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9919, item.image, 9919, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 269 "C:\Users\lasly\OneDrive\Desktop\homework4\WebApplication4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n        #FIORELLO\r\n    </div>\r\n</section>\r\n\r\n<!-- INSTAGRAM END -->\r\n");
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
