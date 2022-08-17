using System;

namespace PVetor_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letra = new char[10];
            int i, contc = 0,contv = 0;

            for(i = 0; i < 10; i++)
            {
                letra[i] = char.Parse(Console.ReadLine());
            }
            for(i = 0; i < 10; i++)
            {
                Console.Write(letra[i]);
            }
            for(i=0; i < 10; i++)
            {
                if(letra[i] == 'A' || letra[i] == 'E' || letra[i] == 'I' || letra[i] == 'O' || letra[i] == 'U')
                {
                    contv++;
                }
                else
                {
                    contc++;
                }


                Console.WriteLine($"\nA palavra possui {contv} vogais");
                Console.WriteLine($"\nA palavra possui {contc} consoantes");
            }
        }
    }
}
