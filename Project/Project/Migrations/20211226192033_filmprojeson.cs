using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class filmprojeson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PiyasayaSurulmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yayinci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gelistirici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoruntulenmeSayisi = table.Column<int>(type: "int", nullable: false),
                    filmGosterilsinmi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmID);
                });

            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    HaberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    haberGosterilsinmi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.HaberID);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favori",
                columns: table => new
                {
                    FavoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favori", x => x.FavoriID);
                    table.ForeignKey(
                        name: "FK_Favori_Film_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Film",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YapilanYorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorum_Film_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Film",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmKategorisi",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmKategorisi", x => new { x.FilmID, x.KategoriID });
                    table.ForeignKey(
                        name: "FK_FilmKategorisi_Film_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Film",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmKategorisi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "64b24732-6f1d-4bb9-9106-7f0ab895005b", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "bce014de-5af9-482c-8205-1efe67b88e53", "g181210001@sakarya.edu.tr", true, false, null, "G181210001@SAKARYA.EDU.TR", "G181210001@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEENeoBYdlYgS+QonoAQloCjneX+9+R6ZbEqH1J2mTNeAGFiBSIGNABmdJ6mLo/RDqA==", null, false, "ec1c87f6-8dee-4cef-bf96-af6b69dd6c98", false, "g181210001@sakarya.edu.tr" });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmID", "Aciklama", "FilmAdi", "Gelistirici", "GoruntulenmeSayisi", "PiyasayaSurulmeTarihi", "Resim", "Yayinci", "filmGosterilsinmi" },
                values: new object[,]
                {
                    { 1, "Örümcek-Adam Eve Dönüş Yok, kimliği açığa Örümcek-Adam'ın, sırrını geri vermesi için Doktor Strange'den yardım istemesiyle birlikte yaşananları konu ediyor. Örümcek-Adam'ın kimliği ifşa edilerek onun ve sevdiklerinin hayatı, halkın gözü önüne serilir. Kendisini büyük bir kaosun ortasında bulan Peter, aynı zamanda suç ortakları olarak lanse edilen MJ ve Ned'in hayatının da olumsuz etkilenmesine şahit olur. Arkadaşların üniversiteye girme şanslarının yok olmasına seyirci kalmak istemeyen Peter, sırrını geri vermesi için Doktor Strange'den yardım ister. Peter'ın yakarışından etkilenip ona yardım etmeyi kabul eden Strange, Unutma Büyüsü'nü yapmaya başlar. Ancak bu büyü, MJ, Ned, May ve Happy'nin de Örümcek-Adam'ın kim olduğunu unutmasına neden olacaktır. Arkadaşlarının kim olduğunu hatırlamasını, diğer kişilerin unutmasını isteyen Peter, Strange büyüyü yaparken parametreleri değiştirir. Ancak bu durum beklenmedik olaylara neden olur.", "Örümcek Adam", "Marvel Studios", 100, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "orumcekAdam.jpg", "Marvel Studios", false },
                    { 12, "Matrix Resurrections”la çifte gerçeklik dünyasına geri dönülüyor. Bay Anderson yeniden beyaz tavşanı izlemeyi seçmek zorunda kalır. Çünkü Anderson gerçekliğinin fiziksel mi yoksa zihinsel bir kurgu mu olduğunu anlayıp, kendisini gerçekten tanımak istemektedir. Thomas’ın...Neo’nun bildiği tek bir şey vardır; o da bir ilüzyon dahi olsa Matrix'e girmenin ve çıkmanın tek yolunun seçimden ibaret oluşudur. Neo ne yapması gerektiğini çok iyi bilse de Matrix'in artık daha güvenli, güçlü ve tehlikeli olduğundan bihaberdir.", "Matrix Resurrections", "Lana Wachowski", 100, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "matrix.jpg", "Lana Wachowski", false },
                    { 13, "HBO Max Harrry Potter hayranlarını sevindirecek bir duyuru yaptı. Harry Potter serisinin ilk filmi olan Felsefe Taşı 20. yıl dönümünde serinin yıldızları Daniel Radcliffe, Rupert Grint ve Emma Watson ve yönetmen Chris Columbus bir araya gelerek filmleri ve ürünleri konuşacak. Return to Hogwarts (Hogwarts'a Dönüş) fragmanı serinin hayranları tarafından milyonlarca kez izlendi. Oyuncuların film setinde bir araya geleceği Harry Potter Hogwarts'a Dönüş isimli özel program, yılbaşında HBO Max'te yayınlanacak. Hogwarts'a Dönüş programının mayıs ayında yayınlanan Friends’in ‘Reunion’ tarzında olması bekleniyor. HBO Max tarafından yayınlanacak Hogwarts'a 1 Ocak 2022'de streaming servisinde yayınlanacak. Haryy Potter ve Felsefe Taşı 1 Şubat 2002 tarihinde yayınlandı. HARRY POTTER 2022 HOGWARTS’A DÖNÜŞ KONUSU ?Harry Potter Hogwarts’a Dönüş programı için heyecanlanan dizinin hayranları dizinin konusu hakkında araştırma yapıyor.Harry Potter ‘Reunion’ için henüz detaylı bir bilgi verilmedi.Geçtiğimiz günlerde kısa bir fragman ve ardından da altın üçlünün yer aldığı ilk görsel paylaşılmıştı.Fragmanda bazı oyunculara Hogwarts mektubu gittiğini ve onların da Hogwarts Ekspresi'ne binmek için 9 3/4 numaralı perona gittiklerini görüldü.", "Harry Potter 20th Anniversary: Return to Hogwarts", "Warner Bros", 100, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "harrypotter.jpg", " Warner Bros", false },
                    { 14, "Film, Kolombiya dağlarının ardına gizlenmiş, Encanto adındaki harikulade ve tılsımlı bir yerde, büyülü bir evde yaşayan sıradışı Madrigal ailesinin hikayesini anlatıyor. Encanto’nun büyüsü sayesinde bu ailenin her bir çocuğu süper güçten tut iyileştirme gücüne kadar eşsiz birer armağana kavuşmuştur – Mirabel hariç. Ancak Encanto'yu çevreleyen büyünün tehlikede olduğunu keşfettiğinde ailenin tek sıradan çocuğu olan Mirabel, olağanüstü ailesinin son umudu olabileceğine karar verir.", "Enkanto: Sihirli Dünya", "Walt Disney Animasyon Stüdyoları", 100, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "eskanto.jpg", "Walt Disney Animasyon Stüdyoları", false },
                    { 15, "Alita: Savaş Meleği (İngilizce: Alita: Battle Angel), yönetmenliğini Robert Rodriguez'in yaptığı ve senaryosu James Cameron ve Laeta Kalogridis tarafından yazılan 2019 yapımı bir Amerikan cyberpunk aksiyon filmidir. Film, Yukito Kishiro'nin Gunnm adlı manga serisine dayanmakta olup yeni bir bedende uyandıktan sonra hiçbir şeyi hatırlamayan ve kendi geçmişini öğrenmeye karar veren bir siborg kız Alita'yı takip etmektedir. Başlangıçta 2003 yılında duyurulan filmin yapımıyla ilgili yapımcı Cameron'un Avatar ve devam filmi konusundaki çalışmaları nedeniyle art arda ertelendi. Uzun yıllar ertelenen filmin ardından Rodriguez, Nisan 2016'da filmin yönetmeni oldu ve ertesi ay Rosa Salazar filmin başrol oyuncusu seçildi.Filmin çekimleri Ekim 2016 - Şubat 2017 tarihleri arasında Austin'de, çoğunlukla Troublemaker Studios'ta gerçekleştirildi. Alita: Savaş Meleği,  dünya prömiyerini 31 Ocak 2019 tarihinde Odeon Leicester Square'da gerçekleştirdi ve ABD'de 14 Şubat 2019'da 20th Century Fox tarafından Real Real 3D, Dolby Cinema 3D ve IMAX 3D formatlarında yayınlandı. Lightstorm Entertainment'in 2009'daki Avatar'ından bu yana ilk filmi olmasının yanı sıra; 20th Century Fox'un, Walt Disney Company'nin Mart 2019'da hisselerinin çoğunluğunun kontrolünü ele almasından önceki, son filmidir. Film, dünya çapında 404 milyon doların üzerinde hasılat elde etti ve 2019'un en yüksek beşinci en çok hasılat elde eden filmi ve Rodriguez'in bugüne kadar piyasadaki en başarılı filmi oldu. Salazar'ın performansı, aksiyon sahneleri ve görsel efektler için eleştirmenlerden övgüyle karışık eleştiriler aldı, ancak karışık senaryo ve sekanslar dolayı eleştiriler almıştır.", "Alita: Savaş Meleği", "James Cameron", 100, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "alitasavasmelegi.jpg", "James Cameron", false }
                });

            migrationBuilder.InsertData(
                table: "Haber",
                columns: new[] { "HaberID", "HaberBaslik", "HaberIcerik", "HaberResim", "haberGosterilsinmi" },
                values: new object[,]
                {
                    { 1, "Örümcek Adam eve geri dönüş yok filmi vizyona girdi!", "Örümcek-Adam: Eve Dönüş Yok Columbia Pictures ve Marvel Studios tarafından ortaklaşa üretilen ve Sony Pictures tarafından dağıtılan, Marvel Comics karakteri Örümcek Adam çizgi romanlarından uyarlanan ABD süper kahraman filmidir.", "orumcekAdam.jpg", false },
                    { 2, "Matrix Resurrections filmi vizyona girdi!", "Matrix Resurrections”la çifte gerçeklik dünyasına geri dönülüyor. Bay Anderson yeniden beyaz tavşanı izlemeyi seçmek zorunda kalır. Çünkü Anderson gerçekliğinin fiziksel mi yoksa zihinsel bir kurgu mu olduğunu anlayıp, kendisini gerçekten tanımak istemektedir. Thomas’ın...Neo’nun bildiği tek bir şey vardır; o da bir ilüzyon dahi olsa Matrix'e girmenin ve çıkmanın tek yolunun seçimden ibaret oluşudur. Neo ne yapması gerektiğini çok iyi bilse de Matrix'in artık daha güvenli, güçlü ve tehlikeli olduğundan bihaberdir.", "matrix.jpg", false },
                    { 3, "Harry Potter 20th Anniversary: Return to Hogwarts filmi çok yakında sevenleriyle buluşacak!", "HBO Max Harrry Potter hayranlarını sevindirecek bir duyuru yaptı. Harry Potter serisinin ilk filmi olan Felsefe Taşı 20. yıl dönümünde serinin yıldızları Daniel Radcliffe, Rupert Grint ve Emma Watson ve yönetmen Chris Columbus bir araya gelerek filmleri ve ürünleri konuşacak. Return to Hogwarts (Hogwarts'a Dönüş) fragmanı serinin hayranları tarafından milyonlarca kez izlendi. Oyuncuların film setinde bir araya geleceği Harry Potter Hogwarts'a Dönüş isimli özel program, yılbaşında HBO Max'te yayınlanacak. Hogwarts'a Dönüş programının mayıs ayında yayınlanan Friends’in ‘Reunion’ tarzında olması bekleniyor. HBO Max tarafından yayınlanacak Hogwarts'a 1 Ocak 2022'de streaming servisinde yayınlanacak. Haryy Potter ve Felsefe Taşı 1 Şubat 2002 tarihinde yayınlandı. HARRY POTTER 2022 HOGWARTS’A DÖNÜŞ KONUSU ?Harry Potter Hogwarts’a Dönüş programı için heyecanlanan dizinin hayranları dizinin konusu hakkında araştırma yapıyor.Harry Potter ‘Reunion’ için henüz detaylı bir bilgi verilmedi.Geçtiğimiz günlerde kısa bir fragman ve ardından da altın üçlünün yer aldığı ilk görsel paylaşılmıştı.Fragmanda bazı oyunculara Hogwarts mektubu gittiğini ve onların da Hogwarts Ekspresi'ne binmek için 9 3/4 numaralı perona gittiklerini görüldü.", "harrypotter.jpg", false },
                    { 4, "Enkanto: Sihirli Dünya animasyonu animasyon severlerin dört gözle beklediği an geldi!", "Film, Kolombiya dağlarının ardına gizlenmiş, Encanto adındaki harikulade ve tılsımlı bir yerde, büyülü bir evde yaşayan sıradışı Madrigal ailesinin hikayesini anlatıyor. Encanto’nun büyüsü sayesinde bu ailenin her bir çocuğu süper güçten tut iyileştirme gücüne kadar eşsiz birer armağana kavuşmuştur – Mirabel hariç. Ancak Encanto'yu çevreleyen büyünün tehlikede olduğunu keşfettiğinde ailenin tek sıradan çocuğu olan Mirabel, olağanüstü ailesinin son umudu olabileceğine karar verir.", "eskanto.jpg", false },
                    { 5, "Alita: Savaş Meleği filmi vizyona girdi! Tüm sinemalarda biletler tükendi!", "Alita: Savaş Meleği (İngilizce: Alita: Battle Angel), yönetmenliğini Robert Rodriguez'in yaptığı ve senaryosu James Cameron ve Laeta Kalogridis tarafından yazılan 2019 yapımı bir Amerikan cyberpunk aksiyon filmidir. Film, Yukito Kishiro'nin Gunnm adlı manga serisine dayanmakta olup yeni bir bedende uyandıktan sonra hiçbir şeyi hatırlamayan ve kendi geçmişini öğrenmeye karar veren bir siborg kız Alita'yı takip etmektedir. Başlangıçta 2003 yılında duyurulan filmin yapımıyla ilgili yapımcı Cameron'un Avatar ve devam filmi konusundaki çalışmaları nedeniyle art arda ertelendi. Uzun yıllar ertelenen filmin ardından Rodriguez, Nisan 2016'da filmin yönetmeni oldu ve ertesi ay Rosa Salazar filmin başrol oyuncusu seçildi.Filmin çekimleri Ekim 2016 - Şubat 2017 tarihleri arasında Austin'de, çoğunlukla Troublemaker Studios'ta gerçekleştirildi. Alita: Savaş Meleği,  dünya prömiyerini 31 Ocak 2019 tarihinde Odeon Leicester Square'da gerçekleştirdi ve ABD'de 14 Şubat 2019'da 20th Century Fox tarafından Real Real 3D, Dolby Cinema 3D ve IMAX 3D formatlarında yayınlandı. Lightstorm Entertainment'in 2009'daki Avatar'ından bu yana ilk filmi olmasının yanı sıra; 20th Century Fox'un, Walt Disney Company'nin Mart 2019'da hisselerinin çoğunluğunun kontrolünü ele almasından önceki, son filmidir. Film, dünya çapında 404 milyon doların üzerinde hasılat elde etti ve 2019'un en yüksek beşinci en çok hasılat elde eden filmi ve Rodriguez'in bugüne kadar piyasadaki en başarılı filmi oldu. Salazar'ın performansı, aksiyon sahneleri ve görsel efektler için eleştirmenlerden övgüyle karışık eleştiriler aldı, ancak karışık senaryo ve sekanslar dolayı eleştiriler almıştır.", "alitasavasmelegi.jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Aksiyon" },
                    { 2, "Animasyon" },
                    { 3, "Bilim Kurgu" },
                    { 4, "Fantastik" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "FilmKategorisi",
                columns: new[] { "FilmID", "KategoriID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 14, 2 },
                    { 15, 3 },
                    { 13, 3 },
                    { 12, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Favori_FilmID",
                table: "Favori",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmKategorisi_KategoriID",
                table: "FilmKategorisi",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_FilmID",
                table: "Yorum",
                column: "FilmID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favori");

            migrationBuilder.DropTable(
                name: "FilmKategorisi");

            migrationBuilder.DropTable(
                name: "Haber");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
