using Microsoft.AspNetCore.Mvc;

namespace FabricBlocks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Error() => View();
    }
}
