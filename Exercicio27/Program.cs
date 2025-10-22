
int qntdUsuario = 0;
int contador = 1;
Console.WriteLine($"Quantos numeros voce quer digitar?");

qntdUsuario = int.Parse(Console.ReadLine());

while (contador <= qntdUsuario)

{
    Console.WriteLine($"Digite um numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"numero digitado eh Par: {batata}");
    }

contador++;
}