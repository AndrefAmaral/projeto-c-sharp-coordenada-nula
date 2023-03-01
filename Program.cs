using System;

namespace Coordenada_Nula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite os valores de x e y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0  && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else
                {
                    Console.WriteLine("Terceiro");
                }

                Console.WriteLine("Digite os valores de x e y");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
