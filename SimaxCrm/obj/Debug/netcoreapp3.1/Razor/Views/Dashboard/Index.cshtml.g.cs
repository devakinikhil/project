#pragma checksum "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a27c8399eaac2681c4856260a5543868691951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a27c8399eaac2681c4856260a5543868691951", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b49d50d74b27d36a2985393133d12806911bf2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dashboard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- DASHBOARD-BOXES-->\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
     if (!User.IsInRole(SimaxCrm.Model.Enum.UserType.Account.ToString()))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 col-sm-6 col-lg-2 clickable\" onclick=\"openLeadPage(\'NewLead\')\">\r\n            <div class=\"card text-white bg-primary\">\r\n                <div class=\"card-body pb-0\">\r\n                    <div class=\"text-value\">");
#nullable restore
#line 16 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.NewLead);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>New Leads</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('FollowUp')"">
            <div class=""card text-white bg-brown"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 26 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.FollowUp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>Today Follow Up</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('MissedFollowUp')"">
            <div class=""card text-white bg-warning"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 36 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.MissedFollowUp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>Missed Follow Up</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('Converted')"">
            <div class=""card text-white bg-success"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 46 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.Converted);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>Converted</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('Postpone')"">
            <div class=""card text-white bg-color1"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 56 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.Postpone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>Postpone</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('Reopen')"">
            <div class=""card text-black-50 bg-color2"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 66 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.Reopen);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>Reopen</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('Closed')"">
            <div class=""card text-white bg-warning"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 76 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.Closed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <div>Closed</div>
                </div>
                <br />
            </div>
        </div>
        <!--/.col-->
        <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openLeadPage('AllLead')"">
            <div class=""card text-white bg-brown"">
                <div class=""card-body pb-0"">
                    <div class=""text-value"">");
#nullable restore
#line 86 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                       Write(Model.AllLead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>All Leads</div>\r\n                </div>\r\n                <br />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 92 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--/.col-->\r\n    <div class=\"col-md-3 col-sm-6 col-lg-2 clickable\" onclick=\"openInvoicePage(\'Pending\')\">\r\n        <div class=\"card text-white bg-primary\">\r\n            <div class=\"card-body pb-0\">\r\n                <div class=\"text-value\">");
#nullable restore
#line 97 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                   Write(Model.InvoicePending);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                <div>Invoice Pending</div>
            </div>
            <br />
        </div>
    </div>
    <!--/.col-->
    <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openInvoicePage('Approved')"">
        <div class=""card text-white bg-success"">
            <div class=""card-body pb-0"">
                <div class=""text-value"">");
#nullable restore
#line 107 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                   Write(Model.InvoiceApproved);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                <div>Invoice Approved</div>
            </div>
            <br />
        </div>
    </div>
    <!--/.col-->
    <div class=""col-md-3 col-sm-6 col-lg-2 clickable"" onclick=""openInvoicePage('Rejected')"">
        <div class=""card text-white bg-danger"">
            <div class=""card-body pb-0"">
                <div class=""text-value"">");
#nullable restore
#line 117 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                                   Write(Model.InvoiceRejected);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>Invoice Rejected</div>\r\n            </div>\r\n            <br />\r\n        </div>\r\n    </div>\r\n    <!--/.col-->\r\n</div>\r\n<!-- /DASHBOARD-BOXES-->\r\n<!-- DASHBOARD-CHART AREA-->\r\n");
#nullable restore
#line 127 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
 if (!User.IsInRole(SimaxCrm.Model.Enum.UserType.Account.ToString()))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card-columns cols-2"">

        <div class=""card"">
            <div class=""card-header"">
                Last 6 Month Sales
            </div>
            <div class=""card-body"">
                <div class=""chart-wrapper"">
                    <canvas id=""canvas-1""></canvas>
                </div>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                Last 30 Days Leads
            </div>
            <div class=""card-body"">
                <div class=""chart-wrapper"">
                    <canvas id=""canvas-5""></canvas>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 153 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /DASHBOARD-CHART AREA-->\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a27c8399eaac2681c4856260a554386869195114945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a27c8399eaac2681c4856260a554386869195116045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteAttributeValue("", 5635, "~/lib/", 5635, 6, true);
                WriteLiteral("@");
                WriteAttributeValue("", 5643, "coreui/coreui-plugin-chartjs-custom-tooltips/dist/js/custom-tooltips.min.js", 5643, 75, true);
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a27c8399eaac2681c4856260a554386869195117631", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n    var canvas_label_1=");
#nullable restore
#line 163 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                  Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.SalesChart?.Label)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    var canvas_data_1=");
#nullable restore
#line 164 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                 Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.SalesChart?.Data)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    var canvas_label_2=");
#nullable restore
#line 165 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                  Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.LeadsChart?.Label)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    var canvas_data_2=");
#nullable restore
#line 166 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Dashboard\Index.cshtml"
                 Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.LeadsChart?.Data)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a27c8399eaac2681c4856260a554386869195120314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
