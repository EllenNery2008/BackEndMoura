//Pedir para o usuario digitar dois numeros e exibir a soma desses dois numeros 

int n1, n2;
double batata;
Console.WriteLine($"Digite o primeiro numero:");
// se o usuario digitar "40" o parse tira as aspas convertendo em numero
n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero:");
n2 = int.Parse(Console.ReadLine());


int soma = n1 + n2;

Console.WriteLine($"A soma de {n1} + {n2} e {soma}");
