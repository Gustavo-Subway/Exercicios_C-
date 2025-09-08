using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 0;
            int e = 0;
            string n;

            Random rnd = new Random();


            while (true)

            {
                Console.WriteLine("Quer jogar contra humano ou máquina? (h/m)");
                string m = Console.ReadLine();
                if (m == "h")

                    Console.WriteLine("Nome 1");
                string s = Console.ReadLine();
                Console.WriteLine("Nome ");
                n = Console.ReadLine();
                Console.WriteLine("Digite 1 para Pedra, 2 para Papel, 3 para Tesoura:");
                int a = int.Parse(Console.ReadLine());

                int b;
                if (m == "h")
                {
                    Console.WriteLine("Digite 1 para Pedra, 2 para Papel, 3 para Tesoura:");
                    b = int.Parse(Console.ReadLine());
                }
                else
                {
                    b = rnd.Next(1, 4);
                    Console.WriteLine("A máquina escolheu: \n" + b);
                }

                if (a < 1 || a > 3)
                    Console.WriteLine("Jogador 1 escolheu errado: ");
                if (b < 1 && b > 3)
                    Console.WriteLine("Jogador 2 escolheu errado: ");

                if ((a == 1 && b == 3) || (a == 2 && b == 1) || (a == 3 && b == 2))
                    v1++;
                else if (a != b)
                    v2++;
                else
                    e++;

                Console.WriteLine($"Vitórias do {n}: {v1}");
                if (m == "h")
                    Console.WriteLine($"Vitórias do {s}: {v2}");
                if (m == "m")
                    Console.WriteLine($"Vitórias da Maquina: {v2}");
                Console.WriteLine($"Empates: {e}");


                Console.WriteLine("Quer jogar outra rodada? (s ou n)");
                string r = Console.ReadLine();
                if (r != "s")
                    break;
            }
            Console.ReadKey();
        }
    }
}
