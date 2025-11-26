using ClassesEstaticas;

Console.WriteLine($"Numero de PI: {CalculosMatematicos.PI}");

//Console.WriteLine($"Digite o primeiro numero:");
//float n1 = float.Parse(Console.ReadLine());

//Console.WriteLine($"Digite o primeiro numero:");
//float n2 = float.Parse(Console.ReadLine());

//Console.WriteLine($"Resultados:");

//Console.WriteLine($"Soma:{CalculosMatematicos.Somar(n1, n2)}");

//Console.WriteLine($"Subtrair:{CalculosMatematicos.Subtrair(n1, n2)}");

//Console.WriteLine($"Multiplicar:{CalculosMatematicos.Multiplicar(n1, n2)}");

//Console.WriteLine($"Soma de 5 e 10: {CalculosMatematicos.Somar(5, 10)}");
//Console.WriteLine($"Soma de 50,2 e 10,7: {CalculosMatematicos.Somar(50.2f , 10.7f)}");

//Console.WriteLine($"Divisao de 5 e 0: {CalculosMatematicos.Dividir(5, 0)}");

Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Maior numero e: {Math.Max(n1, n2)}");
Console.WriteLine($"Maior numero e: {Math.Min(n1, n2)}");

Console.WriteLine($"Potencia de 3 ^ 2 :{Math.Pow(3, 2)}");
