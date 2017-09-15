using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    class PokeRepo
    {

        // Listas de los pokemons de cada tipo

        public List<PokemonPlanta> PokemonesPlanta { get; set; }
        public List<PokemonFuego> PokemonesFuego { get; set; }
        public List<PokemonAgua> PokemonesAgua { get; set; }


        //Lista general de todos los pokemons

        public List<Pokemones> Pokemones { get; set; }


        //Constructor de la clase Repositorio; inicializa todas las listas

        public PokeRepo()
        {
            PokemonesPlanta = new List<PokemonPlanta>();
            PokemonesFuego = new List<PokemonFuego>();
            PokemonesAgua = new List<PokemonAgua>();
            Pokemones = new List<Pokemones>();

        }


        //Metodos para guardar cada pokemon en la lista que le corresponde

        public void GuardarPokemonAgua(PokemonAgua pokemon)
        {
            PokemonesAgua.Add(pokemon);
        }

        public void GuardarPokemonFuego(PokemonFuego pokemones)
        {
            PokemonesFuego.Add(pokemones);
        }

        public void GuardarPokemonPlanta(PokemonPlanta pokemones)
        {
            PokemonesPlanta.Add(pokemones);
        }


        //Guarda los pokemons en la lista general

        public void GuardarPokemones(Pokemones pokemones)
        {
            Pokemones.Add(pokemones);
        }


        //Verifica que el pokemon no exista y lo Almacena en la lista general

        public void GuardarPokemon(Pokemones Pokemones, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    var Busqueda = PokemonesPlanta.Where(p => p.PokeName == Pokemones.PokeName).ToList();

                    //if it didnt find any coincidence, then searchresult is null
                    if (Busqueda.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        //otherwise it stores the pokemon successfully
                        GuardarPokemones(Pokemones);
                    }
                    break;

                case 2:
                    var Busqueda1 = PokemonesAgua.Where(p => p.PokeName == Pokemones.PokeName).ToList();

                    //if it didnt find any coincidence, then searchresult is null
                    if (Busqueda1.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        //otherwise it stores the pokemon successfully
                        GuardarPokemones(Pokemones);
                    }
                    break;

                //finds any coincidence in the list based on the pkm.Name

                case 3:
                    var Busqueda2 = PokemonesFuego.Where(p => p.PokeName == Pokemones.PokeName).ToList();

                    //if it didnt find any coincidence, then searchresult is null
                    if (Busqueda2.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        //otherwise it stores the pokemon successfully
                        GuardarPokemones(Pokemones);
                    }
                    break;
            }
        }


        //Devuelve la lista con todos los pokemones capturados

        public List<Pokemones> GetAll()
        {
            return Pokemones;
        }


        //Devuelve la lista con todos los pokemones capturados tipo planta

        public List<PokemonPlanta> GetAllPlanta()
        {
            return PokemonesPlanta;
        }


        //Devuelve la lista con todos los pokemones capturados tipo Fuego

        public List<PokemonFuego> GetAllFuego()
        {
            return PokemonesFuego;
        }


        //Devuelve la lista con todos los pokemones capturados tipo Agua

        public List<PokemonAgua> GetAllAgua()
        {
            return PokemonesAgua;
        }


    }
}
