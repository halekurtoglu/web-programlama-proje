using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Microsoft.AspNetCore.Identity;
using Project.Identity;

namespace Project.Controllers
{
    public class YeniController : Controller
    {
        private Context context;

        private UserManager<Kullanici> kullaniciYoneticisi;
        public YeniController(UserManager<Kullanici> _kullaniciYoneticisi, Context context)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
            this.context = context;
        }
        public IActionResult Index()
        {
            var filmler = context.Film.Where(t => t.filmGosterilsinmi == false).ToList();
            filmler = filmler.OrderByDescending(x => x.PiyasayaSurulmeTarihi).ToList();
            filmler = filmler.Take(10).ToList();

            return View(new FilmListViewModel()
            {
                Filmler = filmler

            });
        }
        public IActionResult Detail(int id)
        {
            Film film = context.Film.Include(i => i.FilmKategorileri).ThenInclude(i => i.Kategori).FirstOrDefault(i => i.FilmID == id);
            var yorumlar = context.Yorum.Include(i => i.Film).Where(i => i.FilmID == id).ToList();
            var favorilerdemi = context.Favori.Any(i => i.Film.FilmID == id && i.KullaniciAdi == User.Identity.Name);
            film.GoruntulenmeSayisi++;
            context.Film.Update(film);
            context.SaveChanges();
            return View(new FilmDetailViewModel()
            {
                Film = film,
                Yorumlar = yorumlar,
                favorilerdemi = favorilerdemi
            });
        }

        [HttpPost]
        public IActionResult CreateComment(YorumModel model)
        {
            var user = kullaniciYoneticisi.FindByNameAsync(User.Identity.Name).Result;
            var Yorum = new Yorum()
            {
                OlusturulmaTarihi = DateTime.Now,
                KullaniciAdi = user.UserName,
                FilmID = model.FilmID,
                YapilanYorum = model.YapilanYorum
            };
            context.Yorum.Add(Yorum);
            context.SaveChanges();
            return Redirect("/Yeni/Detail/" + model.FilmID);
        }
    }
}