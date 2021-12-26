using Project.Identity;
using Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class ProfilController : Controller
    {
        private UserManager<Kullanici> kullaniciYoneticisi;

        public ProfilController(UserManager<Kullanici> _kullaniciYoneticisi)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public async Task<IActionResult> Index()
        {
            Profil profil = new Profil();
            var user = await kullaniciYoneticisi.FindByNameAsync(User.Identity.Name);
            profil.KullaniciID = user.Id;
            profil.Email = user.Email;
            profil.KullaniciAdi = user.UserName;

            return View(profil);
        }
    }
}
