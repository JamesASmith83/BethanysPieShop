using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPieRepository _pieRepositgory;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepositgory = pieRepository;
        }
        
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepositgory.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}