/******************************************************************************

Em um estacionamento há carros e motos. Escreva um algoritmo que solicite
ao usuário o total de veículos e o total de rodas.
O algoritmo deve determinar quantos carros e quantas motos há no
estacionamento. O resultado deve ser apresentado na tela para o usuário.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int veiculos = 0, nrodas = 0, totalcarros = 0;
    Console.WriteLine("Estacionamento, digite o número de veículos:");
    veiculos = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o número de rodas:");
    nrodas = int.Parse(Console.ReadLine());
    totalcarros = nrodas/4;
    Console.WriteLine($"O numero de carros é de : {totalcarros} e o numero de motos é : {veiculos - totalcarros}");
    Console.ReadLine();
  }
}
