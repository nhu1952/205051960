using Demo.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Models
{
    public class ListProducts : ViewComponent
    {
        private readonly DemoContext _context;

        public ListProducts(DemoContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }
    }
}
