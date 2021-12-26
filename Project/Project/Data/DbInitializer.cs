using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data
{
    public static class DbInitializer
    {//Veritabanı yüklenmeden önce ekrana gelecek veriler burada bulunmakta.
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
                },
                 new Film()
                 {
                     FilmID = 12,
                     Resim = "matrix.jpg",
                     FilmAdi = "Matrix Resurrections",
                     PiyasayaSurulmeTarihi = new DateTime(2021, 12, 22),
                     Yayinci = "Lana Wachowski",
                     Gelistirici = "Lana Wachowski",
                     Aciklama = "Matrix Resurrections”la çifte gerçeklik dünyasına geri dönülüyor. Bay Anderson yeniden beyaz tavşanı izlemeyi seçmek zorunda kalır. Çünkü Anderson gerçekliğinin fiziksel mi yoksa zihinsel bir kurgu mu olduğunu anlayıp, kendisini gerçekten tanımak istemektedir. Thomas’ın...Neo’nun bildiği tek bir şey vardır; o da bir ilüzyon dahi olsa Matrix'e girmenin ve çıkmanın tek yolunun seçimden ibaret oluşudur. Neo ne yapması gerektiğini çok iyi bilse de Matrix'in artık daha güvenli, güçlü ve tehlikeli olduğundan bihaberdir.",
                     GoruntulenmeSayisi = 100
                 },
                  new Film()
                  {
                      FilmID = 13,
                      Resim = "haryypotter.jpg",
                      FilmAdi = "Harry Potter 20th Anniversary: Return to Hogwarts",
                      PiyasayaSurulmeTarihi = new DateTime(2021, 12, 17),
                      Yayinci = " Warner Bros",
                      Gelistirici = "Warner Bros",
                      Aciklama = "HBO Max Harrry Potter hayranlarını sevindirecek bir duyuru yaptı. Harry Potter serisinin ilk filmi olan Felsefe Taşı 20. yıl dönümünde serinin yıldızları Daniel Radcliffe, Rupert Grint ve Emma Watson ve yönetmen Chris Columbus bir araya gelerek filmleri ve ürünleri konuşacak. Return to Hogwarts (Hogwarts'a Dönüş) fragmanı serinin hayranları tarafından milyonlarca kez izlendi. Oyuncuların film setinde bir araya geleceği Harry Potter Hogwarts'a Dönüş isimli özel program, yılbaşında HBO Max'te yayınlanacak. Hogwarts'a Dönüş programının mayıs ayında yayınlanan Friends’in ‘Reunion’ tarzında olması bekleniyor. HBO Max tarafından yayınlanacak Hogwarts'a 1 Ocak 2022'de streaming servisinde yayınlanacak. Haryy Potter ve Felsefe Taşı 1 Şubat 2002 tarihinde yayınlandı. HARRY POTTER 2022 HOGWARTS’A DÖNÜŞ KONUSU ?Harry Potter Hogwarts’a Dönüş programı için heyecanlanan dizinin hayranları dizinin konusu hakkında araştırma yapıyor.Harry Potter ‘Reunion’ için henüz detaylı bir bilgi verilmedi.Geçtiğimiz günlerde kısa bir fragman ve ardından da altın üçlünün yer aldığı ilk görsel paylaşılmıştı.Fragmanda bazı oyunculara Hogwarts mektubu gittiğini ve onların da Hogwarts Ekspresi'ne binmek için 9 3/4 numaralı perona gittiklerini görüldü.",
                      GoruntulenmeSayisi = 100
                  },
                   new Film()
                   {
                       FilmID = 14,
                       Resim = "eskanto.jpg",
                       FilmAdi = "Enkanto: Sihirli Dünya",
                       PiyasayaSurulmeTarihi = new DateTime(2021, 12, 17),
                       Yayinci = "Walt Disney Animasyon Stüdyoları",
                       Gelistirici = "Walt Disney Animasyon Stüdyoları",
                       Aciklama = "Film, Kolombiya dağlarının ardına gizlenmiş, Encanto adındaki harikulade ve tılsımlı bir yerde, büyülü bir evde yaşayan sıradışı Madrigal ailesinin hikayesini anlatıyor. Encanto’nun büyüsü sayesinde bu ailenin her bir çocuğu süper güçten tut iyileştirme gücüne kadar eşsiz birer armağana kavuşmuştur – Mirabel hariç. Ancak Encanto'yu çevreleyen büyünün tehlikede olduğunu keşfettiğinde ailenin tek sıradan çocuğu olan Mirabel, olağanüstü ailesinin son umudu olabileceğine karar verir.",
                       GoruntulenmeSayisi = 100
                   },
                    new Film()
                    {
                        FilmID = 15,
                        Resim = "alitasavasmelegi.jpg",
                        FilmAdi = "Alita: Savaş Meleği",
                        PiyasayaSurulmeTarihi = new DateTime(2021,12 , 17),
                        Yayinci = "James Cameron",
                        Gelistirici = "James Cameron",
                        Aciklama = "Alita: Savaş Meleği (İngilizce: Alita: Battle Angel), yönetmenliğini Robert Rodriguez'in yaptığı ve senaryosu James Cameron ve Laeta Kalogridis tarafından yazılan 2019 yapımı bir Amerikan cyberpunk aksiyon filmidir. Film, Yukito Kishiro'nin Gunnm adlı manga serisine dayanmakta olup yeni bir bedende uyandıktan sonra hiçbir şeyi hatırlamayan ve kendi geçmişini öğrenmeye karar veren bir siborg kız Alita'yı takip etmektedir. Başlangıçta 2003 yılında duyurulan filmin yapımıyla ilgili yapımcı Cameron'un Avatar ve devam filmi konusundaki çalışmaları nedeniyle art arda ertelendi. Uzun yıllar ertelenen filmin ardından Rodriguez, Nisan 2016'da filmin yönetmeni oldu ve ertesi ay Rosa Salazar filmin başrol oyuncusu seçildi.Filmin çekimleri Ekim 2016 - Şubat 2017 tarihleri arasında Austin'de, çoğunlukla Troublemaker Studios'ta gerçekleştirildi. Alita: Savaş Meleği,  dünya prömiyerini 31 Ocak 2019 tarihinde Odeon Leicester Square'da gerçekleştirdi ve ABD'de 14 Şubat 2019'da 20th Century Fox tarafından Real Real 3D, Dolby Cinema 3D ve IMAX 3D formatlarında yayınlandı. Lightstorm Entertainment'in 2009'daki Avatar'ından bu yana ilk filmi olmasının yanı sıra; 20th Century Fox'un, Walt Disney Company'nin Mart 2019'da hisselerinin çoğunluğunun kontrolünü ele almasından önceki, son filmidir. Film, dünya çapında 404 milyon doların üzerinde hasılat elde etti ve 2019'un en yüksek beşinci en çok hasılat elde eden filmi ve Rodriguez'in bugüne kadar piyasadaki en başarılı filmi oldu. Salazar'ın performansı, aksiyon sahneleri ve görsel efektler için eleştirmenlerden övgüyle karışık eleştiriler aldı, ancak karışık senaryo ve sekanslar dolayı eleştiriler almıştır.",
                        GoruntulenmeSayisi = 100
                    }

                );
            builder.Entity<Kategori>().HasData(
                new Kategori()
                {
                    KategoriID = 1,
                    KategoriAdi = "Aksiyon",
                }, 
                new Kategori()
                {
                    KategoriID = 2,
                    KategoriAdi = "Animasyon",
                }, 
                new Kategori()
                {
                    KategoriID = 3,
                    KategoriAdi = "Bilim Kurgu",
                }, 
                new Kategori()
                {
                    KategoriID = 4,
                    KategoriAdi = "Fantastik",
                }
                );
            builder.Entity<FilmKategorisi>().HasData(
                new FilmKategorisi()
                {
                    FilmID = 1,
                    KategoriID = 1
                },
                new FilmKategorisi()
                {
                    FilmID = 14,
                    KategoriID = 2
                }, new FilmKategorisi()
                {
                    FilmID = 15,
                    KategoriID = 3
                },
                 new FilmKategorisi()
                 {
                     FilmID = 12,
                     KategoriID = 4
                 }, new FilmKategorisi()
                 {
                     FilmID = 13,
                     KategoriID = 3
                 }
                );
        }
    }
}
