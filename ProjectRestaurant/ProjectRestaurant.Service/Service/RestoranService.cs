using Microsoft.AspNetCore.Identity;
using ProjectRestaurant.Data.Context;
using ProjectRestaurant.Data.Entities;
using ProjectRestaurant.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRestaurant.Service.Service
{
    public class RestoranService
    {
        private readonly UserManager<Restoran> _userManager;
        private readonly SignInManager<Restoran> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly RestoranDbContext _context;
        public RestoranService(
            UserManager<Restoran> userManager,
            SignInManager<Restoran> signInManager,
            RoleManager<IdentityRole> roleManager,
            RestoranDbContext context
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IdentityResult> YeniRestoran(RestoranYeniKayitDto model)
        {
            IdentityResult result = new IdentityResult();
            var user = new Restoran {
                Email=model.Email,
                UserName=model.UserName
            };
            result= await _userManager.CreateAsync(user, model.Password);            
            return result;
            
        }
        public async Task<SignInResult> Login(RestoranLoginDto model)
        {
            SignInResult result = new SignInResult();
            var user = await _userManager.FindByNameAsync(model.UserName);
            result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            return result;
        }
        public async void Logout()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<List<Masa>> MasalariListele(string userName)
        {
            var user =await _userManager.FindByNameAsync(userName);
            var masalar = _context.Set<Masa>().Where(x => x.RestoranId == user.Id).ToList();
            return masalar;
        }
        public async void MasaEkle(Masa masa, string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            masa.Restoran = user;
            masa.RestoranId = user.Id;
             _context.Set<Masa>().Add(masa);
            var result =await _context.SaveChangesAsync();
        }

    }
}
