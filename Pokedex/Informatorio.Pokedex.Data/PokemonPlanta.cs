using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    class PokemonPlanta : Pokemones
    {
        public PokemonPlanta(String Nombre, String alias, double altura, double peso)
        {

            Ataques.Add("PLACAJE ");
            Ataques.Add("GRUÑIDO");
            Ataques.Add("LATIGO SEFA");

            this.PokeName = Nombre;
            this.Apodo = Apodo;
            this.Peso = Peso;
            this.Altura = Altura;
        }
    }
}
