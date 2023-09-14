/******************************************************************************

Escreva um algoritmo que leia uma temperatura fornecida pelo usuário a partir
do teclado em graus Fahrenheit e a converta para o seu equivalente em graus
centígrados

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int farenheint;
    Console.WriteLine("Informe a temperatura em farenheint: ");
	farenheint = int.Parse(Console.ReadLine());		
	Console.WriteLine($"A temperaturaem C° é : {(farenheint - 32) / 1.8}");
	Console.ReadLine();
  }
}
