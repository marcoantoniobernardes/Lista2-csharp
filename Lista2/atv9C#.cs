/******************************************************************************

Escreva um algoritmo que receba um número inteiro de segundos a partir do
teclado e imprima na tela a quantidade correspondente em horas, minutos e
segundos

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int tsegundo = 0, hora = 0, minuto = 0, segundo = 0;
    Console.WriteLine("Conversor de hora, digite um número em segundos para saber a hora:");
    tsegundo = int.Parse(Console.ReadLine());
    hora = tsegundo/3600;
    minuto = tsegundo%3600/60;
    segundo = tsegundo%60;
    Console.WriteLine($"São {hora} hora(s) {minuto} minuto(s) e {segundo} segundo(s).");
    Console.ReadLine();
   
  }
}
