
string[] nomes = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"==== Sistema bancario simples ====");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Cliente");
    Console.WriteLine($"0) Sair");

    Console.WriteLine($"Digite a opcao:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerramento o programa ...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarCliente();
            break;
        default:

            Console.WriteLine($"Opcao Invalida");
            break;
    }
    //AO FINAL DE CADA OPCAO, FAZ UMA PARADA NO SISTEMA
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();

} while (opcao != 0);//RECOMECA O MENU

void CadastrarCliente()

{
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;
    }
    Console.Write($"Nome do Cliente:");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0.50f;
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso!");
}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {// cliente nao encontrado
        return;//para a funcao
    }

    //Cliente encontrado
    Console.Write($"Valor para deposito:");
    float valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += valor;
    Console.WriteLine($"Deposito de R$ {valor:F2} realizado");
}
void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.Write($"valor para saque:");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idCliente] >= valor && valor > 0)
    {
        saldos[idCliente] -= valor;
        Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!");

    }


}
void Transferir()
{
    Console.WriteLine($"== Trasferencia ==");
    Console.Write($"Conta de Origem");
    int idOrigem = BuscarCliente();

    if (idOrigem == -1) return;

    Console.Write($"Conta de Destino:");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;

    Console.Write($"Valor para transferir:");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idDestino] >= valor && valor >0)
    {
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor;
        Console.WriteLine($"Transferencia concluida!");
    }
   else
    {
        Console.WriteLine($"Saldo Insuficiente!");
        
    }

}

void ListarCliente()
{
    Console.WriteLine($"== Lista de Clientes ==");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i}) - {nomes[i]} | Saldo: R$ {saldos[i]}");
    }
}

int BuscarCliente()
{
    ListarCliente();

    Console.Write($"Digite o numero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente nao encontrado!");
        return -1;
    }

    return idCliente;//vamos trocar pelo id do usuario buscado!
}