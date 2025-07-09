using CombateDePokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombateDePokemons
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus()
        {
            //this.Nome = "";
            //this.Caracteristicas = "";
            this.Poder = 0;
        }

        public PokemonPlus(string nome, string caracteristicas, int poder): base(nome, caracteristicas)
        {
            //this.Nome = "";
            //this.Caracteristicas = "";
            this.Poder = 0;
        }

        public int Poder { get; set; }

        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do pokemon: " + this.Nome);
            Console.WriteLine("Características do pokemon: " + this.Caracteristicas);
            Console.WriteLine("Poder do pokemon: " + this.Poder);
        }
    }

}
