#pragma checksum "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d72e3e09700bfd8c27295464e7394faeac9bd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Judge_Index), @"mvc.1.0.view", @"/Views/Judge/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d72e3e09700bfd8c27295464e7394faeac9bd9", @"/Views/Judge/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabdc8f4a964fa46aa2463da304166ba894228d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Judge_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CompReg>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"" style=""margin-top: 9%;
    margin-bottom: 13%;"">
            <table class=""table align-middle mb-0 bg-white"" >
                <thead class=""bg-light"">
                  <tr>
                    <th>الاسم</th>
                    <th>رقم المشروع</th>
                    <th>التخصص</th>
                    <th></th>
                  </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 14 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
                 foreach(var item in Model){
                if (item.IsAccepted == true&&item.IsprojecSent==true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <div class=\"d-flex align-items-center\">\r\n                                <div class=\"ms-3\">\r\n                                    <p class=\"fw-bold mb-1\">");
#nullable restore
#line 21 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
                                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"text-muted mb-0\">");
#nullable restore
#line 22 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
                                                          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 27 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
                       Write(item.ProjectNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 29 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
                       Write(item.project_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"view\"");
            BeginWriteAttribute("href", " href=\"", 1267, "\"", 1298, 2);
            WriteAttributeValue("", 1274, "/Judge/CompInfo/", 1274, 16, true);
#nullable restore
#line 31 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
WriteAttributeValue("", 1290, item.Id, 1290, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                عرض\r\n                            </a>\r\n                            <a class=\"correct\"");
            BeginWriteAttribute("href", " href=\"", 1419, "\"", 1450, 2);
            WriteAttributeValue("", 1426, "/Judge/compRate/", 1426, 16, true);
#nullable restore
#line 34 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
WriteAttributeValue("", 1442, item.Id, 1442, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                تقييم\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 39 "E:\Repos\Intsar_Project\Intsar_F_Project\Views\Judge\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n              </table>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CompReg>> Html { get; private set; }
    }
}
#pragma warning restore 1591
