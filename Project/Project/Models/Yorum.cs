using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Project.Identity;

namespace Project.Models
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        [Required]
        public string YapilanYorum { get; set; }
        [Required]
        public DateTime OlusturulmaTarihi { get; set; }
        public int FilmID { get; set; }
        [Required]
        public Film Film{ get; set; }
        public string KullaniciAdi { get; set; }
    }
}