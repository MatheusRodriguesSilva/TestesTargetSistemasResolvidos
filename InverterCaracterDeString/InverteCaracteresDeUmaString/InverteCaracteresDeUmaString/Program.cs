using System;

class Program
{
    static void Main(string[] args)
    {
        string textoOriginal, textoInvertido = "";
        Console.Write("Digite uma string para ser invertida: ");
        textoOriginal = Console.ReadLine();
        for (int i = textoOriginal.Length - 1; i >= 0; i--)
        {
            textoInvertido += textoOriginal[i];
        }
        Console.WriteLine("A string invertida é: {0}", textoInvertido);
        Console.ReadKey();
    }
}
