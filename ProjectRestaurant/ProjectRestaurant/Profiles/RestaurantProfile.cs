using AutoMapper;
using ProjectRestaurant.Data.Entities;
using ProjectRestaurant.Models;
using ProjectRestaurant.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRestaurant.Profiles
{
    public class RestaurantProfile:Profile
    {
        public RestaurantProfile()
        {
            CreateMap<NewRestaurantSignUpViewModel, NewRestaurantDto>();
            CreateMap<RestaurantSignInViewModel, RestoranLoginDto>();
            CreateMap<RestaurantEditViewModel, Restoran>();
            CreateMap<Restoran, RestaurantEditViewModel>();

            CreateMap<RestaurantAdresViewModel, RestoranAdres>();
            CreateMap<RestoranAdres, RestaurantAdresViewModel>();
            

        }
    }
}
