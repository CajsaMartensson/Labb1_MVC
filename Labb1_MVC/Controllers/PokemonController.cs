using Labb1_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb1_MVC.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        public async Task<IActionResult> Index()
        {
            //Lägg till så den visar pokemon
            return View();
        }
    }
}
