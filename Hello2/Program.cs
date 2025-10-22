//Pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario e quanto investiu esse ano

//Camel Case - Letra maiuscula a partir da segunda palavra
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

//Pasta Case - Primeira letra de cada palavra sempre maiuscula
Console.WriteLine("Ola, qual e seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual e seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual e a sua idade?");
idade = int.Parse(Console.ReadLine() );//converte o texto em int antes de jogar na variavel

Console.WriteLine("Qual e o saldo bancario?");
saldoBancario = float.Parse(Console.ReadLine());//converte o texto digitado no console em float 

//receber o investimento do usuario

Console.WriteLine("Qual e o seu investimento para este ano?");
investimentos = float.Parse(Console.ReadLine());
 
Console.Clear();//limpa o console
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} e {idade}");
Console.WriteLine($"Saldo Bancario: R${saldoBancario}");
Console.WriteLine($"Investimento este ano: R${investimentos}");