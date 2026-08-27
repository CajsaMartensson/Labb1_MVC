using Labb1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb1_MVC.Services
{
    public interface IPokemonService
    {
        Task<List<Pokemon>> GetPokemon();

        Task<IActionResult> GetPokemonByName(string name);
    }
}
