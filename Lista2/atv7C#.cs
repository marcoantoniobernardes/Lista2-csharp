/******************************************************************************

Escreva um algoritmo que leia o salário fixo de um vendedor, o valor total das
vendas que ele realizou no mês e o percentual que ele ganha sobre o total das
vendas mensais. O algoritmo deve calcular o salário total do vendedor e
apresentá-lo na tela.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double salariov = 0, valorv = 0, percentual = 0;
    Console.WriteLine("Salario vendedor, digite salário base:");
    salariov = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite total de vendas:");
    valorv = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite percentual por venda:");
    percentual = double.Parse(Console.ReadLine());
    Console.WriteLine($"O salário do vendendor neste mês foi de : R$ {salariov+(valorv*percentual)}");
    Console.ReadLine();
  }
}
