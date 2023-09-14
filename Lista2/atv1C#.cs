/******************************************************************************

Escreva um algoritmo que leia dois números informados pelo usuário a partir
do teclado e que apresente o resultado da média aritmética dos dois números
informados.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    float num1, num2;		
    Console.WriteLine("Média Aritimética, Digite o primeiro número:");
	num1 = float.Parse(Console.ReadLine());		
	Console.WriteLine("Digite o segundo número:");
	num2 = float.Parse(Console.ReadLine());		
	Console.WriteLine($"A média destes dois números é {(num1 + num2) / 2}");
	Console.ReadLine();
  }
}
