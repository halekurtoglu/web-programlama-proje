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
    public class GirisController : Controller
    {
        private SignInManager<Kullanici> girisYoneticisi;
        private UserManager<Kullanici> kullaniciYoneticisi;

        public GirisController(UserManager<Kullanici> _kullaniciYoneticisi, SignInManager<Kullanici> _girisYoneticisi)
        {
            girisYoneticisi = _girisYoneticisi;
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public IActionResult Index(string _url = null)
        {
            return View(new Giris()
            {
                Url = _url
            });
        }

        [HttpPost]
        public async Task<IActionResult> Index(Giris model)
        {
            if (ModelState.IsValid)
            {
                var user = await kullaniciYoneticisi.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Bu E-Mail Adresine Ait Bir Hesap Bulunamadı.");
                }
                else
                {
                    var result = await girisYoneticisi.PasswordSignInAsync(user, model.Sifre, false, false);
                    if (result.Succeeded)
                    {
                        model.KullaniciID = user.Id;
                        model.Email = user.Email;
                        model.Sifre = user.PasswordHash;
                        model.KullaniciAdi = user.UserName;
                        return Redirect(model.Url ?? "~/");
                    }
                    ModelState.AddModelError("", "E-Mail Adresi ya da Şifre Yanlış");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Cikis()
        {
            await girisYoneticisi.SignOutAsync();
            return Redirect("~/");
        }
    }
}