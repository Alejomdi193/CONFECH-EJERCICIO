

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******");
            Console.WriteLine("Ejercicio CONFECH");
            Console.WriteLine("******\n");

            Console.Write("Ingrese el numero de universidades: ");
            int u = Convert.ToInt32(Console.ReadLine());

            int Aceptan = 0;
            int Rechazan = 0;
            int Empate = 0;

            for (int i = 0; i < u; i++)
            {
                Console.WriteLine($"Universidad {i + 1}:");
                int votosAceptando = 0;
                int votosRechazando = 0;
                int votosBlancos = 0;
                int votosNulos = 0;

                char voto;
                do
                {
                    Console.WriteLine("\nIngrese su voto");
                    Console.Write("(A para aceptar, R para rechazar, N para nulo, B para blanco, X para finalizar): ");
                    voto = Char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine("\n");


                    switch (voto)
                    {
                        case 'A':
                            votosAceptando++;
                            break;
                        case 'R':
                            votosRechazando++;
                            break;
                        case 'N':
                            votosNulos++;
                            break;
                        case 'B':
                            votosBlancos++;
                            break;
                        case 'X':
                            break;
                        default:
                            Console.WriteLine("Voto no valido");
                            break;
                    }

                } while (voto != 'X');



                if (votosAceptando > votosRechazando)
                {
                    Console.WriteLine("La universidad acepta la propuesta\n");
                    Aceptan++;
                }
                else if (votosRechazando > votosAceptando)
                {
                    Console.WriteLine("La universidad rechaza la propuesta\n");
                    Rechazan++;
                }
                else
                {
                    Console.WriteLine("Empate en la universidad\n");
                    Empate++;
                }

                Console.WriteLine($"\nResultados para Universidad {i + 1}:");
                Console.WriteLine($"Votos a favor: {votosAceptando}");
                Console.WriteLine($"Votos rechazados: {votosRechazando}");
                Console.WriteLine($"Votos en blanco: {votosBlancos}");
                Console.WriteLine($"Votos nulos: {votosNulos}");
            }


            Console.WriteLine("\n******");
            Console.WriteLine("Resultados finales");
            Console.WriteLine("******\n");


            Console.WriteLine($"Numero de univeridades {u}");
            Console.WriteLine($"Universidades que aceptan la propuestaa: {Aceptan}");
            Console.WriteLine($"Universidades que rechazan la propuesta: {Rechazan}");
            Console.WriteLine($"Universidades con empate la propuesta : {Empate}");
        }
    }
}
