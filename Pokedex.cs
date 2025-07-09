using CombateDePokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombateDePokemons
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InitializePokedex();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InitializePokedex()
        {
            /* //metodo copilot
             this.pokemons = new List<PokemonPlus>();
             this.pokemons.Add(new PokemonPlus("Pikachu", "Elétrico, Rápido, Amigável"));
             this.pokemons.Add(new PokemonPlus("Bulbasaur", "Planta, Inicial, Amigável"));
             this.pokemons.Add(new PokemonPlus("Charmander", "Fogo, Inicial, Corajoso"));
             this.pokemons.Add(new PokemonPlus("Squirtle", "Água, Inicial, Leal"));
             this.pokemons.Add(new PokemonPlus("Jigglypuff", "Fada, Cantora, Amigável"));
             this.pokemons.Add(new PokemonPlus("Meowth", "Normal, Astuto, Amigável"));
             this.pokemons.Add(new PokemonPlus("Psyduck", "Água, Confuso, Amigável"));
             this.pokemons.Add(new PokemonPlus("Eevee", "Normal, Adaptável, Amigável"));
             this.pokemons.Add(new PokemonPlus("Snorlax", "Normal, Preguiçoso, Amigável"));
             this.pokemons.Add(new PokemonPlus("Gengar", "Fantasma, Sombrio, Amigável"));
             this.pokemons.Add(new PokemonPlus("Onix", "Pedra, Terra, Resistente"));
             this.pokemons.Add(new PokemonPlus("Lapras", "Água, Gelo, Amigável"));
             this.pokemons.Add(new PokemonPlus("Dragonite", "Dragão, Voador, Poderoso"));
             this.pokemons.Add(new PokemonPlus("Mewtwo", "Psíquico, Poderoso, Misterioso"));
             this.pokemons.Add(new PokemonPlus("Lucario", "Lutador, Aço, Amigável"));*/


            //metodo teste
            this.pokemons = new List<PokemonPlus>();
            Pokemon p = new PokemonPlus("Pikachu", "Elétrico, Rápido, Amigável",330);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Bulbasaur", "Planta, Inicial, Amigável", 30);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Charmander", "Fogo, Inicial, Corajoso", 345);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Squirtle", "Água, Inicial, Leal", 356);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Jigglypuff", "Fada, Cantora, Amigável", 35);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Meowth", "Normal, Astuto, Amigável", 38);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Psyduck", "Água, Confuso, Amigável", 369);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Eevee", "Normal, Adaptável, Amigável", 318);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Snorlax", "Normal, Preguiçoso, Amigável", 322);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Gengar", "Fantasma, Sombrio, Amigável", 13);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Onix", "Pedra, Terra, Resistente", 30);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Lapras", "Água, Gelo, Amigável", 306);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Dragonite", "Dragão, Voador, Poderoso", 301);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Mewtwo", "Psíquico, Poderoso, Misterioso", 303);
            this.pokemons.Add((PokemonPlus)p);
            p = new PokemonPlus("Lucario", "Lutador, Aço, Amigável", 355);
            this.pokemons.Add((PokemonPlus)p);
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

