using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo_Guidance
{
    class Program
    {
        static void Main()
        {
            double x, y;
            string color;
            // Tochka
            Console.WriteLine("Точка");
            Console.Write("Введите х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Tochka tochkaFirst = new Tochka(x, y);
            Console.WriteLine(tochkaFirst);
            Tochka tochkaSecond = new Tochka(4, 6);
            Tochka tochkaAddition = tochkaFirst + tochkaSecond;
            Console.WriteLine("Сложение 2-ух точек " + tochkaAddition);
            // ColoredTochka
            Console.WriteLine("Цветная точка");
            Console.Write("Введите х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цвет точки -> ");
            color = Console.ReadLine();
            ColoredTochka ctFirst = new ColoredTochka(color,x,y);
            Console.WriteLine(ctFirst);
            // Line вот тут веселее 
            Console.WriteLine("Линяя");
            double x2, y2;
            Console.WriteLine("1-ая позиция");
            Console.Write("Введите х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-ая позиция");
            Console.Write("Введите х -> ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nСравнение\n");
            Tochka tochkaFirst_Line = new Tochka(x, y);
            Tochka tochkaSecond_Line = new Tochka(x2,y2);
            Line lineFirst = new Line(tochkaFirst_Line, tochkaSecond_Line);
            Line lineSecond = new Line(tochkaFirst_Line, tochkaSecond_Line);
            Console.Write(lineFirst);
            Console.WriteLine(lineSecond);
            Console.WriteLine(lineFirst == lineSecond);
            // ColoredLine цветное веселье ?
            Console.WriteLine("\nЦветная линия");
            Console.WriteLine("1-ая позиция");
            Console.Write("Введите х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-ая позиция");
            Console.Write("Введите х -> ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цвет линии -> ");
            color = Console.ReadLine();
            Tochka tochkaFirst_ColoredLine = new Tochka(x, y);
            Tochka tochkaSecond_ColoredLine = new Tochka(x2, y2);
            ColoredLine coloredlineFirst = new ColoredLine(tochkaFirst_ColoredLine, tochkaSecond_ColoredLine, color);
            Console.WriteLine(coloredlineFirst);
            // странный многоугольник
            Console.WriteLine("Многоугольник");
            Polygon polygonFirst = new Polygon(lineFirst, lineSecond, new Line(tochkaFirst, tochkaSecond)); //не буду растягивать program еще на ~20 строк
            Console.WriteLine(polygonFirst);
            Console.ReadLine(); // страшная учесть для людей с Win7 
        }
    }
}
