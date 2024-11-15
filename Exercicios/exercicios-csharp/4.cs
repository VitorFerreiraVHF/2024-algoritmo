using System;
class Program
{
    static void Main()
    {
        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine()); 
        double media = (A * 3.5 + B * 7.5) / 11;
        Console.WriteLine("media = " + media.ToString("F1"));
    }
}