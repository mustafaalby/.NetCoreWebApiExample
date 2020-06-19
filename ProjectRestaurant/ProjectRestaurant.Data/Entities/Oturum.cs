using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class Oturum
    {
        [Key]
        public int OturumId { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public float ToplamUcret { get; set; }
        public int MasaId { get; set; }
        public virtual Masa Masa {get;set;}
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}
