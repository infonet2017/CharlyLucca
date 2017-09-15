using Informatorio.pokedex.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Informatorio.Pokedex.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            PokemonManager PokeManager = new PokemonManager();

            ///PokemonManager PokeManager = new PokemonManager();

            while (flag)
            {
                MostrarMenu();
                int opcionElegida = ObtenerOpcion();

                switch (opcionElegida)
                {
                    case 1:
                        Console.WriteLine("Introduzca El nombre del POKEMON CAPTURADO");
                        string PokeName;
                        PokeName = Console.ReadLine();
                        TipoPoke();
                        int OpciTIPOPokemon = ObtenerOpcion();

                        if (OpciTIPOPokemon == 1 | OpciTIPOPokemon == 2 | OpciTIPOPokemon == 3)
                        {
                            Console.WriteLine("ingrese datos del pokemon registrado: 1ro Apodo,  2do Altura, 3ro Peso ");
                            string apodo = Console.ReadLine();
                            double Altura = Convert.ToDouble(Console.ReadLine());
                            double Peso = Convert.ToDouble(Console.ReadLine());

                            PokeManager.RegistrarPokemon(PokeName, apodo, OpciTIPOPokemon, Altura, Peso);


                        }
                        else
                        {
                            Console.WriteLine("EL TIPO EXISTE");
                            Console.ReadKey();
                        }
                        return;
                    case 2:
                        var text = PokeManager.GetTodosPokemones();
                        Console.WriteLine(text);
                        return;
                    case 3:
                        Console.WriteLine("El registro de pokemon a finalizado");
                        flag = false;
                        return;

                    default: //ME VALIDA LAS OPCIONES DEL switch (opcionElegida)
                        Console.WriteLine("ERROR, OTRO INTENTO");
                        break;


                }
            }//END WHILE


            //FUNCIONES
            void MostrarMenu()
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1- Insert Pokemon");
                Console.WriteLine("2- List of Pokémon");
                Console.WriteLine("3- Exit");
            }

            int ObtenerOpcion()
            {
                //Console.WriteLine("Ingrese la opcion");
                int opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;
            }

            void TipoPoke()
            {
                Console.WriteLine("1- Pokemon tipo Agua");
                Console.WriteLine("2- Pokemon tipo fuego");
                Console.WriteLine("3- Pokemon tipo Planta");
            }


            //var pokemngr = new PokemonManager();
            //pokemngr.RegisterPokemon("pikachu", 123);
            //pokemngr.RegisterPokemon("pikachu", 1234);
            //pokemngr.RegisterPokemon("charizard", 1234);
            //var textToshow = pokemngr.GetAllPokemons();
            //Console.WriteLine(textToshow);


            Console.ReadKey();

        }
    }
}
