using System;
using System.Collections.Generic;

/*
 * Realizar un programa en C#, que permita implementar un juego de ajedrez, según el diagrama de clases a continuación...
Enunciados:
- Una Partida se crea de la siguiente manera:
o Con dos jugadores
o Con un tablero
o codigoPartida es un número aleatorio para identificar la partida
o La creación de la partida es responsabilidad de clase Program.
o tiempoPartida es el tiempo de duración de la partida
o tiempoInicioPartida, es la hora en la que inicia la partida y es configurado por el método JugarPartida()
- Un Jugador se crea de la siguiente manera:
o Con un nombre
o puntaje esta dado por el número de partidas ganadas, cada partida ganada otorga 100 puntos
o cantidadPartidasGanadas, es el número de partidas ganadas por un jugador
o GuardarPuntaje(), actualiza puntaje y cantidadPartidasGanadas

- Un Tablero se crea de la siguiente manera:
o Con 32 piezas
 2 Reyes: 1 blanco, 1 negro
 2 Reinas: 1 blanca, 1 negra
 4 Torres: 2 blancas, 2 negras
 4 Alfiles: 2 blancos, 2 negros
 4 Caballos: 2 blancos, 2 negros
 16 Peones: 8 blancos, 8 negros
o codigoTablero, es un número aleatorio para identificar el tablero

- Una Pieza se crea de la siguiente manera:
o codigoPieza, es un número aleatorio para identificar cada una de las 32 piezas
o color, blanco o negro
o tamaño, puede ser un valor constante, puede ser estático
o posición, inicialmente cuando se crea la pieza es la posición por defecto de la pie en el tablero de ajedrez
o estado, inicialmente cuando se crea la pieza es verdadero (esta en juego), false es para cuando a la pieza ha sido capturada por el oponente 
o MoverPieza, es una acción que pueden realizar todas las piezas, pero que cada pieza realiza de forma diferente. Este método actualiza la propiedad posición.

El programa debe tener un menú:
- Crear jugadores
- Crear partidas
- Y mostrar la información de un jugador seleccionado, y la información de una partida
seleccionada (jugadores, codigoPartida, tiempoInicioPartida).
- Salir del juego
 */

namespace Point3_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool flag = false;
            string n;

            Player player = new Player("Elen");
            Player player1 = new Player("Alan");
            Player[] players = new Player[2] { player, player1 };

            Game game = new Game(players);
            players[0].Color = true;
            players[1].Color = false;
            game.CodeCreation();
            game.Show();

            List<Player> players1 = new List<Player>();
            List<Game> games = new List<Game>();
            game.GameTime();
            Console.WriteLine(game.MatchTime);

            do
            {
                Console.WriteLine("Welcome Ladys and Gentleman this is Amaateur Grand Chess Tournament");
                i = Convert.ToInt32(Console.ReadLine());
                switch(i)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                }
            } while (!flag);
        }
    }
}