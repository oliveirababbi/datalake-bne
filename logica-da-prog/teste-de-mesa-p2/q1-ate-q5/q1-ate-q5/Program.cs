using System;
using System.Globalization;
/*

QUESTÃO 01
-------------------------------------------------------------------------------------

double P = 1000;
double i = 10;
int n = 24;
double F = P;

for (int cont = 0; cont < n; cont++)
{
    F *= 1 + (i / 100);
}

Console.WriteLine("Valor Presente | Taxas de Juros | Período (Mês) | Valor Futuro");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"  R$ {P:F2}   |      {i}%       |    {n} meses   |  R$ {F:F2}");

QUESTÃO 02
-------------------------------------------------------------------------------------


double[] P = new double[6];
double taxa = 1.25;
double L = 0, RL = 0;
int n = 6;

Console.WriteLine("Mês | Rendimento | Rend. Líquido | Renda Acumulada");
Console.WriteLine("--------------------------------------------------");

for (int i = 0; i < 1; i++)
{
    P[i] = 3800;
    for (int j = 0; j < n; j++) {

        L = P[i] - (taxa / 1000);
        P[i] *= 1 + (taxa / 100);
        double RAc = P[i];
        RL = RAc - L;
        
        Console.WriteLine($"  {j+1} | R$ {P[i]:F2} |   R$ {RL:F2}    |   R$ {RAc:F2}  ");
    }
}



QUESTÃO 03
------------------------------------------------------------------------------------

Console.WriteLine("Digite o valor inicial:");
double P = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da taxa de juros%:");
double i = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o período (meses):");
int n = int.Parse(Console.ReadLine());

double F = P;

for (int cont = 0; cont < n; cont++)
{
    F *= 1 + (i / 100);
}

Console.WriteLine("\nValor Presente | Taxas de Juros | Período (Mês) | Valor Futuro");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"   R$ {P:F2}    |      {i}%        |    {n} meses    |  R$ {F:F2}");



QUESTÃO 04
-------------------------------------------------------------------------------------

double[] P = new double[6];
double taxa = 2;
double L = 0, RL = 0;
double Rg = RL;
double SaldoRg = 0;
int n = 6;

Console.WriteLine("Mês   |   Rendimento  |   Acumulado   |   Resgate   |    Saldo Pós-Resgate ");
Console.WriteLine("-----------------------------------------------------------");

for (int i = 0; i < 1; i++)
{
    P[i] = 20000;
    for (int j = 0; j < n; j++)
    {

        L = P[i] - (taxa / 1000);
        P[i] *= 1 + (taxa / 100);
        double RAc = P[i];
        RL = RAc - L;

        if (j == 4)
        {
            Rg = RL;
        }

        else
        {
            Rg = 0;
        }

        SaldoRg = RAc - Rg;

        Console.WriteLine($"  {j + 1}   |  R$ {P[i]:F2}  |  R$ {RAc:F2}  |  R$ {Rg:F2}  |   R$ {SaldoRg:F2}  ");
    }
}


QUESTÃO 05 
-------------------------------------------------------------------------------------
*/

double i = 1.25;
int n = 6;
double F = 7390.61;
double P = 0;

for (int cont = 0; cont < n; cont++)
{
    P = F / Math.Pow((1 + (i/100)),n);
}

Console.WriteLine("Valor Presente | Taxas de Juros | Período (Mês) | Valor Futuro");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"  R$ {P:F2}   |      {i}%     |    {n} meses    |  R$ {F:F2}");

