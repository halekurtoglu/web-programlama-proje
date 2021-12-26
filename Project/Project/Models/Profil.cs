using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Authorize(Roles = "user")]
    public class Profil
    {
        [Key]
        public string KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
    }
}