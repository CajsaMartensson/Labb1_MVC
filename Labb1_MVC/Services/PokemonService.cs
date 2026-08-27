using Labb1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Labb1_MVC.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;
        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pokemon>> GetPokemon()
        {
            try
            {
                var response = await _httpClient.GetAsync("pokemon?limit=20");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<PokemonApiResponse>(json);

                return data.Results;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal class PokemonApiResponse()
        {
            [System.Text.Json.Serialization.JsonPropertyName("results")]
            public List<Pokemon>? Results { get; set; }
        }

        public async Task<IActionResult> GetPokemonByName(string name)
        {
            try
            {
                var pokemonList = GetPokemon();

                pokemonList.

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //internal class PokemonByNameApiResponse()
        //{

        //    [System.Text.Json.Serialization.JsonPropertyName("height")]
        //    public int Height { get; set; }
        //    [System.Text.Json.Serialization.JsonPropertyName("weight")]
        //    public int Weight { get; set; }
        //    [System.Text.Json.Serialization.JsonPropertyName("type")]
        //    public string Type { get; set; } = string.Empty;
        //    [System.Text.Json.Serialization.JsonPropertyName("abilities")]
        //    public List<Ability> Abilites { get; set; } = new List<Ability>();
        //    [System.Text.Json.Serialization.JsonPropertyName("stats")]
        //    public Stats? Stats { get; set; }
        //}
    }
}
