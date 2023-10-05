using DesafioPokemon;

public class Pokemon
{
    public IEnumerable<Ability>? results { get; set; }

    public void Exibir()
    {
        Console.WriteLine("Pokemons");
        foreach (var item in results)
        {
            Console.WriteLine($"Nome: {item.name}");
            Console.WriteLine($"Url: {item.url}");
        }
    }
}