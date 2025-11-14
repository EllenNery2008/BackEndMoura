using Execicio02;
using Exercico02;


Funcionarios funComum = new Funcionarios();
Gerente gerente = new Gerente();

funComum.SalarioBase = 1000;
gerente.SalarioBase= 10000;

float SalFinalComum = funComum.CalcularSalario();
float SalFinalGer = gerente.CalcularSalario();

Console.WriteLine($"Salario do Funcionario: {SalFinalComum}");
Console.WriteLine($"Salario do Gerente: {SalFinalGer}");