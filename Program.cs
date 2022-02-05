using System;

namespace ExercicioContadorInstrucaoBreak
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numeroInicial;
            int numeroFinal;

            Console.WriteLine("Digite o numero inicial da contagem: ");
            numeroInicial = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o numero final da contagem: ");
            numeroFinal = Convert.ToInt32(Console.ReadLine());

            while (true)
            {   
                if (numeroInicial > numeroFinal)
                {
                    break;
                }

                Console.WriteLine($"{numeroInicial}");

                numeroInicial = numeroInicial + 1;
                                
            }

        }
    }
}
