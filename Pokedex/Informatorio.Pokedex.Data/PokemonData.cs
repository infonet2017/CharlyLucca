using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    public class PokemonData
    {
        public string PokeName { get; set; }
        public int Peso { get; set; }
        public string Apodo { get; set; }
        public int Altura { get; set; }

        public PokemonData(int Peso, string PokeName, string Apodo, int Altura)
        {
            this.PokeName = PokeName;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Apodo = Apodo;
        }


    }
}
