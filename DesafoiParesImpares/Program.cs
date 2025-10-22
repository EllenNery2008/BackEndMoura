
Console.WriteLine($"Ola usuraio, quantos numeros voce quer digitar?");
int qtdNumeros = int.Parse(Console.ReadLine());
string pares = "Pares:";
string impares = "Impares:";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}º numero:");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {//e par?
        pares += numeroDigitado.ToString() + ",";
    }
    else
    {
        impares += numeroDigitado.ToString() + ",";
    }
}

Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);