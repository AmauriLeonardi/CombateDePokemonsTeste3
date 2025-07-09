using CombateDePokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombateDePokemons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                }
                Console.ReadKey();
                Console.Clear();
            }
            //pokedex.ListarPokemons();
            //PokemonList p = pokedex.Pokemons[0];
            //p.ExibirDadosPokemon();
            //PokemonList pokemon = new PokemonList("Pikachu", "Elétrico, Rápido, Amigável" );
            ////pokemon.Nome = "Pikachu";
            ////pokemon.Caracteristicas = "Elétrico, Rápido, Amigável";
            //pokemon.ExibirDadosPokemon();
            ////Console.WriteLine("\nPressione qualquer tecla para sair...");
            //Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokédex  ----    Agenda Pokémon");
            Console.WriteLine("0 - Sair da pokédex.");
            Console.WriteLine("1 - Listar Pokémons.");
            Console.WriteLine("Selecione uma opção:");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;

            // Método que exibe o menu principal com mais detalhes (futuramente testarei para ver as diferenças)
            //if (resp == 0)
            //{
            //    Console.WriteLine("Saindo da Pokédex...");
            //    Environment.Exit(0);
            //}
            //else if (resp == 1)
            //{
            //    Console.WriteLine("Listando Pokémons...");
            //    return resp;
            //}
            //else
            //{
            //    Console.WriteLine("Opção inválida. Tente novamente.");
            //    return Menu();
            //}

            // Método que exibe o menu principal opção oferecida pelo coplot(futuramente testarei para ver as diferenças)
            //Console.Clear();
            //Console.WriteLine("Menu Principal");
            //Console.WriteLine("1 - Listar Pokémons");
            //Console.WriteLine("2 - Adicionar Pokémon");
            //Console.WriteLine("3 - Sair");
            //Console.Write("Escolha uma opção: ");
            //int opcao = Convert.ToInt32(Console.ReadLine());
            //return opcao;
        }
    }
}
