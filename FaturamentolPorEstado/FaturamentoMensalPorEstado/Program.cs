using System;

class Program
{
    static void Main(string[] args)
    {
        double totalFaturamento = 0;
        double percentualSP, percentualRJ, percentualMG, percentualES, percentualOutros;

        // Valor de faturamento mensal de uma distribuidora, detalhado por estado
        double faturamentoSP = 67_836.43;
        double faturamentoRJ = 36_678.66;
        double faturamentoMG = 29_229.88;
        double faturamentoES = 27_165.48;
        double faturamentoOutros = 19_849.53;

        // Somando os valores de faturamento de todos os estados
        totalFaturamento = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        // Calculando o percentual de representação de cada estado
        percentualSP = (faturamentoSP / totalFaturamento) * 100;
        percentualRJ = (faturamentoRJ / totalFaturamento) * 100;
        percentualMG = (faturamentoMG / totalFaturamento) * 100;
        percentualES = (faturamentoES / totalFaturamento) * 100;
        percentualOutros = (faturamentoOutros / totalFaturamento) * 100;

        // Exibindo os resultados
        Console.WriteLine("Percentual de representação de cada estado:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");

        Console.ReadKey();
    }
}
