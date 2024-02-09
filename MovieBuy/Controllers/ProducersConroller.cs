using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieBuy.Data;

namespace MovieBuy.Controllers
{
    public class ProducersConroller : Controller
    {
        private readonly AppDbContext _context;

        public ProducersConroller(AppDbContext context)
        {
            _context = context;
        }

        /*public IActionResult Index()
        {
            var allProducers = _context.Producers.ToList();
            return View();
        }*/

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
