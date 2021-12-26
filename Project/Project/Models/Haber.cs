using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Haber
    {
        [Key]
        public int HaberID { get; set; }
        [Required(ErrorMessage = "Resim alanı boş bırakılamaz...")]
        public string HaberResim { get; set; }
        [Required]
        public string HaberBaslik { get; set; }
        [Required]
        public string HaberIcerik { get; set; }
        [Required]
        public bool haberGosterilsinmi { get; set; }
    }
}