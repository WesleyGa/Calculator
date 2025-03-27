
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
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("----------------");
            Console.WriteLine("Escolha uma opção: ");

            ushort resultado = ushort.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: System.Environment.Exit(0); break; //encerra imediatamente a execução do programa.
                default: Menu(); break; //O usuário volta ao menu se inserir uma opção inválida.
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
            // Forma alternativa de calcular a soma, entre muitas outras: Console.WriteLine($"O reultado da soma é {v1 + v2}"); 

            Console.WriteLine($"O resultado da soma é {resultado}");


            Console.ReadKey();// Pausa a execução para que o usuário veja o resultado

            Menu(); // Retorna ao menu principal após exibir o resultado.
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

        static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Aumentar um valor em X%");
            Console.WriteLine("2 - Diminuir um valor em X%");
            Console.WriteLine("3 - Calcular X% de um valor");
            Console.WriteLine("4 - Descobrir o valor total a partir de uma porcentagem (Ex: 221 é 30% de quanto?)");
            Console.WriteLine("5 - Voltar ao menu");
            Console.WriteLine("---------------------------------------------");

            ushort opcao = ushort.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AdicionarPorcentagem(); break;
                case 2:
                    SubtrairPorcentagem(); break;
                case 3:
                    CalculoValorPercentual(); break;
                case 4:
                    EncontrarValorOriginal(); break;
                case 5: Menu(); break;

                default: Menu(); break;
            }

            // Exemplo: 1052 + 10%
            void AdicionarPorcentagem()
            {
                Console.Clear();

                Console.WriteLine("Informe o valor ao qual deseja adicionar uma porcentagem: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Agora, digite a porcentagem a ser adicionada: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 + (v1 * v2 / 100);
                Console.WriteLine($"O valor após aplicar a porcentagem é: {resultado}");

                Console.ReadKey();

                Porcentagem();
            }

            // Exemplo: 1052 - 10%
            void SubtrairPorcentagem()
            {
                Console.Clear();

                Console.WriteLine("Informe o valor ao qual deseja subtrair uma porcentagem: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Agora, digite a porcentagem a ser subtraída: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 - (v1 * v2 / 100);
                Console.WriteLine($"O valor após subtrair a porcentagem é: {resultado}");
                Console.ReadKey();
                Porcentagem();
            }

            // Exemplo: 10% de 1052
            void CalculoValorPercentual()
            {
                Console.Clear();

                Console.WriteLine("Informe o valor ao qual deseja descobrir a porcentagem: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Agora, digite a porcentagem: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 * v2 / 100;
                Console.WriteLine($"{v2}% de {v1} é: {resultado}");
                Console.ReadKey();
                Porcentagem();
            }

            // Exemplo: 221 é 30% de qual valor total?"
            void EncontrarValorOriginal()
            {
                Console.Clear();
                Console.WriteLine("Digite o valor parcial (parte do total): ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Agora, informe a porcentagem que esse valor representa: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = (v1 / v2) * 100;
                Console.WriteLine($"Se {v1} representa {v2}%, então 100% equivale a {resultado}");
                Console.ReadKey();
                Porcentagem();


            }
        }
    }
}