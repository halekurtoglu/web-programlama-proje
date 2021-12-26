using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Authorize(Roles = "user")]
    public class Giris
    {
        [Key]
        public string KullaniciID { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }
        public string Url { get; set; }
    }
}