/******************************************************************************

Escreva um algoritmo para calcular os juros compostos de uma aplicação
financeira. O algoritmo deve ler o valor do capital a ser aplicado, o prazo de
aplicação em meses, a taxa de juros mensal e apresentar na tela o montante a
ser recebido.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double capital = 0, mes = 0, taxa = 0;
    Console.WriteLine("Calculo de juros compostos, informe o capital:");
    capital = double.Parse(Console.ReadLine());
    Console.WriteLine("informe a quantidade de meses:");
    mes = int.Parse(Console.ReadLine());
    Console.WriteLine("informe a taxa:");
    taxa = double.Parse(Console.ReadLine());
    Console.WriteLine($"O montante vai ser de {capital*Math.Pow((1 + taxa), mes)}");
    Console.ReadLine();
  }
}
