using Calculadora;

//Console.Clear();

//Calculator calc = new Calculator();

//calc.Numero1 = 50;
//calc.Numero2 = 10;

//Console.WriteLine($"== Calculator ==");
//Console.WriteLine($"Primeiro numero: {calc.Numero1}");
//Console.WriteLine($"Segundo numero: {calc.Numero2}");

//Console.WriteLine($"Resultados:");
//Console.WriteLine();


//Console.WriteLine($"Soma {calc.Somar()}");
//Console.WriteLine();

//Console.WriteLine($"Subtracao {calc.Subtrair()}");
//Console.WriteLine();

//Console.WriteLine($"Mutiplicacao {calc.Mutiplicar()}");
//Console.WriteLine();

//Console.WriteLine($"Divisao {calc.Dividir()}");
//Console.WriteLine();

Console.Clear();

Calculator calc = new Calculator();

int opcao = -1;
do
{
    Console.Clear();

    Console.WriteLine($"==== Calculadora C# Console ====");
    Console.WriteLine();

    Console.WriteLine($"Menu");
    Console.WriteLine($"1) Somar");
    Console.WriteLine($"2) Subtrair");
    Console.WriteLine($"3) Mutiplicar");
    Console.WriteLine($"4) Dividir");
    Console.WriteLine($"0)   Sair");
    Console.WriteLine($"Escolha um opcao:");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o primeiro numero");
    calc.Numero1 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo numero");
    calc.Numero2 = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Resultado da soma: {calc.Somar()}");
            break;
        case 2:
            Console.WriteLine($"Resultado da subtracao: {calc.Subtrair()}");
            break;
        case 3:
            Console.WriteLine($"Resultado da multipicacao: {calc.Mutiplicar()}");
            break;
        case 4:
            Console.WriteLine($"Resultado da divisao: {calc.Dividir()}");
            break;
        case 0:
            Console.WriteLine($"Obrigada por utilizar o programa. Saindo ...");
            break;
        default:
            Console.WriteLine($"Opcao Invalida, escolha uma opcao de 1 a 4 ou 0 pra sair!");
            break;

    }

    Console.WriteLine($"Digite <ENTER> para sair ...");
    Console.ReadLine();


} while (opcao != 0);


