using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRestaurant.Models
{
    public class RestaurantAdresViewModel
    {
        public int AdresId { get; set; }
        [Required(ErrorMessage ="Şehir Bilgisi Giriniz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage ="İlçe Bilgisi Giriniz")]
        public string Ilce { get; set; }
        [Required(ErrorMessage ="Mahalle Bilgisi Giriniz")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage ="Sokak ve Numara Bilgisi Giriniz")]
        public string SokakVeNu { get; set; }
    }
}
