
using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();

// Criar um menu

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opcoes
    1) Cadastrar Fatura
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatorios
    6) Listar Contratos
    0) Sair
    Escolha a opcao:
    ");

    opcao = int.Parse(Console.ReadLine());

    // criar um swith case para as opcoes do menu

    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatorio em desenvolvimento");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            Console.WriteLine($"Listar Relatorios em desenvolvimento");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opcao Invalida");

            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();

} while (opcao != 0);

//Fucoes Auxiliares

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
string dev = Console.ReadLine();

Console.WriteLine($"Digite o nome da empresa");
string empresa = Console.ReadLine();

Console.WriteLine($"Digite o valor da fatura");
float valor = float.Parse(Console.ReadLine());

Console.WriteLine($"Dias de atraso da fatura?");
int qtdDiasAtraso = int.Parse(Console.ReadLine());

Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtraso);
documentos.Add(fat);

Console.WriteLine($"Fatura cadastrada com sucesso!");

}
void CadastrarContratos()
{

}
void CadastrarRelatorios()
{

}
void ListarContratos()
{

}
void ListarFaturas()
{
Console.WriteLine($"Listando Faturas:");
foreach (Fatura item in documentos)
    {
        if(item is Fatura)
        {
            item.Imprimir();
        }
    }
}
void ListarRelatorios()
{

}


// criar uma Lista para faturas 

//List<IImprimivel> documentos = new List<IImprimivel>();

// Cria um objeto de cada classe e adiciona nas listas 
//Fatura fatEllen = new Fatura();
//documentos.Add(fatEllen);

//Fatura fatJuju = new Fatura();
//documentos.Add(fatJuju);

//Relatorio relEllen = new Relatorio();
//documentos.Add(relEllen);

//Relatorio relJuju = new Relatorio();
//documentos.Add(relJuju);

//Contrato contEllen = new Contrato();
//documentos.Add(contEllen);

//Contrato contJuju = new Contrato();
//documentos.Add(contJuju);

// Listar os dados da fatura

//Console.WriteLine($"FATURAS:");

//foreach (var fat in documentos)
//{ 
// if (fat is Fatura)
//{
// fat.Imprimir();
//}
//}
//Console.WriteLine($"RELATORIOS:");

///foreach (var item in documentos)
//{
//if (item is Relatorio)
//  {
// item.Imprimir();
// }
//}


//Console.WriteLine($"CONTRATOS:");

//foreach (var item in documentos)
//{
// if (item is Contrato)
//{
// item.Imprimir();
//}
//}