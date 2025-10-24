//2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol
//  (os gols de cada time) e informa se o resultado foi um empate, 
// se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Quantos gols de o time 1 fez?");
int golsTime1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantos gols de o time 2 fez?");
int golsTime2 = int.Parse(Console.ReadLine());


if (golsTime1 == golsTime2)
{
    Console.WriteLine($"Jogo empatado!");
}

