using System;
using Microsoft.VisualBasic;
namespace TelaConsole;

public class Moldura
{
    public static void Cabecalho(int largura, char caractere)
    {
        string msg = "Bem Vindo ao C# Santinho";
        int espaco = (largura - msg.Length) / 2;

        Console.Write(new string(' ', 12));

        Console.WriteLine(new string(caractere, largura));
        // Console.WriteLine("**");
        Console.Write(new string(' ', 12));
        Console.Write("***");
        Console.Write(new string(' ', espaco - 3));
        Console.Write(msg);
        Console.Write(new string(' ', espaco - 3));
        Console.WriteLine("***");
        Console.Write(new string(' ', 12));
        Console.Write(new string(caractere, largura));
        Console.WriteLine();

    }

    public static void Rodape(int largura, char caractere)
    {
        string msg1 = " Prof. Wanfranklin";
        string msg2 = "UNP - Ensino pra Valer ";
        int espaco = (largura - (msg1.Length + msg2.Length));

        Console.Write(new string(' ', 12));
        Console.WriteLine(new string(caractere, largura));
        Console.Write(new string(' ', 12));
        Console.Write("***");
        Console.Write(msg1);
        Console.Write(new string(' ', espaco - 6));
        Console.Write(msg2);
        Console.WriteLine("***");
        Console.Write(new string(' ', 12));
        Console.Write(new string(caractere, largura));
        Console.WriteLine();

    }

    public static void Meio(int largura, int altura)
    {
        int espaco = (largura - 2);

        for (int s = 0; s < altura; s++)
        {
            Console.Write(new string(' ', 12));
            Console.Write("*");
            for (int S = 0; S < espaco; S++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }


    }

}