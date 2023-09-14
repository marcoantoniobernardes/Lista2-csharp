/******************************************************************************

Escreva um algoritmo para calcular e imprimir o salário bruto a ser recebido
por um funcionário em um mês.
O programa deverá utilizar os seguintes dados:
a. Número de horas que o funcionário trabalhou no mês.
b. Valor recebido por hora de trabalho.
c. Valor do salário família.
d. Número de filhos com idade menor que 14 anos, para calcular o salário
família

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double horas = 0, vhora = 0, salariof = 0, qtdef = 0, valor1 = 0, valorsalariomin = 1754.18;
    Console.WriteLine("Horas trabalhadas:");
    horas = double.Parse(Console.ReadLine());
    Console.WriteLine("Valor hora:");
    vhora = double.Parse(Console.ReadLine());
    Console.WriteLine("Salário Família:");
    salariof = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade de filhos com menos de 14 anos:");
    qtdef = double.Parse(Console.ReadLine());
    valor1 = horas * vhora;
    if(valor1 <= valorsalariomin)
    {
        Console.WriteLine($"O sálario bruto será de {valor1 + (salariof*qtdef)}");
    }
    else
    {
        Console.WriteLine($"O sálario bruto será de {valor1}");
    }
    Console.ReadLine();
  }
}
