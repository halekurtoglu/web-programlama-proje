using Project.Data;
using Project.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private Context context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult CultureManagement(string Culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {
            var haberler = context.Haber.ToList();
            haberler = haberler.Where(t => t.haberGosterilsinmi == false).ToList();
            haberler.Reverse();

            var filmler1 = context.Film.ToList();
            filmler1 = filmler1.Where(t => t.filmGosterilsinmi == false).OrderByDescending(x => x.PiyasayaSurulmeTarihi).ToList();
            filmler1 = filmler1.Take(5).ToList();

            var filmler2 = context.Film.ToList();
            filmler2 = filmler2.Where(t => t.filmGosterilsinmi == false).OrderByDescending(x => x.GoruntulenmeSayisi).ToList();
            filmler2 = filmler2.Take(5).ToList();

            return View(new HaberListViewModel()
            {
                Haberler = haberler,
                Filmler1 = filmler1,
                Filmler2 = filmler2
            });
        }
        public IActionResult Detail(int id)
        {
            var haber = context.Haber.FirstOrDefault(i => i.HaberID == id);
            return View(haber);
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