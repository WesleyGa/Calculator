
using System;


namespace Calculator
{
    class Program
    {

        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicacão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------");
            Console.WriteLine("Escolha uma opção: ");

            ushort resultado = ushort.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; //encerra imediatamente a execução do programa.
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            // Ao executar limpa o console
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            // O ' Console.ReadLine()' retorna uma string por isso é preciso fazer a conversão.
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = v1 + v2;

            // Console.WriteLine("O reultado da soma é " + resultado);
            // Interpolação de String. 
            Console.WriteLine($"O reultado da soma é {resultado}");
            // Console.WriteLine($"O reultado da soma é {v1 + v2}"); 


            Console.ReadKey();/*Um método que espera a entrada de um caractere do usuário no console. 
                              Ele pausa a execução do programa até que uma tecla seja pressionada.*/

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            //Pula uma linha
            Console.WriteLine("");

            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é : {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 / v2;
            Console.Write("O resultado da divisão é " + resultado);

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é " + resultado);
            Console.ReadKey();
            Menu();
        }

    }
}