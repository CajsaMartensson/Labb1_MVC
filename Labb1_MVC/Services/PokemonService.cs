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

        public async Task<Pokemon> GetPokemon()
        {
            try
            {
                var response = await _httpClient.GetAsync("");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<PokemonApiResponse>(json);

                

                return data.Name;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal class PokemonApiResponse()
        {
            [System.Text.Json.Serialization.JsonPropertyName("result")]
            public List<Pokemon> Name { get; set; }
        }
    }
}
