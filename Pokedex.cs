using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InitializePokedex();
        }

        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InitializePokedex()
        {
            //metodo copilot
            this.pokemons = new List<Pokemon>();
            this.pokemons.Add(new Pokemon("Pikachu", "Elétrico, Rápido, Amigável"));
            this.pokemons.Add(new Pokemon("Bulbasaur", "Planta, Inicial, Amigável"));
            this.pokemons.Add(new Pokemon("Charmander", "Fogo, Inicial, Corajoso"));
            this.pokemons.Add(new Pokemon("Squirtle", "Água, Inicial, Leal"));
            this.pokemons.Add(new Pokemon("Jigglypuff", "Fada, Cantora, Amigável"));
            this.pokemons.Add(new Pokemon("Meowth", "Normal, Astuto, Amigável"));
            this.pokemons.Add(new Pokemon("Psyduck", "Água, Confuso, Amigável"));
            this.pokemons.Add(new Pokemon("Eevee", "Normal, Adaptável, Amigável"));
            this.pokemons.Add(new Pokemon("Snorlax", "Normal, Preguiçoso, Amigável"));
            this.pokemons.Add(new Pokemon("Gengar", "Fantasma, Sombrio, Amigável"));
            this.pokemons.Add(new Pokemon("Onix", "Pedra, Terra, Resistente"));
            this.pokemons.Add(new Pokemon("Lapras", "Água, Gelo, Amigável"));
            this.pokemons.Add(new Pokemon("Dragonite", "Dragão, Voador, Poderoso"));
            this.pokemons.Add(new Pokemon("Mewtwo", "Psíquico, Poderoso, Misterioso"));
            this.pokemons.Add(new Pokemon("Lucario", "Lutador, Aço, Amigável"));


            //metodo teste
            //PokemonList p = new PokemonList("Pikachu", "Elétrico, Rápido, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Bulbasaur", "Planta, Inicial, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Charmander", "Fogo, Inicial, Corajoso");
            //this.pokemons.Add(p);
            //p = new PokemonList("Squirtle", "Água, Inicial, Leal");
            //this.pokemons.Add(p);
            //p = new PokemonList("Jigglypuff", "Fada, Cantora, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Meowth", "Normal, Astuto, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Psyduck", "Água, Confuso, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Eevee", "Normal, Adaptável, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Snorlax", "Normal, Preguiçoso, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Gengar", "Fantasma, Sombrio, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Onix", "Pedra, Terra, Resistente");
            //this.pokemons.Add(p);
            //p = new PokemonList("Lapras", "Água, Gelo, Amigável");
            //this.pokemons.Add(p);
            //p = new PokemonList("Dragonite", "Dragão, Voador, Poderoso");
            //this.pokemons.Add(p);
            //p = new PokemonList("Mewtwo", "Psíquico, Poderoso, Misterioso");
            //this.pokemons.Add(p);
            //p = new PokemonList("Lucario", "Lutador, Aço, Amigável");
            //this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            //método que usarei e como aprendi
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon(); //opção 1
                //PokemonList p = this.Pokemons[i]; //opção 2
                //p = ExibirDadosPokemon();
            }
            // Método para listar todos os Pokémons na Pokedex oferecida pelo copilot(futuramente testarei para ver as diferenças)
            //foreach (PokemonList pokemon in this.pokemons)
            //{
            //    pokemon.ExibirDadosPokemon();
            //    Console.WriteLine();
            //}
        }
    }
}

