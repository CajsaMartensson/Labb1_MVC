using Labb1_MVC.Models;
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
            var pokemonList = await _pokemonService.GetPokemon();

            return View(pokemonList);
        }

        public async Task<IActionResult> Description(string name)
        {
            var pokemon = await _pokemonService.GetPokemonByName(name);

            return View(pokemon);
        }
    }
}
