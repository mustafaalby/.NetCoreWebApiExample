using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class UrunTur
    {
        [Key]
        public int UrunTurId { get; set;}
        public string TurAdı { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
