using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WomenWorld.Models;

namespace WomenWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonRepository _personRepository;
        private readonly IPersonDetailsRepository _personDetailsRepository;

        public HomeController(IPersonRepository personRepository,IPersonDetailsRepository personDetailsRepository)
        {
            _personRepository = personRepository;
            _personDetailsRepository = personDetailsRepository;

        }

        public ViewResult Index()
        {
            var model = _personRepository.GetAllPersons();
            return View(model);
        }

        public ViewResult Privacy(int id)
        { 
            Persons model = _personDetailsRepository.GetPersonDetails(id);
            return View(model);
        }

      
        public RedirectResult WikipediaLink(int id)
        {
            var link = _personDetailsRepository.Links(id);
            return RedirectPermanent(link);
        }
        public RedirectToActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");
        }

        public FileContentResult DisplayPDF(int id)
        {
            var path = _personDetailsRepository.ContentPath(id);
            var pdfBytes = System.IO.File.ReadAllBytes(path);
            return new FileContentResult(pdfBytes, "application/pdf");
        }
        [Route("Home/JsonForm/{id:int?}")]
        public JsonResult JsonForm(int? id)
        {
            int current_id = id ?? 1;
            var model = _personDetailsRepository.GetPersonDetails(current_id);
            return Json(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
