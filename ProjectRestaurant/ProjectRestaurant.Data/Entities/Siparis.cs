using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }
        public string UrunAdı { get; set; }
        public float Fiyat { get; set; }
        public float Adet { get; set; }
        public int OturumId { get; set; }
        public virtual Oturum Oturum { get; set; }
    }
}
