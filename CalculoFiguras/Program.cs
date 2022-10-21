using System;
using System.Collections.Generic;
using System.Globalization;
using CalculoFiguras.Entites;
using CalculoFiguras.Entites.Enum;

namespace CalculoFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Entre com o número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da figura #{i}:");
                Console.Write("Retângulo ou Círculo (r/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.Write("Altura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Largura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Áreas das figuras:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}