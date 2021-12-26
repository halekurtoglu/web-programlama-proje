using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class FilmDetailViewModel
    {
        public Film Film { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public bool favorilerdemi { get; set; }
    }
}
