using ClasseEObjetos;

Console.Clear();
Console.WriteLine($"== Agencia Bancaria ==");
Console.WriteLine();

AgenciaBancaria contaDoJoao = new AgenciaBancaria();

contaDoJoao.Titular = "Diogo Farias";
contaDoJoao.Saldo = 1000.98f;

contaDoJoao.Depositar(-5000);

contaDoJoao.Sacar(1600);





