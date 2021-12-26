using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Identity;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data
{
    public class Context : IdentityDbContext<Kullanici>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        //Veritabanı modellerimizi tanımlıyoruz.
           public DbSet<Haber> Haber { get; set; }
            public DbSet<Film> Film { get; set; }
            public DbSet<Kategori> Kategori { get; set; }
            public DbSet<Yorum> Yorum { get; set; }
            public DbSet<Favori> Favori { get; set; }
            public DbSet<FilmKategorisi> FilmKategorisi { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Göndereceğimizi veritabanını tanımlıyoruz.
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=FilmProjesi; trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
            builder.Entity<FilmKategorisi>().HasKey(ok => new { ok.FilmID, ok.KategoriID });

            //Admin ve kullanıcı tanımlama.
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "admin", NormalizedName = "ADMIN".ToUpper() });
            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "user", NormalizedName = "USER".ToUpper() });

            var hasher = new PasswordHasher<Kullanici>();

            //Admin kullanıcısını oluşturuyoruz.
            builder.Entity<Kullanici>().HasData(
               new Kullanici
               {
                   Id = "1",
                   UserName = "g181210001@sakarya.edu.tr",
                   Email = "g181210001@sakarya.edu.tr",
                   NormalizedEmail = "g181210001@sakarya.edu.tr".ToUpper(),
                   NormalizedUserName = "g181210001@sakarya.edu.tr".ToUpper(),
                   EmailConfirmed = true,
                   PasswordHash = hasher.HashPassword(null, "g181210001")
               }
           );
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
            );
        }
    }


}


