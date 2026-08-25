using Labb1_MVC.Models;
using System.Text.Json;

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
    }
}
