using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Identity;
using Project.Models;
using Microsoft.AspNetCore.Identity;

namespace DKGamers.Controllers
{
    public class KayitController : Controller
    {
        private UserManager<Kullanici> kullaniciYoneticisi;

        public KayitController(UserManager<Kullanici> _kullaniciYoneticisi)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Kayit model)
        {
            if (ModelState.IsValid)
            {
                Kullanici kullanici = new Kullanici();
                kullanici.UserName = model.KullaniciAdi;
                kullanici.Email = model.Email;

                var result = await kullaniciYoneticisi.CreateAsync(kullanici, model.Sifre);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
