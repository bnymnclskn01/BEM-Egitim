#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\BEM-Egitim\ECommerce\ECommerce.WebUI\Views\Shared\_partialNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b9621c42f4cb230900189d427cfda4814c9d3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partialNavBar), @"mvc.1.0.view", @"/Views/Shared/_partialNavBar.cshtml")]
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
#line 1 "C:\Users\ever_\OneDrive\Belgeler\GitHub\BEM-Egitim\ECommerce\ECommerce.WebUI\Views\_ViewImports.cshtml"
using ECommerce.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\BEM-Egitim\ECommerce\ECommerce.WebUI\Views\_ViewImports.cshtml"
using ECommerce.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b9621c42f4cb230900189d427cfda4814c9d3bd", @"/Views/Shared/_partialNavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c60dd99a25816b7d148405cbe6021af4ccba8b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__partialNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"            <!-- Topbar Start -->
<div class=""navbar-custom"">
    <ul class=""list-unstyled topnav-menu float-end mb-0"">

        <li class=""dropdown notification-list topbar-dropdown"">
            <a class=""nav-link dropdown-toggle nav-user me-0 waves-effect waves-light"" data-bs-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
                <img src=""/assets/images/users/user-1.jpg"" alt=""user-image"" class=""rounded-circle"">
                <span class=""pro-user-name ms-1"">
                    Nowak <i class=""mdi mdi-chevron-down""></i>
                </span>
            </a>
            <div class=""dropdown-menu dropdown-menu-end profile-dropdown "">
                <!-- item-->
                <div class=""dropdown-header noti-title"">
                    <h6 class=""text-overflow m-0"">Welcome !</h6>
                </div>

                <!-- item-->
                <a href=""contacts-profile.html"" class=""dropdown-item notify-item"">
                    <i");
            WriteLiteral(@" class=""fe-user""></i>
                    <span>My Account</span>
                </a>

                <!-- item-->
                <a href=""auth-lock-screen.html"" class=""dropdown-item notify-item"">
                    <i class=""fe-lock""></i>
                    <span>Lock Screen</span>
                </a>

                <div class=""dropdown-divider""></div>

                <!-- item-->
                <a href=""auth-logout.html"" class=""dropdown-item notify-item"">
                    <i class=""fe-log-out""></i>
                    <span>Logout</span>
                </a>

            </div>
        </li>

        <li class=""dropdown notification-list"">
            <a href=""javascript:void(0);"" class=""nav-link right-bar-toggle waves-effect waves-light"">
                <i class=""fe-settings noti-icon""></i>
            </a>
        </li>

    </ul>

    <!-- LOGO -->
    <div class=""logo-box"">
        <a href=""index.html"" class=""logo logo-light text-center"">
            <span c");
            WriteLiteral("lass=\"logo-sm\">\r\n                <img src=\"/assets/images/logo-sm.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2118, "\"", 2124, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"22\">\r\n            </span>\r\n            <span class=\"logo-lg\">\r\n                <img src=\"/assets/images/logo-light.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2253, "\"", 2259, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"16\">\r\n            </span>\r\n        </a>\r\n        <a href=\"index.html\" class=\"logo logo-dark text-center\">\r\n            <span class=\"logo-sm\">\r\n                <img src=\"/assets/images/logo-sm.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2465, "\"", 2471, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"22\">\r\n            </span>\r\n            <span class=\"logo-lg\">\r\n                <img src=\"/assets/images/logo-dark.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2599, "\"", 2605, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""16"">
            </span>
        </a>
    </div>

    <ul class=""list-unstyled topnav-menu topnav-menu-left mb-0"">
        <li>
            <button class=""button-menu-mobile disable-btn waves-effect"">
                <i class=""fe-menu""></i>
            </button>
        </li>

        <li>
            <h4 class=""page-title-main"">Dashboard</h4>
        </li>

    </ul>

    <div class=""clearfix""></div>

</div>
<!-- end Topbar -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591