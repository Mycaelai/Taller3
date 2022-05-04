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
- Una Pieza se crea de la siguiente manera:                                                                                                                         SECTION DONE
o codigoPieza, es un número aleatorio para identificar cada una de las 32 piezas                                                                                    DONE
o color, blanco o negro                                                                                                                                             DONE
o tamaño, puede ser un valor constante, puede ser estático                                                                                                          DONE
o posición, inicialmente cuando se crea la pieza es la posición por defecto de la pieza en el tablero de ajedrez                                                    DONE 
o estado, inicialmente cuando se crea la pieza es verdadero (esta en juego), false es para cuando a la pieza ha sido capturada por el oponente                      DONE
o MoverPieza, es una acción que pueden realizar todas las piezas, pero que cada pieza realiza de forma diferente. Este método actualiza la propiedad posición.      Done
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
El programa debe tener un menú:                                                                                                                                     SECTION DONE
- Crear jugadores                                                                                                                                                   DONE
- Crear partidas                                                                                                                                                    DONE
- Y mostrar la información de un jugador seleccionado, y la información de una partida seleccionada (jugadores, codigoPartida, tiempoInicioPartida).                DONE
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
            Player player1 = new Player("Elen");
            Player player2 = new Player("Alan");
            Player[] playersa = new Player[2] { player1, player2 };
            Game game1 = new Game(playersa);
            game1.PlayGame();
            game1.ReferenceT();
            Console.WriteLine();
            //Fin testeo

            //Declaracion de las listas
            List<Player> players = new List<Player>();
            List<Game> games = new List<Game>();

            do
            {
                Console.WriteLine("Welcome Ladys and Gentleman this is Amateur Grand Chess Tournament\n");
                Console.WriteLine("1)\tCreate Players\n2)\tCreate Games\n3)\tShow Info\n4)\tExit");
                Console.Write("\tPick and option:\t");
                i = Convert.ToInt32(Console.ReadLine());

                switch(i)
                {
                    case 1:
                        //Se inicializa a player
                        Player player;
                        Console.Write("\nAdd Player Name:\t");
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
                                if (!players[j].Name.Contains(n))
                                {
                                    player = new Player(n);
                                    //Anexa a lista players & se visualiza
                                    players.Add(player);
                                    player.Show();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("There's alredy a player with that name");
                                    Console.WriteLine("Tray again\n");
                                }
                                n = "";                               
                        }
                        break;

                    case 2:
                        //Se crea el ArrayList al cual se anexan los jugadores
                        ArrayList playersList = new ArrayList(2);

                        if (players.Count < 2)
                        {
                            Console.WriteLine("\nNone enough players, require minimum 2");
                            Console.WriteLine("Current amount of players: " + players.Count + "\n");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer name list:");
                            j = 0;
                            foreach (Player item in players)
                            {
                                Console.WriteLine($" {j + 1}) Player name: " + item.Name);
                                j++;
                            }
                            Console.Write("\nAdd White player:\t");
                            i = Convert.ToInt32(Console.ReadLine()) - 1;
                            playersList.Add(players[i]);
                            Console.Write("Add Black player:\t");
                            j = Convert.ToInt32(Console.ReadLine()) - 1;
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
                        if (players.Count == 0 || games.Count == 0)
                        {
                            Console.WriteLine("\nThere isn't any player added in the tournamet yet or any game play till the moment\n");
                        }
                        else
                        {
                            Console.WriteLine("\nVisualize options:\n\t1) Players\n\t2) Games");
                            Console.Write("\tPick an option:\t");
                            i = Convert.ToInt32(Console.ReadLine());
                            //Anexar info de partidas y jugadores
                            switch (i)
                            {
                                case 1:
                                    Console.WriteLine("\nPlayer name list:");
                                    j = 0;
                                    foreach (Player item in players)
                                    {
                                        Console.WriteLine($" {j + 1}) Player name: " + item.Name);
                                        j++;
                                    }

                                    Console.Write("\nPlease add the player position you want to check: ");
                                    j = Convert.ToInt32(Console.ReadLine()) - 1;
                                    players[j].Show();
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    Console.WriteLine("\nPlayer name list:");
                                    j = 0;
                                    foreach (Game item in games)
                                    {
                                        Console.WriteLine($" {j + 1}) Game: " + item.GameCode);
                                        item.ShowName();
                                        j++;
                                    }

                                    Console.Write("\nAdd the game position you want to check: ");
                                    j = Convert.ToInt32(Console.ReadLine()) - 1;
                                    games[j].Show();
                                    games[j].Results();
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        break;

                    case 4:
                        //Salida del programa
                        Console.Write("\nYou have exited the program, Sayonara\n");
                        flag = true;
                        break;
                }
            } while (!flag);
        }
    }
}