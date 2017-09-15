using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    public class PokemonStorage
    {
        private List<PokemonData> Pokemones { get; set; }

        public PokemonStorage()
        {
            Pokemones = new List<PokemonData>();
        }

        public void Save(PokemonData pkm)
        {

            //finds any coincidence in the list based on the pkm.Name
            var searchResult = Pokemones.Where(p => p.PokeName == pkm.PokeName).ToList();

            //if it didnt find any coincidence, then searchresult is null
            if (searchResult.Count() > 0)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                Pokemones.Add(pkm);
            }

        }

        public PokemonData Get(string PokeName)
        {
            //lambda expression
            var result = Pokemones.Find(p => p.PokeName == PokeName);
            return result;

        }

        public List<PokemonData> GetAll()
        {
             return Pokemones;
        }

        //public void Remove(string PokeName)
        //{
        //    Pokemones.RemoveAll(p => p.PokeName == PokeName);
        //}

        public PokemonData BuscaApodo(string Apodo)
        {
           var Poke = Pokemones.GetAll();
            var resultado = Pokemones.Find(p => p.Apodo == Apodo);

            if (resultado == null)
            {
                throw new Exception("YA ESTA ALMACENADO");
            }
            else
            {
                return (resultado);
            }
        }

        public float PromedioPeso()
        {
            var Pokem = Pokemones.GetAll();
            float total = 0;
            foreach (var poke in Pokemones)
            {
                total = total + poke.Peso;
            }
            return (total / Pokemones.Count());
        }




    } 
            
}
