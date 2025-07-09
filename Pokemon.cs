using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombateDePokemons
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.nome = "";
            this.caracteristicas = "";
        }

        public Pokemon(string nome, string caracteristicas)
        {
            this.nome = nome;
            this.caracteristicas = caracteristicas;
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                string texto = value.ToUpper();
                nome = texto;
            }
        }

        private string caracteristicas;// armazena as características do Pokémon

        public string Caracteristicas// Características do Pokémon
        {
            get { return caracteristicas; }
            set
            {

                caracteristicas = value.ToUpper();
            }
        }


        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do pokemon: " + this.Nome);
            Console.WriteLine("Características do pokemon: " + this.Caracteristicas);
        }

        public void ExibirDadosPokemon(Boolean format)
        {
            if (format == true)
            {
                Console.WriteLine("Pokemon: " + this.Nome + ": " + this.Caracteristicas.ToLower());

            }
            else
            {
                Console.WriteLine("Nome do pokemon: " + this.Nome);
                Console.WriteLine("Características do pokemon: " + this.Caracteristicas);
            }

        }
    }
}

