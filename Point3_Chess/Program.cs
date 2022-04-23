using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Realizar un programa en C#, que permita implementar un juego de ajedrez, según el diagrama de clases a continuación...
Enunciados:
- Una Partida se crea de la siguiente manera:                                                                                                                       SECTION DONE
o Con dos jugadores                                                                                                                                                 DONE                                                                                                                                       
o Con un tablero                                                                                                                                                    DONE
o codigoPartida es un número aleatorio para identificar la partida                                                                                                  DONE
o La creación de la partida es responsabilidad de clase Program.                                                                                                    DONE
o tiempoPartida es el tiempo de duración de la partida                                                                                                              DONE
o tiempoInicioPartida, es la hora en la que inicia la partida y es configurado por el método JugarPartida()                                                         DONE
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Un Jugador se crea de la siguiente manera:                                                                                                                        SECTION DONE
o Con un nombre                                                                                                                                                     DONE
o puntaje esta dado por el número de partidas ganadas, cada partida ganada otorga 100 puntos                                                                        DONE
o cantidadPartidasGanadas, es el número de partidas ganadas por un jugador                                                                                          DONE
o GuardarPuntaje(), actualiza puntaje y cantidadPartidasGanadas                                                                                                     DONE
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Un Tablero se crea de la siguiente manera:                                                                                                                        SECTION DONE
o Con 32 piezas                                                                                                                                                     DONE
 2 Reyes: 1 blanco, 1 negro                                                                                                                                        DONE
 2 Reinas: 1 blanca, 1 negra                                                                                                                                       DONE
 4 Torres: 2 blancas, 2 negras                                                                                                                                     DONE
 4 Alfiles: 2 blancos, 2 negros                                                                                                                                    DONE
 4 Caballos: 2 blancos, 2 negros                                                                                                                                   DONE
 16 Peones: 8 blancos, 8 negros                                                                                                                                    DONE
o codigoTablero, es un número aleatorio para identificar el tablero                                                                                                 DONE
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Una Pieza se crea de la siguiente manera:
o codigoPieza, es un número aleatorio para identificar cada una de las 32 piezas                                                                                    DONE
o color, blanco o negro                                                                                                                                             DONE
o tamaño, puede ser un valor constante, puede ser estático                                                                                                          DONE
o posición, inicialmente cuando se crea la pieza es la posición por defecto de la pieza en el tablero de ajedrez                                                    DONE 
o estado, inicialmente cuando se crea la pieza es verdadero (esta en juego), false es para cuando a la pieza ha sido capturada por el oponente                      DONE
o MoverPieza, es una acción que pueden realizar todas las piezas, pero que cada pieza realiza de forma diferente. Este método actualiza la propiedad posición.      
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
El programa debe tener un menú:
- Crear jugadores                                                                                                                                                   DONE
- Crear partidas                                                                                                                                                    DONE
- Y mostrar la información de un jugador seleccionado, y la información de una partida seleccionada (jugadores, codigoPartida, tiempoInicioPartida).                
- Salir del juego                                                                                                                                                   DONE
 */

namespace Point3_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varibles de manejo, SWitches, Ciclo Do - While, var tipo string
            int i = 0, j = 0;
            bool flag = false;
            string n;

            //Testeo crear partidas 
            //Player player1 = new Player("Elen");
            //Player player2 = new Player("Alan");
            //Player[] playersa = new Player[2] { player1, player2 };
            //Game game1 = new Game(playersa);
            //game1.PlayGame();
            //game1.ReferenceT();
            //Console.WriteLine();
            //Fin testeo            

            //Declaracion de las listas
            List<Player> players = new List<Player>();
            List<Game> games = new List<Game>();

            do
            {
                Console.WriteLine("Welcome Ladys and Gentleman this is Amateur Grand Chess Tournament\n");
                Console.WriteLine("1)\tCreate Players\n2)\tCreate Games\n3)\tShow Info\n4)\tExit");
                Console.Write("\tPick and option:\t");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());

                    if ((i > 0 && i < 4.1) == true)
                        Console.WriteLine();
                }
                catch(FormatException error)
                {
                    Console.WriteLine();
                    Console.WriteLine(error.Message);
                    Console.WriteLine();
                }
                Console.WriteLine();
                switch(i)
                {
                    case 1:
                        //Se inicializa a player
                        Player player;
                        Console.Write("Add Player Name:\t");
                        if(players.Count < 1)
                        {
                            n = Console.ReadLine().ToUpper();
                            Console.WriteLine();
                            player = new Player(n);
                            //Anexa a lista players & se visualiza
                            players.Add(player);
                            player.Show();
                        }
                        else
                        {
                            n = Console.ReadLine().ToUpper();
                            Console.WriteLine();
                            for (j = 0; j < players.Count; j++)
                            {
                                if (players[j].Name.Contains(n))
                                {
                                    Console.WriteLine("There's alredy a player with that name");
                                    Console.WriteLine("Tray again\n");
                                }
                                else
                                {
                                    player = new Player(n);
                                    //Anexa a lista players & se visualiza
                                    players.Add(player);
                                    player.Show();
                                }
                            }
                        }
                        break;

                    case 2:
                        //Se crea el ArrayList al cual se anexan los jugadores
                        ArrayList playersList = new ArrayList(2);

                        if (players.Count < 2)
                        {
                            Console.WriteLine("None enough players, require minimum 2\n");
                            Console.WriteLine(players.Count);
                        }
                        else
                        {
                            i = Convert.ToInt32(Console.ReadLine());
                            playersList.Add(players[i]);
                            j = Convert.ToInt32(Console.ReadLine());
                            if (i == j)
                            {
                                Console.WriteLine("You cannot add the same player twice");
                                Console.WriteLine();
                                break;                                
                            }
                            else
                            {
                                playersList.Add(players[j]);
                            }

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
                        }                        
                        break;
                        //
                    case 3:
                        //Anexar info de partidas y jugadores

                        break;

                    case 4:
                        //Salida del programa
                        Console.Write("You have exited the program, Sayonara\n");
                        flag = true;
                        break;
                }
            } while (!flag);
        }
    }
}