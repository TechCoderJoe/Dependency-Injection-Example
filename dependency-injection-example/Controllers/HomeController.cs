using dependency_injection_example.Models;
using dependency_injection_example.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dependency_injection_example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGuidSingleton _guidSingleton;
        private readonly IGuidScoped _guidScoped1;
        private readonly IGuidScoped _guidScoped2;
        private readonly IGuidTransient _guidTransient1;
        private readonly IGuidTransient _guidTransient2;

        public HomeController(ILogger<HomeController> logger, IGuidSingleton guidSingleton, IGuidScoped guidScoped1, IGuidScoped guidScoped2, IGuidTransient guidTransient1, IGuidTransient guidTransient2)
        {
            _logger = logger;
            _guidSingleton = guidSingleton;
            _guidScoped1 = guidScoped1;
            _guidScoped2 = guidScoped2;
            _guidTransient1 = guidTransient1;
            _guidTransient2 = guidTransient2;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetGuidPartialView()
        {
            guidServicesModel model = new guidServicesModel
            {
                guidSingleton = _guidSingleton.Value(),
                guidScoped1 = _guidScoped1.Value(),
                guidScoped2 = _guidScoped2.Value(),
                guidTransient1 = _guidTransient1.Value(),
                guidTransient2 = _guidTransient2.Value()
            };

            return PartialView(model);
        }
    }
}
