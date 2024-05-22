using FinalEx.Context;
using FinalEx.Models;
using FinalEx.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FinalEx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string searchText, int? categoryId, string authorName, DateTime? postedDateFrom, DateTime? postedDateTo)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var posts = _context.Post.Include(p => p.Category).Include(p => p.User).AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                posts = posts.Where(p => p.Title.Contains(searchText) || p.Content.Contains(searchText));
            }

            if (categoryId.HasValue)
            {
                posts = posts.Where(p => p.CategoryId == categoryId.Value);
            }

            if (!string.IsNullOrEmpty(authorName))
            {
                posts = posts.Where(p => p.User.Name.Contains(authorName));
            }

            if (postedDateFrom.HasValue)
            {
                posts = posts.Where(p => p.PostedDate >= postedDateFrom.Value);
            }

            if (postedDateTo.HasValue)
            {
                posts = posts.Where(p => p.PostedDate <= postedDateTo.Value);
            }
            var latestSchedules = _context.Schedules.OrderByDescending(s => s.StartDate).ToList();
            ViewBag.Schedules = latestSchedules;
            return View(posts.OrderByDescending(p => p.PostedDate).ToList());
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
