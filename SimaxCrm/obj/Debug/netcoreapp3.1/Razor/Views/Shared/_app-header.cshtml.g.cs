#pragma checksum "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Shared\_app-header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c14a5dffd3462ae4569201987a51be90c7df83fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__app_header), @"mvc.1.0.view", @"/Views/Shared/_app-header.cshtml")]
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
#line 1 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\_ViewImports.cshtml"
using SimaxCrm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\_ViewImports.cshtml"
using SimaxCrm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\_ViewImports.cshtml"
using SimaxCrm.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Shared\_app-header.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c14a5dffd3462ae4569201987a51be90c7df83fc", @"/Views/Shared/_app-header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b49d50d74b27d36a2985393133d12806911bf2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__app_header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_app-header-nav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_user-nav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<header class=""app-header navbar"">
    <button class=""navbar-toggler sidebar-toggler d-lg-none mr-auto"" type=""button"" data-toggle=""sidebar-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <a class=""navbar-brand"" href=""/Dashboard"">
        InsightCrm
    </a>
    <button class=""navbar-toggler sidebar-toggler d-md-down-none"" type=""button"" data-toggle=""sidebar-lg-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <!-- APP-HEADER-NAV -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c14a5dffd3462ae4569201987a51be90c7df83fc4925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <!-- /APP-HEADER-NAV -->\r\n\r\n");
#nullable restore
#line 21 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Shared\_app-header.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"nav navbar-nav ml-auto\">\r\n");
            WriteLiteral("\r\n            <!-- USER-NAV -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c14a5dffd3462ae4569201987a51be90c7df83fc6508", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <!-- /USER-NAV -->\r\n\r\n        </ul>\r\n");
#nullable restore
#line 52 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Shared\_app-header.cshtml"
                       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</header>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<SimaxCrm.Model.Entity.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<SimaxCrm.Model.Entity.ApplicationUser> SignInManager { get; private set; }
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
