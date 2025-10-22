//Faca um programa que receba 4 notas de um aluno, calcule e imprima a media
//aritmetica das notas e a mensagem de APROVADO para a media superior ou igual a
// 7,0 RECUPERACAO para notas entre 5.0 e 7,0 ou a mensagem de REPROVADO
// para media inferior a 5,0.

float n1, n2, n3, n4, media;

Console.WriteLine($"Digite o primeiro numero");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro numero");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o quarto numero");
n4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o quarto numero");
media= float.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro numero e o maior: {n1}");
}
else if (n2 > n3)
{
    Console.WriteLine($"O segundo numero e o maior: {n2}");
}
else if (n3 > n4)
{
    Console.WriteLine($"O Terceiro numero e o maior: {n3}");
}
else if (n4 > media)
{
    Console.WriteLine($"O Quarto numero e o maior: {n4}");
}
else
{
    Console.WriteLine($"Os numeros sao iguais: {n1} e {n2}");
    Console.WriteLine($"Os numeros sao iguais: {n3} e {n4}");
}