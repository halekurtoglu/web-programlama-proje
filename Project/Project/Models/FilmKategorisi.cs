using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class FilmKategorisi
    {
        [Key]
        public int FilmID { get; set; }
        public Film Film { get; set; }

        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }
}