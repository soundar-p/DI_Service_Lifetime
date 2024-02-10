using DI_Service_Lifetime.Models;
using DI_Service_Lifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DI_Service_Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISingletonInterface _singleton1;
        private readonly ISingletonInterface _singleton2;
        private readonly ITransientInterface _transient1;
        private readonly ITransientInterface _transient2;
        private readonly IScopedInterface _scoped1;
        private readonly IScopedInterface _scoped2;

        public HomeController(ILogger<HomeController> logger,
            ISingletonInterface singleton1, IScopedInterface scoped1, ITransientInterface transient1,
            ISingletonInterface singleton2, IScopedInterface scoped2, ITransientInterface transient2)
        {
            _logger = logger;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            _transient1 = transient1;
            _transient2 = transient2;

        }

        public IActionResult Index()
        {
            StringBuilder messages = new StringBuilder();
            messages.Append($"Transient1: {_transient1.GetGuid()}\n");
            messages.Append($"Transient2: {_transient2.GetGuid()}\n\n");

            messages.Append($"Scoped1: {_scoped1.GetGuid()}\n");
            messages.Append($"Scoped2: {_scoped2.GetGuid()}\n\n");

            messages.Append($"Singleton1: {_singleton1.GetGuid()}\n");
            messages.Append($"Singleton2: {_singleton2.GetGuid()}\n\n");

            return Ok(messages.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
