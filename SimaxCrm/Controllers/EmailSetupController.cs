using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System;

namespace SimaxCrm.Controllers
{
    [Authorize]
    public class EmailSetupController : Controller
    {
        private readonly IEmailSetupService _emailSetupService;
        private readonly IHelperService _emailService;

        public EmailSetupController(IEmailSetupService emailSetupService,
            IHelperService emailService)
        {
            _emailSetupService = emailSetupService;
            _emailService = emailService;
        }

        // GET: ServiceType
        public IActionResult Index()
        {
            return View(_emailSetupService.List());
        }

        // GET: ServiceType/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmailSetup obj)
        {
            if (ModelState.IsValid)
            {
                var result = true;// _emailService.TestEmail("ng.simar@gmail.com", obj, out string errorMsg);
                if (result)
                {
                    //obj.Status = true;
                    obj.CreatedDate = DateTime.Now;
                    _emailSetupService.Create(obj);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //ModelState.AddModelError("SmtpServer", errorMsg);
                }
            }
            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            var obj = _emailSetupService.ById(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EmailSetup obj)
        {
            if (id != obj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //obj.Status = true;
                obj.UpdatedDate = DateTime.Now;
                _emailSetupService.Update(obj);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        // GET: ServiceType/Delete/5
        public IActionResult Delete(int id)
        {
            var obj = _emailSetupService.ById(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: ServiceType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _emailSetupService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
