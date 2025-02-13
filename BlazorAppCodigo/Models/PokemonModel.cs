namespace BlazorAppCodigo.Models
{
    public class PokemonModel
    {
        public int pokemon_id { get; set; }
        public string form { get; set; }       
        public string pokemon_name { get; set; }
     
        public List<Evolution> evolutions { get; set; }
     
    }
    public class Evolution
    {
        public int candy_required { get; set; }
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
    }
}
