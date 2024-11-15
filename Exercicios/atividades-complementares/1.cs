using System;
class Program
{
	static void Main()
	{
		double x1 = 1, y1 = 2;
		double x2 = 4, y2 = 6;
		double distancia = CalcularDistancia(x1, y1, x2, y2);
		Console.WriteLine("A distancia entre dois pontos: " + distancia);
	}
	static double CalcularDistancia (double x1, double y1, double x2, double y2)
	{
		return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
	}
}