using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string UrunAdı { get; set; }
        public float Fiyat { get; set; }
        public float Adet { get; set; }
        public string Aciklama { get; set; }
        public int UrunTurId { get; set; }
        public virtual  UrunTur UrunTur {get;set;}
    }
}
