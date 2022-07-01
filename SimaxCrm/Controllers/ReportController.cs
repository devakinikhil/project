using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SimaxBilling.Model.Enum;
using SimaxCrm.Service.Interface;

namespace SimaxCrm.Controllers
{
    public class ReportController : BaseController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IReportService _reportService;

        public ReportController(
            IWebHostEnvironment webHostEnvironment,
            IReportService reportService)
        {
            _webHostEnvironment = webHostEnvironment;
            _reportService = reportService;
        }

        [HttpGet]
        public JsonResult InvoicePreview(int id, ReportFormType reportFormType, ReportType reportType)
        {
            var result = _reportService.GetBillInvoice(id, _webHostEnvironment.ContentRootPath, reportFormType, ReportType.pdf);
            return Json(result);
        }

        [HttpGet]
        public FileResult InvoiceDownload(int id, ReportFormType reportFormType, ReportType reportType)
        {
            var result = _reportService.GetBillInvoiceBytes(id, _webHostEnvironment.ContentRootPath, reportFormType, reportType);
            var content = new System.IO.MemoryStream(result);
            var contentType = "APPLICATION/octet-stream";
            var fileName = reportFormType.ToString() + "." + reportType;
            return File(content, contentType, fileName);
        }
    }
}

