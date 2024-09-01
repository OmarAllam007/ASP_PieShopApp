using Microsoft.AspNetCore.Mvc;
using PieShopApp.Models;
using PieShopApp.ViewModels;

namespace PieShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;


        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel(_pieRepository.PiesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
