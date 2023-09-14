/******************************************************************************

Escreva um algoritmo que receba dois números a partir do teclado. O
algoritmo deve imprimir o logaritmo do primeiro número na base
representada pelo segundo número.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double num = 0, nbase = 0;
    Console.WriteLine("Logaritmo, escreva o primeiro número:");
    num = double.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo número:");
    nbase = double.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado é: {Math.Log(num, nbase)}");
    Console.ReadLine();
  }
}
