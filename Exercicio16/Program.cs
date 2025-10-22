// De acordo com a tabela acima faca um progarama que receba o cargo
// e o salario de um funcionario e calcule e imprima o salario reajustado.

string cargo;
float salario, salarioNovo = 0;

Console.WriteLine("Digite qual e seu cargo de funcionario producao, administrativo ou diretoria?");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do seu funcionamento?");
salario = float.Parse(Console.ReadLine());

if (cargo == "Producao")
{
    salarioNovo = salario + (salario * 0.065f);

}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.75f);
}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12f);
}

else
{
    Console.WriteLine($"Cargo invalido");
    return;
}

Console.WriteLine($"O novo salario reajustado e {salarioNovo}");