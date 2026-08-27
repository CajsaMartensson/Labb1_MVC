using System.Text.Json.Serialization;

namespace Labb1_MVC.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        [JsonPropertyName("attack")]
        public int Attack { get; set; }
        [JsonPropertyName("defense")]
        public int Defense { get; set; }
        [JsonPropertyName("hp")]
        public int Hp { get; set; }
        [JsonPropertyName("speed")]
        public int Speed { get; set; }

    }
}
