/******************************************************************************

Escreva um algoritmo que leia o preço de um produto a partir do teclado e
apresente na tela o valor do produto acrescido de 10% de seu valor original.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int prod;
    Console.WriteLine("Digite o valor do produto: ");
	prod = int.Parse(Console.ReadLine());		
	Console.WriteLine($"O novo valor do produto e de  : {prod + prod*0.1}");
	Console.ReadLine();
  }
}

