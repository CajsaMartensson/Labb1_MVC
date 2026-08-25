namespace Labb1_MVC.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Form { get; set; } = string.Empty;
        public List<Ability> Abilites { get; set; } = new List<Ability>();

    }
}
