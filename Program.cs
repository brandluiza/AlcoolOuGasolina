﻿Console.Clear();

    
 Console.WriteLine("--- Etanol ou Gasolina? ---\n");

Console.Write("Digite o preço do etanol (R$).....: ");
decimal precoEtanol = Convert.ToDecimal(Console.ReadLine());


Console.Write("Digite o preço da gasolina (R$)...: ");
decimal precoGasolina = Convert.ToDecimal(Console.ReadLine());

double razao = CalcularRazao(precoEtanol, precoGasolina);
 bool usarGasolina = DeveAbastecerComGasolina(razao);
 

Console.WriteLine();
Console.WriteLine("O preço do etanol corresponde a " + (razao * 100).ToString("N1") + "% do preço da gasolina.");

if (usarGasolina)
{ Console.WriteLine("Recomendação: Abasteça com GASOLINA.");
}
 
else
{
    Console.WriteLine("Recomendação: Abasteça com ETANOL.");
}
    
    
static double CalcularRazao(decimal etanol, decimal gasolina)


{
return (double)(etanol / gasolina);
}

static bool DeveAbastecerComGasolina(double razao)


 {double limite = 0.73;
  return razao >= limite;}

    