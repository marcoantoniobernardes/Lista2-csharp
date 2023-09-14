/******************************************************************************

Escreva um algoritmo que, dados três valores, calcule e imprima as médias
aritmética, harmônica e geométrica destes valores.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    float num1 = 0, num2 = 0, num3 = 0;
    Console.WriteLine("Média aritmética, média harmônica e média geométrica, digite o primeiro número:");
    num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    num2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o terceiro número:");
    num3 = float.Parse(Console.ReadLine());
    Console.WriteLine($"A média aritmética é {(num1 + num2 + num3) / 3} e a média harmônica é {3/((1/num1) + (1/num2) + (1/num3))} e a média geometrica é {MathF.Cbrt(num1 * num2 * num3)}.");
    Console.ReadLine();
  }
}