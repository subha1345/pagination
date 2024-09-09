using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbContext = new AdminContext();
            var products = dbContext.TblProducts.ToList();
            return Ok(products);
        }
    }
}
