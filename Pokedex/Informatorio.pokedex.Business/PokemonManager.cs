using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Informatorio.Pokedex.Data;


namespace Informatorio.pokedex.Business
{
    public class PokemonManager 
    {
        private PokemonStorage pokemonStorage { get; set; }


        public PokemonManager()
        {
            pokemonStorage = new PokemonStorage();
           
        }

    
        public void RegisterPokemon(string Pokename, int Peso, int Altura, string Apodo )
        {
            var newPokemon = new PokemonData(Peso, Pokename, Apodo,  Altura);
            Console.WriteLine("altura  Name" );//modificación
           


            try
            {
                pokemonStorage.Save(newPokemon);
            }
            catch (Exception)
            {

                Console.WriteLine("something wrong with your data. Are you sure you are not storing the same pokemon twice?");
            }
            


        }

        public string GetAllPokemons()
        {
            var allPokemons = pokemonStorage.GetAll();

            var text = "";

            foreach (var pkm in allPokemons)
            {

                text = text + "nombre: " + pkm.PokeName + " altura: " + pkm.Peso + "\n";
            }

            return text;
        }

    }
}
