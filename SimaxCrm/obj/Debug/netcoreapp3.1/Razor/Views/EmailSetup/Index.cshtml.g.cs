#pragma checksum "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "023c90933348387a2b9046029774108247fc81db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailSetup_Index), @"mvc.1.0.view", @"/Views/EmailSetup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023c90933348387a2b9046029774108247fc81db", @"/Views/EmailSetup/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b49d50d74b27d36a2985393133d12806911bf2f", @"/Views/_ViewImports.cshtml")]
    public class Views_EmailSetup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimaxCrm.Model.Entity.EmailSetup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "023c90933348387a2b9046029774108247fc81db5775", async() => {
                WriteLiteral("Create New Email Setup");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <i class=""fa fa-align-justify""></i> Email Setup List
            </div>
            <div class=""card-body"">
                <table class=""table table-responsive-sm"">
                    <thead>
                        <tr>
                            <th>");
#nullable restore
#line 21 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <th>");
#nullable restore
#line 23 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.SmtpServer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <th>");
#nullable restore
#line 25 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.SmtpPort));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <th>");
#nullable restore
#line 27 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.UseSsl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <th>");
#nullable restore
#line 29 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <th>");
#nullable restore
#line 31 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SmtpServer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SmtpPort));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UseSsl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 58 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "023c90933348387a2b9046029774108247fc81db12465", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2073, "\"", 2089, 1);
#nullable restore
#line 63 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
WriteAttributeValue("", 2081, item.Id, 2081, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <button type=""submit"" onclick=""return confirm('Do you want to delete this record')"" class=""btn btn-danger btn-sm"">
                                        Delete
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "023c90933348387a2b9046029774108247fc81db14804", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\EmailSetup\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimaxCrm.Model.Entity.EmailSetup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
