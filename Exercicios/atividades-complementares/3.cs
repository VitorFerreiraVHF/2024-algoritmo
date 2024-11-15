using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());
        int peso1 = 2;
        int peso2 = 3;
        int peso3 = 5;
        double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
        Console.WriteLine($"A média final do aluno é: {media:F2}");
    }
}
