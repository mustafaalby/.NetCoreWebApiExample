using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class RestoranAdres
    {
        [Key]
        public int AdresId { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string SokakVeNu { get; set; }
        public string RestoranId { get; set; }
        public virtual Restoran Restoran { get; set; }
    }
}
