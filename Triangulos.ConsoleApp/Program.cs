using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor_x, valor_y, valor_z;

            Console.WriteLine("----- TIPOS DE TRIÂNGULOS -----");

            while (true)
            {
                Console.WriteLine("\nInfome a operação desejada:\n\n[T] Para tipo de triângulo\n[S] Para saír");

                char operacao;

                operacao = char.Parse(Console.ReadLine());

                if (operacao == 'T' || operacao == 't')
                {
                    Console.WriteLine("\nInforme o valor do lado x:");
                    valor_x = float.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor do lado y:");
                    valor_y = float.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor do lado z:");
                    valor_z = float.Parse(Console.ReadLine());

                    if (valor_x + valor_y > valor_z && valor_x + valor_z > valor_y && valor_y + valor_z > valor_x)
                    {
                        if (valor_x == valor_y && valor_y == valor_z)
                            Console.WriteLine("\nTriângulo Equilátero");
                        else if (valor_x == valor_y || valor_y == valor_z)
                            Console.WriteLine("\nTriângulo Isóceles");
                        else if (valor_x != valor_y && valor_y != valor_z && valor_x != valor_z)
                            Console.WriteLine("\nTriângulo Escaleno");
                    }
                    else
                        Console.WriteLine("\nTriângulo Inválido");
                }
                if (operacao == 'S' || operacao == 's')
                    break;

                Console.ReadLine();
            }
        }
    }
}

