using System;
using System.Diagnostics.Metrics;
using System.Globalization;
/*
QUESTÃO 06
-------------------------------------------------------------------------------------
Console.WriteLine("Digite o valor inicial:");
double valorInicial = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da taxa de juros%:");
double taxaJuros = double.Parse(Console.ReadLine());

float periodo = 8.33f; 
double valorFuturo = 0;

for (int i = 0; i < periodo; i++)
{
    valorFuturo = valorInicial * Math.Pow((1 + taxaJuros / 100), periodo);
}


Console.WriteLine("\nValor Presente  |  Taxas de Juros  |      Período      |   Valor Futuro");
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine($"   R$ {valorInicial:F2}   |       {taxaJuros}%        | 8 meses e 10 dias |   R$ {valorFuturo:F2}");


QUESTÃO 07
-------------------------------------------------------------------------------------



Console.WriteLine("Digite o valor inicial:");
double valorInicial = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da taxa de juros%:");
double taxaJuros = double.Parse(Console.ReadLine());

int meses = 8;
float dias = 0.33f;
double[] valorFuturo = new double[9];

for (int i = 0; i < meses; i++)
{
    valorFuturo[i] = taxaJuros / 100 * valorInicial;

    if (i != 4)
    {
        valorInicial += valorFuturo[i];
    }
    else
    {
        Console.WriteLine("\n\n------------------------- Resgate no 5º Mês -------------------------");
        Console.WriteLine("                                R$ " + Math.Round(valorFuturo[i], 2));
    }
}

valorInicial += (taxaJuros / 100 * valorInicial) * dias;
Console.WriteLine("\n\n------------------------- Saldo Final -------------------------");
Console.WriteLine("                             R$ " + Math.Round(valorInicial, 2));
*/