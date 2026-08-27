using System.Text.Json.Serialization;

namespace Labb1_MVC.Models
{
    public class PokemonStat
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
        [JsonPropertyName("stat")]
        public StatIfo? Stat { get; set; }
    }

    public class StatIfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
