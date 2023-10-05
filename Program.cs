using DesafioPokemon;
using Newtonsoft.Json;
using System.Text.Json;

using (var client  = new HttpClient())
{
    var url = "https://pokeapi.co/api/v2/pokemon";
    var response = await client.GetStringAsync(url);
    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response)!;
    pokemon.Exibir();
}