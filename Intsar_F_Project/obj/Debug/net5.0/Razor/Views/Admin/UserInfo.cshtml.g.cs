#pragma checksum "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf8a6b365b1d4fab969a716946a20db37e46062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserInfo), @"mvc.1.0.view", @"/Views/Admin/UserInfo.cshtml")]
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
#nullable restore
#line 1 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
using Intsar_F_Project.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf8a6b365b1d4fab969a716946a20db37e46062", @"/Views/Admin/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabdc8f4a964fa46aa2463da304166ba894228d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleA.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserMangment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResultHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/Profilett.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e460627585", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>تحديد الوظيفه</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3cf8a6b365b1d4fab969a716946a20db37e460628062", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e4606210284", async() => {
                WriteLiteral(@"
    <div class=""new-container"" >
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e4606210927", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e4606212678", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e4606214358", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e4606216119", async() => {
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

                <!-- userImg  ADMIN-->
                <div class=""user"">
");
#nullable restore
#line 74 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                     if (UserManager.GetUserAsync(User).Result.ProfilePic != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"nav-link nav-profile\" href=\"#\" id=\"navbarDropdown\"  data-bs-toggle=\"dropdown\" aria-expanded=\"false\" >\r\n                         <img");
                BeginWriteAttribute("src", " src=\"", 3078, "\"", 3179, 2);
                WriteAttributeValue("", 3084, "data:image/*;base64,", 3084, 20, true);
#nullable restore
#line 77 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
WriteAttributeValue("", 3104, Convert.ToBase64String(UserManager.GetUserAsync(User).Result.ProfilePic), 3104, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3180, "\"", 3186, 0);
                EndWriteAttribute();
                WriteLiteral(" > <span > ");
#nullable restore
#line 77 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                                                                                                                                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                    </a>\r\n");
#nullable restore
#line 79 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"nav-link nav-profile\" href=\"#\" id=\"navbarDropdown\"  data-bs-toggle=\"dropdown\" aria-expanded=\"false\" >\r\n                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3cf8a6b365b1d4fab969a716946a20db37e4606219987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <span > ");
#nullable restore
#line 83 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                                                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                    </a>\r\n");
#nullable restore
#line 85 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n                <div class=\"userInfo\"> \r\n                    <h1>معلومات المستخدم</h1>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf8a6b365b1d4fab969a716946a20db37e4606221860", async() => {
                    WriteLiteral(@"
                        <table>

                                <!--  start head of table -->
                        
                                <tr>
                                                    
                                    <th>الأسم بالكامل</th>
                                    <td>");
#nullable restore
#line 99 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>
                                
                                    
                                </tr>
                                <tr>
                                    <th>البريد الاكتروني</th>
                                    <td>");
#nullable restore
#line 105 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    \r\n                                </tr>\r\n                                <tr>\r\n                                    <th>الرقم القومي</th>\r\n                                    <td>");
#nullable restore
#line 110 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(Model.NationalID);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>
                            
                                </tr>
                                                    
                                                
                            <!--  start head of table -->
                            
                            
                                <tr>     
                                    <th>رقم الهاتف</th>
                                    <td>");
#nullable restore
#line 120 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(Model.mobileNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>                                \r\n                                </tr>\r\n                                <tr>     \r\n                                    <th>العمر</th>\r\n                                    <td>");
#nullable restore
#line 124 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(Model.age);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>                                \r\n                                </tr>\r\n");
#nullable restore
#line 126 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                 if (Model.Specialization == null)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <tr>     \r\n                                    <th>التخصص</th>\r\n                                    <td>ليس له تخصص</td>                                \r\n                                    </tr>\r\n");
#nullable restore
#line 132 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("<tr>     \r\n                                    <th>التخصص</th>\r\n                                    <td>50</td>                                \r\n                                </tr>");
#nullable restore
#line 137 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                     }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                \r\n                                <tr>     \r\n                                    <th>وظيفتك في الموقع</th>\r\n                                    <td>");
#nullable restore
#line 141 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(string.Join(",", Model.Roles));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>                                \r\n                                </tr>\r\n                                <tr>     \r\n                                    <th>النوع</th>\r\n                                    <td>");
#nullable restore
#line 145 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Admin\UserInfo.cshtml"
                                   Write(Model.gender);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>                                \r\n                                </tr>\r\n                              \r\n                            \r\n                            \r\n                        </table>\r\n                    ");
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
                WriteLiteral(@"
                    
                </div>
            </div>
        </div>
      <!-- JS codes -->
      <script type=""module"" src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js""></script>
      <script nomodule src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js""></script>
      <script src=""../HOME PAGE/script.js""></script>
");
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
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
