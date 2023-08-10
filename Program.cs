using System;

namespace _3EnRaya
{
    class Program
    {
       

        static void mostrarTablero(ref string [,]tablero)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }


        static bool comprobarJuego (string[,] tablero, ref int contadorMov,ref string jugador1, ref string jugador2, ref bool finPartida)
        {
           

                if (tablero[0, 0] == "O" && tablero[0, 1] == "O" && tablero[0, 2] == "O" ||
                        tablero[1, 0] == "O" && tablero[1, 1] == "O" && tablero[1, 2] == "O" ||
                        tablero[2, 0] == "O" && tablero[2, 1] == "O" && tablero[2, 2] == "O" ||
                        tablero[0, 0] == "O" && tablero[1, 0] == "O" && tablero[2, 0] == "O" ||
                        tablero[0, 1] == "O" && tablero[1, 1] == "O" && tablero[2, 1] == "O" ||
                        tablero[0, 2] == "O" && tablero[1, 2] == "O" && tablero[2, 2] == "O" ||
                        tablero[0, 2] == "O" && tablero[1, 1] == "O" && tablero[2, 0] == "O" ||
                        tablero[0, 0] == "O" && tablero[1, 1] == "O" && tablero[2, 2] == "O")

                {

                    Console.WriteLine(jugador1 + " has ganado!");
                    finPartida = true;
                    mostrarTablero(ref tablero);
                    





                }

                else if (tablero[0, 0] == "X" && tablero[0, 1] == "X" && tablero[0, 2] == "X" ||
                    tablero[1, 0] == "X" && tablero[1, 1] == "X" && tablero[1, 2] == "X" ||
                    tablero[2, 0] == "X" && tablero[2, 1] == "X" && tablero[2, 2] == "X" ||
                    tablero[0, 0] == "X" && tablero[1, 0] == "X" && tablero[2, 0] == "X" ||
                    tablero[0, 1] == "X" && tablero[1, 1] == "X" && tablero[2, 1] == "X" ||
                    tablero[0, 2] == "X" && tablero[1, 2] == "X" && tablero[2, 2] == "X" ||
                    tablero[0, 2] == "X" && tablero[1, 1] == "X" && tablero[2, 0] == "X" ||
                    tablero[0, 0] == "X" && tablero[1, 1] == "X" && tablero[2, 2] == "X")
                {

                    Console.WriteLine(jugador2 + " has ganado!");

                    finPartida = true;
                    mostrarTablero(ref tablero);
                    



                }

                else if (contadorMov>= 9)

                {
                    Console.WriteLine("Terminó la partida");
                    finPartida = true;
                   
                    mostrarTablero(ref tablero);
                    

                }






            return finPartida;
               
        }

        static public string turnoJugador1(ref string[,] tablero, ref int contadorMov, string posicion)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jugador 1 introduce ficha en posicion del 1 al 9");

