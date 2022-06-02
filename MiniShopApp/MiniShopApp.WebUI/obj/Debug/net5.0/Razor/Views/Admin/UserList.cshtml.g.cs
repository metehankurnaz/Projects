#pragma checksum "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e1933fa4dcfd519da8d4c9c7d2b8597ed6e7c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
#line 3 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e1933fa4dcfd519da8d4c9c7d2b8597ed6e7c3", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3c89894a03aab7438ac4839f07264083b7b45d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/user/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#userList\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <h6 class=""display-4"">User List</h6>
        <hr />
        <a href=""/admin/user/create"" class=""btn btn-sm btn-primary"">Create User</a>
        <hr />
        <table data-page-length=""2"" class=""table table-sm table-bordered table-hover"" id=""userList"">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>User Name</th>
                    <th>Email</th>
                    <th>Email Confirmed</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                 if (Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 1206, "\"", 1256, 1);
#nullable restore
#line 35 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1214, user.EmailConfirmed ? "" : "bg-warning", 1214, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1597, "\"", 1624, 2);
            WriteAttributeValue("", 1604, "/admin/user/", 1604, 12, true);
#nullable restore
#line 42 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1616, user.Id, 1616, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary mr-2\">Edit</a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e1933fa4dcfd519da8d4c9c7d2b8597ed6e7c39727", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1841, "\"", 1857, 1);
#nullable restore
#line 44 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1849, user.Id, 1849, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <td colspan=""6"">
                            <div class=""alert alert-warning"">
                                <h4>Herhangi bir kullanıcı bulunamadı!</h4>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 60 "C:\Users\Wissen\Documents\GitHub\Web07_Project\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\UserList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
