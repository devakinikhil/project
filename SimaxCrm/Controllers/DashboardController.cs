using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Model.ResponseModel;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        private readonly ILeadService _leadService;
        private readonly IInvoiceService _invoiceService;

        public DashboardController(
            ILeadService leadService,
            IInvoiceService invoiceService
            )
        {
            _leadService = leadService;
            _invoiceService = invoiceService;
        }


        public IActionResult Index()
        {
            var uid = (Guid)base.getUidFromClaim();
            base.getTidFromClaim();
            List<Lead> leads = null;

            var dashboardBoxesModel = new DashboardBoxesModel();

            if (User.IsInRole(UserType.Account.ToString()))
            {
                var invoices = _invoiceService.List();

                dashboardBoxesModel = new DashboardBoxesModel()
                {
                    InvoicePending = invoices.Count(m => m.OrderStatus == OrderStatusType.Pending),
                    InvoiceApproved = invoices.Count(m => m.OrderStatus == OrderStatusType.Approved),
                    InvoiceRejected = invoices.Count(m => m.OrderStatus == OrderStatusType.Rejected),
                };
            }
            else
            {
                if (User.IsInRole(UserType.Agent.ToString()))
                {
                    leads = _leadService.ByUserId(uid, null, null);
                }
                else
                {
                    leads = _leadService.AllLeads();
                }

                var leadIds = leads.Select(m => m.Id).ToList();

                var invoices = _invoiceService.ByLeadIds(leadIds);

                var salesChartData = getSalesChartData(invoices, 6);
                var leadsChartData = getLeadsChartData(leads);

                dashboardBoxesModel = new DashboardBoxesModel()
                {
                    NewLead = leads.Count(m => m.LeadStatus == LeadStatusType.NewLead.ToString()),
                    Postpone = leads.Count(m => m.LeadStatus == LeadStatusType.Postpone.ToString()),
                    Converted = leads.Count(m => m.LeadStatus == LeadStatusType.Converted.ToString()),
                    FollowUp = leads.Count(m => m.LeadStatus == LeadStatusType.FollowUp.ToString() && m.AlertDate.Value.Date != null && m.AlertDate.Value == DateTime.Now.Date),
                    MissedFollowUp = leads.Count(m => m.LeadStatus == LeadStatusType.FollowUp.ToString() && m.AlertDate.Value.Date != null && m.AlertDate.Value < DateTime.Now.Date),
                    Closed = leads.Count(m => m.LeadStatus == LeadStatusType.Closed.ToString()),
                    Reopen = leads.Count(m => m.LeadStatus == LeadStatusType.Reopen.ToString()),
                    AllLead = leads.Count(),
                    InvoicePending = invoices.Count(m => m.OrderStatus == OrderStatusType.Pending),
                    InvoiceApproved = invoices.Count(m => m.OrderStatus == OrderStatusType.Approved),
                    InvoiceRejected = invoices.Count(m => m.OrderStatus == OrderStatusType.Rejected),
                    SalesChart = salesChartData,
                    LeadsChart = leadsChartData
                };
            }

            return View(dashboardBoxesModel);
        }

        private DashboardChartResponseModel getSalesChartData(List<Invoice> invoices, int lastMonths)
        {
            var tempfromDate = DateTime.Now.AddMonths(lastMonths * -1);
            var fromDate = new DateTime(tempfromDate.Year, tempfromDate.Month, 1);
            var toDate = DateTime.Now;
            var lastSixMonths = Enumerable.Range(0, lastMonths)
                              .Select(i => DateTime.Now.AddMonths((i + 1) - lastMonths))
                              .Select(date => date.ToString("MMM"));

            var saleBillData = invoices.Where(m => m.OrderStatus == OrderStatusType.Approved && m.CreatedDate.Date >= fromDate && m.CreatedDate.Date <= toDate).ToList();
            var query = from m in lastSixMonths
                        join s in saleBillData on m equals s.CreatedDate.ToString("MMM") into ss
                        from s in ss.DefaultIfEmpty()
                        group new { m, s } by m into gg
                        select new
                        {
                            Month = gg.Key,
                            Value = gg.Sum(x => x.s?.GrandTotal)
                        };

            var queryData = query.ToList();

            return new DashboardChartResponseModel
            {
                Label = queryData.Select(m => m.Month).ToArray(),
                Data = queryData.Select(m => Convert.ToInt32(m.Value == null ? 0 : m.Value)).ToArray()
            };
        }

        private DashboardChartResponseModel getLeadsChartData(List<Lead> leads)
        {
            var toDate = DateTime.Now.Date;
            var fromDate = DateTime.Now.AddDays(-30).Date;

            var query = from m in leads
                        where m.AssignedDate.Date >= fromDate && m.AssignedDate.Date <= toDate
                        group m by m.LeadStatus into gg
                        select new
                        {
                            LeadStatus = gg.Key,
                            Value = gg.Count()
                        };

            var queryData = query.ToList();

            return new DashboardChartResponseModel
            {
                Label = queryData.Select(m => m.LeadStatus).ToArray(),
                Data = queryData.Select(m => m.Value).ToArray()
            };
        }

    }

}