                for (int i = 0; i < 1; i++)
                {

                for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        posicion = Console.ReadLine();
                        if (posicion == "1")
                        {

                            posicion = tablero[0, 0] = "O";
                            break;

                        }

                        if (posicion == "2")
                        {

                            posicion = tablero[0, 1] = "O";
                            break;

                        }

                        if (posicion == "3")
                        {

                            posicion = tablero[0, 2] = "O";
                            break;

                        }

                        if (posicion == "4")
                        {

                            posicion = tablero[1, 0] = "O";
                            break;

                        }

                        if (posicion == "5")
                        {

                            posicion = tablero[1, 1] = "O";
                            break;

                        }

                        if (posicion == "6")
                        {

                            posicion = tablero[1, 2] = "O";
                            break;

                        }

                        if (posicion == "7")
                        {

                            posicion = tablero[2, 0] = "O";
                            break;

                        }

                        if (posicion == "8")
                        {

                            posicion = tablero[2, 1] = "O";
                            break;

                        }

                        if (posicion == "9")
                        {

                            posicion = tablero[2, 2] = "O";
                            break;

                        }

           


                    }

                
               
            }

            contadorMov++;
            return posicion;
        }
        static public string turnoJugador2(ref string[,] tablero,ref int contadorMov, string posicion)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jugador 2 introduce ficha en posicion del 1 al 9");

                    for (int i = 0; i < 1; i++)
                    {
                     
                        for (int j = 0; j < tablero.GetLength(1); j++)
                        {
                             posicion = Console.ReadLine();



                            if (posicion == "1")
                            {

                                posicion = tablero[0, 0] = "X";
                                break;

                            }

                            if (posicion == "2")
                            {

                                posicion = tablero[0, 1] = "X";
                                break;

                            }

                            if (posicion == "3")
                            {

                                posicion = tablero[0, 2] = "X";
                                break;

                            }

                            if (posicion == "4")
                            {

                                posicion = tablero[1, 0] = "X";
                                break;
                            }

                            if (posicion == "5")
                            {

                                posicion = tablero[1, 1] = "X";
                                break;
                            }

                            if (posicion == "6")
                            {

                                posicion = tablero[1, 2] = "X";
                                break;
                            }

                            if (posicion == "7")
                            {

                                posicion = tablero[2, 0] = "X";
                                break;
                            }

                            if (posicion == "8")
                            {

                                posicion = tablero[2, 1] = "X";
                                break;
                            }

                            if (posicion == "9")
                            {

                                posicion = tablero[2, 2] = "X";
                                break;
                            }
                        }

                    }
            contadorMov++;
            return posicion;
            
            }


        static public bool casillaLibre(ref string[,] tablero,ref bool finPartida)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tablero[i, j].Contains("."))
                    {
                        finPartida = false;
                        
                    }

                    else { finPartida = true; Console.WriteLine("Casilla ocupada.Comienza de nuevo"); }
                    

                }

            }

            return finPartida;
        }

        static void Main(string[] args)
        {

            /*¿Qué pasos debemos seguir?

            1º) Crear un tablero de juego 3x3

            2º) Ir rellenando ese tablero para inicializarlo. La matriz estará compuesta por caracteres.

            3º) Vamos a obtener la posición donde queremos poner nuestra 'X' o 'O'

            4º) Para realizar el punto 3, debemos comprobar si podemos escribir en esa casilla

            5º) Conocer el turno del jugador

            6º) Comprobar quién ha ganado*/


            //1 Crear tablero-matriz 3x3. Crear contador de movimientos

            string[,] tablero = new string[3, 3] { { ".", ".", "." }, { ".", ".", "." }, { ".", ".", "." } };

            bool finPartida = false;

            int contadorMov = 0;

            string posicion="";

            //2 Pedir nombre a los jugadores y asignar O a J1 y X a J2

            Console.WriteLine("Jugador 1 introduce tu nombre. Tus fichas serán 'O'");
            string jugador1 = Console.ReadLine();
            Console.WriteLine("Jugador 2 introduce tu nombre. Tus fichas serán 'X'");
            string jugador2=Console.ReadLine();

            //3 renombrar posiciones y Rellenar array

    
             for (int i = 0; i <= 9; i++)
            {
                mostrarTablero(ref tablero);
     
                Console.WriteLine(jugador1 + " Tu turno");
                turnoJugador1(ref tablero,ref contadorMov, posicion);
                //casillaLibre(ref tablero,ref finPartida);
                //if (finPartida == true) { break; };
                mostrarTablero(ref tablero);

                Console.WriteLine(jugador2 + " Tu turno");
                turnoJugador2(ref tablero,ref contadorMov, posicion);
                //casillaLibre(ref tablero,ref finPartida);
                //if (finPartida == true) { break; };
                
                comprobarJuego(tablero, ref contadorMov, ref jugador1, ref jugador2, ref finPartida);

                if (finPartida == true) { break; };
                Console.Clear();
            }


            //4 Fin juego posiciones en switch, caso default 9 movimientos maximo. 8 formas de ganar


            Console.ReadKey();

            

         


        }

    }
}

