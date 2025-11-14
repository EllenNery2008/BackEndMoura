using System.Runtime.Serialization;
using Exemplos;

// Gato birobinha = new Gato();

// Cachorro billy = new Cachorro();

// Pessoa fer = new Pessoa(); 
// fer.Nome = "Fernanda";
// fer.Idade = 17;

// Console.WriteLine($"Nome: {fer.Nome}");
// Console.WriteLine($"Idade do {fer.Nome}: {fer.Idade} anos");

// Console.WriteLine($"Som do {fer.Nome}:");
// fer.FazerSom();
// Console.WriteLine($"{fer.Nome} esta se movendo: ");
// fer.Mover();

// Console.WriteLine($"{fer.Nome} foi dormir: ");
// fer.Dormir();

// Console.Clear();

Console.Clear();
Console.WriteLine($"CONTA CORRENTE:");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R${cc.Saldo}");

Console.WriteLine($"CONTA POUPANCA:");
ContaPoupanca cp = new ContaPoupanca(10);
Console.WriteLine($"Saldo inicial da conta: R${cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cp.Saldo}");
cp.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R${cp.Saldo}");