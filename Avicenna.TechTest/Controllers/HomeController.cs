using System.Diagnostics;
using System.Threading.Tasks;
using Avicenna.TechTest.Models;
using Avicenna.TechTest.Services;
using Microsoft.AspNetCore.Mvc;
namespace Avicenna.TechTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAvicennaApiClient _apiClient;

        public HomeController(IAvicennaApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public  async Task<IActionResult> Index()
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
