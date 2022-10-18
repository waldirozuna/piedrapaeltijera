using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapeloTijeras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piedra papel o tijeras");
            while (true) 
            {
                Console.WriteLine("¿Estas listo?");
                Console.WriteLine("Iniciemos!!");

                var eleccionSeleccionada = OpcionSeleccionada();
                
                var tuEleccion = char.Parse(eleccionSeleccionada);
                Console.WriteLine($"Tu seleccionastes: {tuEleccion}");
                
                
                var eleccionOponente = ObtenEleccionOponente();
                Console.WriteLine($"Yo seleccione: {eleccionOponente }");

                DecidirGanador(eleccionOponente, tuEleccion);

                Console.WriteLine("¿Quieres jugar otra vez?");
                Console.WriteLine("Ingresa SI para jugar otra vez o presiona una tecla para finalizar...");

                var JugarOtraVez = Console.ReadLine(); 
                if(JugarOtraVez.ToLower() == "si")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }

        static string OpcionSeleccionada()
        {
            Console.WriteLine("Elige R, P o T: [R]Piedra, [P]apel o [T]ijeras");

            var eleccionSeleccionada = Console.ReadLine();

            if (eleccionSeleccionada?.ToLower() != "r" && eleccionSeleccionada?.ToLower() != "p" && eleccionSeleccionada?.ToLower() != "t")
            {
                Console.WriteLine("Por favor selecciones solo una letra: R, P o T ");
                eleccionSeleccionada = OpcionSeleccionada();
            }

            return eleccionSeleccionada.ToUpper();
        }
        static char ObtenEleccionOponente()
        {
            char[] opciones = new char[] { 'R', 'P', 'T' };
            Random ramdom = new Random();
            int randomindex = ramdom.Next(0, opciones.Length);
            return opciones[randomindex];
        }

        static void DecidirGanador(char eleccionOponente, char tuEleccion)
        {
            if (eleccionOponente == tuEleccion)
            {
                Console.WriteLine("Empate");
                return;
            }
                
            switch (tuEleccion)
            {
                case 'R':
                case 'r':
                    if (eleccionOponente == 'P')
                        Console.WriteLine("Papel vence a Piedra, Yo Gano!");
                    else if (eleccionOponente == 'T')
                        Console.WriteLine("Piedra vence a Tijeras, Tu ganas!");
                    break;
                case 'T':
                case 't':
                    if (eleccionOponente == 'P')
                        Console.WriteLine("Tijeras vence a Papel, Tu ganas!");
                    else if (eleccionOponente == 'R')
                        Console.WriteLine("Piedra vence a Tijeras, Yo Gano!");
                    break;
                case 'P':
                case 'p':
                    if (eleccionOponente == 'T')
                        Console.WriteLine("Tijeras vence a Papel, Yo Gano!");
                    else if (eleccionOponente == 'R')
                        Console.WriteLine("Papel vence a Piedra, Tu ganas!");
                    break;

            }

        }

    }
}


