using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Film
    {
        [Key]
        public int FilmID { get; set; }
        [Required]
        public string Resim { get; set; }
        [Required]
        public string FilmAdi { get; set; }
        [Required]
        public DateTime PiyasayaSurulmeTarihi { get; set; }
        [Required]
        public string Yayinci { get; set; }
        [Required]
        public string Gelistirici { get; set; }
        [Required]
        public string Aciklama { get; set; }
        public int GoruntulenmeSayisi { get; set; }
        public IList<FilmKategorisi> FilmKategorileri { get; set; }

        public List<Yorum> Yorumlar { get; set; }
        public bool filmGosterilsinmi { get; set; }
    }
}