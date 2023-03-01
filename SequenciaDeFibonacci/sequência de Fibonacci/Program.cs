using System;

class Program
{
    static void Main()
    {
        int num, ant1 = 0, ant2 = 1, proximo = 0;
        bool pertence = false;

        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());

        while (proximo < num)
        {
            proximo = ant1 + ant2;
            ant1 = ant2;
            ant2 = proximo;

            if (proximo == num)
            {
                pertence = true;
                break;
            }
        }

        if (pertence)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
        }
    }
}
