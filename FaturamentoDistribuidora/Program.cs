using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Dados do faturamento
        double[] faturamentoDiario = new double[]
        {
            22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612, 0.0,
            42889.2258, 46251.174, 11191.4722, 0.0, 0.0, 3847.4823, 373.7838,
            2659.7563, 48924.2448, 18419.2614, 0.0, 0.0, 35240.1826, 43829.1667,
            18235.6852, 4355.0662, 13327.1025, 0.0, 0.0, 25681.8318, 1718.1221,
            13220.495, 8414.61
        };

        // Ignora os dias sem faturamento
        var diasSemFaturamento = faturamentoDiario.Where(valor => valor > 0);

        // Calcula o menor valor de faturamento diário
        double menorFaturamentoDiario = diasSemFaturamento.Min();

        // Calcula o maior valor de faturamento diário
        double maiorFaturamentoDiario = diasSemFaturamento.Max();

        // Calcula a média mensal de faturamento diário
        double mediaMensalFaturamentoDiario = diasSemFaturamento.Average();

        // Calcula o número de dias em que o valor do faturamento diário foi superior à média mensal
        int diasAcimaDaMedia = faturamentoDiario.Count(valor => valor > mediaMensalFaturamentoDiario);

        Console.WriteLine($"Menor faturamento diário: {menorFaturamentoDiario:C}");
        Console.WriteLine($"Maior faturamento diário: {maiorFaturamentoDiario:C}");
        Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasAcimaDaMedia}");
    }
}
