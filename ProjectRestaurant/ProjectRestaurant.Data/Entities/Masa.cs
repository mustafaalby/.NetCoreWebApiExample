using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class Masa
    {
        [Key]
        public int MasaId { get; set; }
        public string MasaAdı { get; set; }
        public string RestoranId { get; set; }
        public bool MusaitMi { get; set; }
        public virtual Restoran Restoran{get;set;}  
        public virtual ICollection<Oturum> Oturum { get; set; }
    }
}
