#pragma checksum "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c32d2d146df56333b3fa7415793a3cf7331c1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c32d2d146df56333b3fa7415793a3cf7331c1a1", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b49d50d74b27d36a2985393133d12806911bf2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimaxCrm.Model.Entity.Invoice>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <i class=""fa fa-align-justify""></i> Invoices
            </div>
            <div class=""card-body"">
                <table class=""table table-responsive-sm"">
                    <thead>
                        <tr>
                            <th>");
#nullable restore
#line 18 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 19 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 20 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 21 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 22 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.OtherCharges));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 23 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.TaxAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 24 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 25 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(item.CreatedDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OtherCharges));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TaxAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 44 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                 if (User.IsInRole(SimaxCrm.Model.Enum.UserType.Account.ToString()))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c32d2d146df56333b3fa7415793a3cf7331c1a112746", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leadId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                                                 WriteLiteral(item.LeadId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leadId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leadId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leadId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                     if (item.OrderStatus == SimaxCrm.Model.Enum.OrderStatusType.Pending)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c32d2d146df56333b3fa7415793a3cf7331c1a116683", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2880, "\"", 2896, 1);
#nullable restore
#line 53 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 2888, item.Id, 2888, 8, false);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                     if (item.OrderStatus == SimaxCrm.Model.Enum.OrderStatusType.Pending ||
                             item.OrderStatus == SimaxCrm.Model.Enum.OrderStatusType.Rejected)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c32d2d146df56333b3fa7415793a3cf7331c1a119815", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leadId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                                                     WriteLiteral(item.LeadId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leadId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leadId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leadId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </td>
                            <td>
                                <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    Invoice
                                </button>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 4223, "\"", 4336, 5);
            WriteAttributeValue("", 4230, "javascript:report.reportAction(", 4230, 31, true);
#nullable restore
#line 71 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 4261, item.Id, 4261, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4269, ",", 4269, 1, true);
            WriteAttributeValue(" ", 4270, "report.reportFormTypeEnum.Invoice,", 4271, 35, true);
            WriteAttributeValue(" ", 4305, "report.reportTypeEnum.Preview)", 4306, 31, true);
            EndWriteAttribute();
            WriteLiteral(">Preview</a>\r\n                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 4411, "\"", 4520, 5);
            WriteAttributeValue("", 4418, "javascript:report.reportAction(", 4418, 31, true);
#nullable restore
#line 72 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 4449, item.Id, 4449, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4457, ",", 4457, 1, true);
            WriteAttributeValue(" ", 4458, "report.reportFormTypeEnum.Invoice,", 4459, 35, true);
            WriteAttributeValue(" ", 4493, "report.reportTypeEnum.doc)", 4494, 27, true);
            EndWriteAttribute();
            WriteLiteral(">Download Word</a>\r\n                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 4601, "\"", 4710, 5);
            WriteAttributeValue("", 4608, "javascript:report.reportAction(", 4608, 31, true);
#nullable restore
#line 73 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 4639, item.Id, 4639, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4647, ",", 4647, 1, true);
            WriteAttributeValue(" ", 4648, "report.reportFormTypeEnum.Invoice,", 4649, 35, true);
            WriteAttributeValue(" ", 4683, "report.reportTypeEnum.pdf)", 4684, 27, true);
            EndWriteAttribute();
            WriteLiteral(">Download Pdf</a>\r\n                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 4790, "\"", 4899, 5);
            WriteAttributeValue("", 4797, "javascript:report.reportAction(", 4797, 31, true);
#nullable restore
#line 74 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 4828, item.Id, 4828, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4836, ",", 4836, 1, true);
            WriteAttributeValue(" ", 4837, "report.reportFormTypeEnum.Invoice,", 4838, 35, true);
            WriteAttributeValue(" ", 4872, "report.reportTypeEnum.xls)", 4873, 27, true);
            EndWriteAttribute();
            WriteLiteral(">Download Excel</a>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\NIKHIL DEVAKI\Downloads\codecanyon-31454045-simax-crm-multipurpose-crm-in-dot-net-core (1)\SimaxCrm\Views\Invoice\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimaxCrm.Model.Entity.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
