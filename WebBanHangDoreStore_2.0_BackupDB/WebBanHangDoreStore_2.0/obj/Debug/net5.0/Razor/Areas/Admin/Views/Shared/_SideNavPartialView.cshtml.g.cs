#pragma checksum "D:\AppHocTap\WebBanHangDoreStore_2.0\WebBanHangDoreStore_2.0\Areas\Admin\Views\Shared\_SideNavPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d7b1d2f009be4b6f620cecb92709ee388af263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SideNavPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SideNavPartialView.cshtml")]
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
#line 1 "D:\AppHocTap\WebBanHangDoreStore_2.0\WebBanHangDoreStore_2.0\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangDoreStore_2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AppHocTap\WebBanHangDoreStore_2.0\WebBanHangDoreStore_2.0\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangDoreStore_2._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d7b1d2f009be4b6f620cecb92709ee388af263", @"/Areas/Admin/Views/Shared/_SideNavPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fde76dd4cdc86151375a9e2039f001ac25234d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SideNavPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-toggle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"side-nav\">\r\n    <div class=\"side-nav-inner\">\r\n        <ul class=\"side-nav-menu scrollable\">\r\n            <li class=\"nav-item \">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d7b1d2f009be4b6f620cecb92709ee388af2635020", async() => {
                WriteLiteral(@"
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-dashboard""></i>
                    </span>
                    <span class=""title"">Dashboard</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-appstore""></i>
                    </span>
                    <span class=""title"">Quản lý đơn hàng</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""app-chat.html"">Chat</a>
                    </li>
                    <li>
                        <a href=""app-file-manager.html"">File Manager</a>
                    </li>
                    <li>
                        <a href=""app-mail.html"">Mail</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <sp");
            WriteLiteral(@"an>Projects</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a href=""app-project-list.html"">Project List</a>
                            </li>
                            <li>
                                <a href=""app-project-details.html"">Project Details</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <span>E-commerce</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                   ");
            WriteLiteral(@"         <li>
                                <a href=""app-e-commerce-order-list.html"">Orders List</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products.html"">Products</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products-list.html"">Products List</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products-edit.html"">Products Edit</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-build""></i>
                    </span>
                    <span class=""title"">Quản l");
            WriteLiteral(@"ý sản phẩm</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""avatar.html"">Avatar</a>
                    </li>
                    <li>
                        <a href=""alert.html"">Alert</a>
                    </li>
                    <li>
                        <a href=""badge.html"">Badge</a>
                    </li>
                    <li>
                        <a href=""buttons.html"">Buttons</a>
                    </li>
                    <li>
                        <a href=""cards.html"">Cards</a>
                    </li>
                    <li>
                        <a href=""icons.html"">Icons</a>
                    </li>
                    <li>
                        <a href=""lists.html"">Lists</a>
                    </li>
                    <li>
                     ");
            WriteLiteral(@"   <a href=""typography.html"">Typography</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-hdd""></i>
                    </span>
                    <span class=""title"">Quản lý khách hàng</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""accordion.html"">Accordion</a>
                    </li>
                    <li>
                        <a href=""carousel.html"">Carousel</a>
                    </li>
                    <li>
                        <a href=""dropdown.html"">Dropdown</a>
                    </li>
                    <li>
                        <a ");
            WriteLiteral(@"href=""modals.html"">Modals</a>
                    </li>
                    <li>
                        <a href=""toasts.html"">Toasts</a>
                    </li>
                    <li>
                        <a href=""popover.html"">Popover</a>
                    </li>
                    <li>
                        <a href=""slider-progress.html"">Slider & Progress</a>
                    </li>
                    <li>
                        <a href=""tabs.html"">Tabs</a>
                    </li>
                    <li>
                        <a href=""tooltips.html"">Tooltips</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-form""></i>
                    </span>
                    <span class=""title"">Quản lý doanh số</span>
                    <span c");
            WriteLiteral(@"lass=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""form-elements.html"">Form Elements</a>
                    </li>
                    <li>
                        <a href=""form-layouts.html"">Form Layouts</a>
                    </li>
                    <li>
                        <a href=""form-validation.html"">Form Validation</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-table""></i>
                    </span>
                    <span class=""title"">Quản lý hệ thống</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>");
            WriteLiteral("\n                </a>\r\n                <ul class=\"dropdown-menu\">\r\n                    <li>\r\n                        <a href=\"basic-table.html\">Quản lý danh mục</a>\r\n                    </li>\r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d7b1d2f009be4b6f620cecb92709ee388af26314826", async() => {
                WriteLiteral("Quản lý quyền truy cập");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                    <li>
                        <a href=""data-table.html"">Quản lý tài khoản</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-pie-chart""></i>
                    </span>
                    <span class=""title"">Quản lý tin tức</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""chartist.html"">Chartist</a>
                    </li>
                    <li>
                        <a href=""chartjs.html"">ChartJs</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
");
            WriteLiteral(@"                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-file""></i>
                    </span>
                    <span class=""title"">Quản lý trang</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""profile.html"">Profile</a>
                    </li>
                    <li>
                        <a href=""invoice.html"">Invoice</a>
                    </li>
                    <li>
                        <a href=""members.html"">Members</a>
                    </li>
                    <li>
                        <a href=""pricing.html"">Pricing</a>
                    </li>
                    <li>
                        <a href=""setting.html"">Setting</a>
                    </li");
            WriteLiteral(@">
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <span>Blog</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a href=""blog-grid.html"">Blog Grid</a>
                            </li>
                            <li>
                                <a href=""blog-list.html"">Blog List</a>
                            </li>
                            <li>
                                <a href=""blog-post.html"">Blog Post</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </li>
        </ul>
    </div>
</div>");
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
