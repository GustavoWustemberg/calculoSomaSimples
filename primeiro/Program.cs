// See https://aka.ms/new-console-template for more information
int n1, n2, calc;

Console.WriteLine("Programa de soma");
Console.WriteLine("digite o primeiro número");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo número");
n2 = int.Parse(Console.ReadLine());
calc = n1 + n2;
Console.WriteLine("O resultado da soma dos dois números é " + calc);
Console.WriteLine("Aperte qualquer carácter");
Console.ReadKey();
return (0);