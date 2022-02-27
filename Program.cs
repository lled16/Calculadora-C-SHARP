using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja realizar ? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------------------------");

            /* Poderia fazer usando IFS, mas não seria saudável para o código, nesse caso o SWITCH funciona bem */

            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Console.ReadKey();

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é: {resultado}"); /* Essa é uma segunda forma de exibir o resultado em tela */

            //Outras formas de fazer -> 
            // Console.WriteLine("O resultado da soma é: " + resultado);
            //  Console.WriteLine($"O resultado da soma é: {v1 + v2}"); /* Essa é uma terceira forma de exibir o resultado em tela */
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2)); /* Essa é uma quarta forma de exibir o resultado em tela */
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da Subtração é: {resultado}");
            Console.ReadKey();
            Menu();


        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da Subtração é: {resultado}");
            Console.ReadKey();
            Menu();


        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da Subtração é: {resultado}");
            Console.ReadKey();
            Menu();


        }


    }
}
