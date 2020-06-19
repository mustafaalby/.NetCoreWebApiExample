using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectRestaurant.Data.Entities
{
    public class Restoran:IdentityUser
    {        
        public string RestoranAdı { get; set; }
        public int CalisanSayisi { get; set; }
        public virtual RestoranAdres RestoranAdres{get;set;}
        public virtual ICollection<Masa> Masa { get; set; }

    }
}
