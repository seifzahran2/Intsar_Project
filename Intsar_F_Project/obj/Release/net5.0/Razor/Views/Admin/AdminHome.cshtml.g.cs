#pragma checksum "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115c1f64f72a04de660f1fee2316a878c49793d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminHome), @"mvc.1.0.view", @"/Views/Admin/AdminHome.cshtml")]
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
#line 1 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\_ViewImports.cshtml"
using Intsar_F_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\_ViewImports.cshtml"
using Intsar_F_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115c1f64f72a04de660f1fee2316a878c49793d4", @"/Views/Admin/AdminHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabdc8f4a964fa46aa2463da304166ba894228d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleA.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserMangment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResultHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/script/scriptA.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d46639", async() => {
                WriteLiteral("\r\n    <title>Admin Page</title>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "115c1f64f72a04de660f1fee2316a878c49793d47113", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <title>regist the compatetor</title>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d49377", async() => {
                WriteLiteral(@"

    <div class=""new-container"">
        <!-- navigation bar -->
        <div class=""navigation"">
            <ul>
                <li>
                    <a href=""#"">
                        <span class=""icon""></span>
                        <span class=""title""></span>
                    </a>
                </li>
                <li>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d410016", async() => {
                    WriteLiteral("\r\n                        <span class=\"icon\">\r\n                            <i class=\"bi bi-house-door\"></i>\r\n                        </span>\r\n                        <span class=\"title\">الصفحه الرئيسيه</span>\r\n\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </li>\r\n\r\n                <li>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d411767", async() => {
                    WriteLiteral("\r\n                        <span class=\"icon\"><i class=\"bi bi-kanban\"></i></span>\r\n                        <span class=\"title\">اداره المستخدمين</span>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d413447", async() => {
                    WriteLiteral("\r\n                        <span class=\"icon\">\r\n                            <i class=\"bi bi-check2-circle\"></i>\r\n\r\n                        </span>\r\n                        <span class=\"title\">صفحه الرسائل وقبول الطلبات</span>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d415208", async() => {
                    WriteLiteral("\r\n                        <span class=\"icon\"><i class=\"bi bi-file-earmark-person\"></i></span>\r\n                        <span class=\"title\">النتائج</span>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
        </div>

        <!-- main -->
        <div class=""main"">
            <div class=""topbar"">
                <div class=""toggle"">
                    <i class=""bi bi-list""></i>
                </div>

                <!-- userImg -->
                <div class=""user"">
                    <img src=""../HOME PAGE/IMG/downloadasdasdas.jpg"">
                </div>

            </div>

            <!-- cards -->

            <div class=""cardbx "">
                <div class=""card "">
                    <div class=""numbers "">");
#nullable restore
#line 82 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                                     Write(ViewBag.CompsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                    <div class=""cardname "">عدد المتسابقين</div>
                    <div class=""iconbx"">
                        <i class=""bi bi-award""></i>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""numbers"">");
#nullable restore
#line 89 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                                    Write(ViewBag.JudgesCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                    <div class=""cardname"">عدد المصححيين</div>
                    <div class=""iconbx"">
                        <i class=""bi bi-list-ol""></i>
                    </div>
                </div>
            </div>

            <div class=""details"">
                <!-- accept or reject list  -->
                <div class=""recentorder"">
                    <div class=""cardheader"">
                        <h2>جدول قبول الطلبات</h2>

                    </div>
                    <table>
                        <thead>
                            <tr>
                                <td>الأسم بالكامل</td>
                                <td>البريد الاكتروني</td>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 113 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                             foreach (var item in ViewBag.compReg)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n\r\n                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 4266, "\"", 4300, 2);
                WriteAttributeValue("", 4273, "/Admin/CompRequest/", 4273, 19, true);
#nullable restore
#line 117 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
WriteAttributeValue("", 4292, item.Id, 4292, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 117 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                                                                         Write(item.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 4369, "\"", 4403, 2);
                WriteAttributeValue("", 4376, "/Admin/CompRequest/", 4376, 19, true);
#nullable restore
#line 118 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
WriteAttributeValue("", 4395, item.Id, 4395, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 118 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                                                                         Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 121 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </tbody>
                    </table>
                </div>
                <!-- chats -->
                <div class=""recentcustomer"">
                    <div class=""cardheader"">
                        <h2>الرسائل</h2>
                    </div>

                    <table>
                        <tbody>
");
#nullable restore
#line 135 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 5018, "\"", 5048, 2);
                WriteAttributeValue("", 5025, "/Admin/Message/", 5025, 15, true);
#nullable restore
#line 138 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
WriteAttributeValue("", 5040, item.Id, 5040, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 138 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                                                                     Write(item.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 140 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\AdminHome.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </tbody>
                    </table>
                </div>

            </div>

        </div>

    </div>



    <!-- java script coding -->
    <script type=""module"" src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js""></script>
    <script nomodule src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115c1f64f72a04de660f1fee2316a878c49793d423333", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591