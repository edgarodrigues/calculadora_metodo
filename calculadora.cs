namespace Calculadora
{
     class Operacoes
     {
          public static void RealizarAdicao(decimal valor1, decimal valor2)
          {
               Console.WriteLine($"A soma dos valores {valor1} e {valor2} é: {valor1 + valor2}");
          }

          public static void RealizarSubtracao(decimal valor1, decimal valor2)
          {
               Console.WriteLine($"A subtração dos valores {valor1} e {valor2} é: {valor1 - valor2}");
          }

          public static void RealizarMultiplicacao(decimal valor1, decimal valor2)
          {
               Console.WriteLine($"A multiplicação dos valores {valor1} e {valor2} é: {valor1 * valor2}");
          }

          public static void RealizarDivisao(decimal valor1, decimal valor2)
          {
               Console.WriteLine($"A divisão dos valores {valor1} e {valor2} é: {valor1 / valor2}");
          }

          

     }
}