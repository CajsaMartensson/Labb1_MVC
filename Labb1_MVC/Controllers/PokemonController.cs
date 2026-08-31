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
        public async Task<IActionResult> Index(string query)
        {
            var pokemonList = await _pokemonService.GetPokemon();

            if (!string.IsNullOrWhiteSpace(query))
            {
                pokemonList = pokemonList
                        .Where(p => p.Name.Contains(query.ToLower()))
                        .ToList();
            }

            return View(pokemonList);
        }

        public async Task<IActionResult> Detail(string name)
        {
            var pokemon = await _pokemonService.GetPokemonByName(name);

            return View(pokemon);
        }
    }
}
