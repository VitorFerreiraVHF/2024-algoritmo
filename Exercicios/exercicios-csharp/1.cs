using System;

class Program
{

    static void Main()
    {
        double raio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(raio, 2);
        Console.WriteLine($"{area: F4}");

    }
}