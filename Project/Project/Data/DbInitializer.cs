using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data
{
    public static class DbInitializer
    {
        //Veritabanı yüklenmeden önce ekrana gelecek veriler burada bulunmakta.
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Haber>().HasData(
                new Haber()
                {
                    HaberID = 1,
                    HaberBaslik = "Örümcek Adam eve geri dönüş yok filmi vizyona girdi!",
                    HaberResim = "orumcekAdam.jpg",
                    HaberIcerik = "Örümcek-Adam: Eve Dönüş Yok Columbia Pictures ve Marvel Studios tarafından ortaklaşa üretilen ve Sony Pictures tarafından dağıtılan, Marvel Comics karakteri Örümcek Adam çizgi romanlarından uyarlanan ABD süper kahraman filmidir.",

                }
                );
            builder.Entity<Film>().HasData(
                new Film()
                {
                    FilmID = 1,
                    Resim = "orumcekAdam.jpg",
                    FilmAdi = "Örümcek Adam",
                    PiyasayaSurulmeTarihi = new DateTime(2021,12 , 17),
                    Yayinci = "Marvel Studios",
                    Gelistirici = "Marvel Studios",
                    Aciklama = "Örümcek-Adam Eve Dönüş Yok, kimliği açığa Örümcek-Adam'ın, sırrını geri vermesi için Doktor Strange'den yardım istemesiyle birlikte yaşananları konu ediyor. Örümcek-Adam'ın kimliği ifşa edilerek onun ve sevdiklerinin hayatı, halkın gözü önüne serilir. Kendisini büyük bir kaosun ortasında bulan Peter, aynı zamanda suç ortakları olarak lanse edilen MJ ve Ned'in hayatının da olumsuz etkilenmesine şahit olur. Arkadaşların üniversiteye girme şanslarının yok olmasına seyirci kalmak istemeyen Peter, sırrını geri vermesi için Doktor Strange'den yardım ister. Peter'ın yakarışından etkilenip ona yardım etmeyi kabul eden Strange, Unutma Büyüsü'nü yapmaya başlar. Ancak bu büyü, MJ, Ned, May ve Happy'nin de Örümcek-Adam'ın kim olduğunu unutmasına neden olacaktır. Arkadaşlarının kim olduğunu hatırlamasını, diğer kişilerin unutmasını isteyen Peter, Strange büyüyü yaparken parametreleri değiştirir. Ancak bu durum beklenmedik olaylara neden olur.",
                    GoruntulenmeSayisi = 100
                }
                );
            builder.Entity<Kategori>().HasData(
                new Kategori()
                {
                    KategoriID = 1,
                    KategoriAdi = "Aksiyon",
                }
                );
            builder.Entity<FilmKategorisi>().HasData(
                new FilmKategorisi()
                {
                    FilmID = 1,
                    KategoriID = 1
                }
                );
        }
    }
}
