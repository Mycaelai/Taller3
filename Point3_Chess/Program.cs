using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Realizar un programa en C#, que permita implementar un juego de ajedrez, según el diagrama de clases a continuación...
Enunciados:
- Una Partida se crea de la siguiente manera:
o Con dos jugadores                                                                                                                                                 DONE                                                                                                                                       
o Con un tablero                                                                                                                                                    DONE
o codigoPartida es un número aleatorio para identificar la partida                                                                                                  DONE
o La creación de la partida es responsabilidad de clase Program.
o tiempoPartida es el tiempo de duración de la partida                                                                                                              DONE
o tiempoInicioPartida, es la hora en la que inicia la partida y es configurado por el método JugarPartida()                                                         DONE
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Un Jugador se crea de la siguiente manera:                                                                                                                        SECTION DONE
o Con un nombre                                                                                                                                                     DONE
o puntaje esta dado por el número de partidas ganadas, cada partida ganada otorga 100 puntos                                                                        DONE
o cantidadPartidasGanadas, es el número de partidas ganadas por un jugador                                                                                          DONE
o GuardarPuntaje(), actualiza puntaje y cantidadPartidasGanadas                                                                                                     DONE
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Un Tablero se crea de la siguiente manera:
o Con 32 piezas                                                                                                                                                     DONE
 2 Reyes: 1 blanco, 1 negro
 2 Reinas: 1 blanca, 1 negra
 4 Torres: 2 blancas, 2 negras
 4 Alfiles: 2 blancos, 2 negros
 4 Caballos: 2 blancos, 2 negros
 16 Peones: 8 blancos, 8 negros
o codigoTablero, es un número aleatorio para identificar el tablero                                                                                                 DONE
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Una Pieza se crea de la siguiente manera:
o codigoPieza, es un número aleatorio para identificar cada una de las 32 piezas                                                                                    DONE
o color, blanco o negro                                                                                                                                             DONE
o tamaño, puede ser un valor constante, puede ser estático                                                                                                          DONE
o posición, inicialmente cuando se crea la pieza es la posición por defecto de la pie en el tablero de ajedrez
o estado, inicialmente cuando se crea la pieza es verdadero (esta en juego), false es para cuando a la pieza ha sido capturada por el oponente 
o MoverPieza, es una acción que pueden realizar todas las piezas, pero que cada pieza realiza de forma diferente. Este método actualiza la propiedad posición.

El programa debe tener un menú:
- Crear jugadores                                                                                                                                                   DONE
- Crear partidas
- Y mostrar la información de un jugador seleccionado, y la información de una partida
seleccionada (jugadores, codigoPartida, tiempoInicioPartida).
- Salir del juego                                                                                                                                                   DONE
 */

namespace Point3_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varibles de manejo, SWitches, Ciclo Do - While, var tipo string
            int i = 0;
            bool flag = false;
            string n;

            //Testeo Fuera del Switch
            Player player1 = new Player("Elen");
            Player player2 = new Player("Alan");
            Player[] playersa = new Player[2] { player1, player2 };

            Game game1 = new Game(playersa);
            playersa[0].Color = true;
            playersa[1].Color = false;
            game1.PlayGame();
            //Fin testeo

            //Declaracion de las listas
            List<Player> players = new List<Player>();
            List<Game> games = new List<Game>();

            do
            {
                Console.WriteLine("Welcome Ladys and Gentleman this is Amaateur Grand Chess Tournament");
                Console.WriteLine("1)\tCreate Players\n2)\tCreate Games\n3)\tShow Info\n4)\tExit");
                i = Convert.ToInt32(Console.ReadLine());
                switch(i)
                {
                    case 1:
                        //Se inicializa al jugador
                        Player player;
                        n = Console.ReadLine();
                        player = new Player (n);
                        //Anexa a lista jugadores
                        players.Add(player);
                        player.Show();
                        Console.WriteLine();
                        break;

                    case 2:
                        //Se crea el ArrayList al cual se anexan los jugadores
                        ArrayList playersList = new ArrayList(2);
                        //Espacio en el que se deben agragaer los jugadores
                        //Todavia debe de cambiarse el Add
                        playersList.Add(player1);
                        playersList.Add(player2);
                        //Se crea un nuevo arreglo Player y se copian los elementos del ArrayList a una matriz de tipo especifico
                        Player[] obj = (Player[])playersList.ToArray(typeof(Player));
                        //Aca Se crea la instancia de Game
                        Game game;
                        //Aca se debe agregar elementos de la lista de jugadores a un arreglo que despues tomara la instancia de Game
                        game = new Game(obj);
                        //Anexa game a la lista games
                        games.Add(game);
                        //game llama a jugar para crear la partida
                        game.PlayGame();
                        Console.WriteLine();
                        break;
                        //
                    case 3:
                        break;

                    case 4:
                        //Salida del programa
                        Console.Write("You have exited the program, Sayonara");
                        flag = true;
                        break;

                }
            } while (!flag);
        }
    }
}