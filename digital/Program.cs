using System;

namespace digital
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;

            for (int i = 0; i < numero; i++)
            {
                System.Console.WriteLine($"Renan {i}");

                Classe c1 = new Classe();

                c1.setNome("Renan Berti");
                System.Console.WriteLine(c1.getNome());


            }
        }
    }
}
