using System;
using System.Globalization;

Console.WriteLine("Insira a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Insira a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Insira a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double notaFinal = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"Nota final: {notaFinal:F2}");