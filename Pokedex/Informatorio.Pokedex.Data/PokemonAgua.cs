using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    class PokemonAgua: Pokemones
    {
        public PokemonAgua(string PokeName, string Apodo, double altura, double peso)
        {

            Ataques.Add("PLACAJE ");
            Ataques.Add("GRUÑIDO");
            Ataques.Add("CHORRO DE AGUA");

            this.PokeName = PokeName;
            this.Apodo = Apodo;
            this.Peso = Peso;
            this.Altura = Altura;
        }
    }
}
