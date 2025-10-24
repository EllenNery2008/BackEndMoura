int opcao;

do

{



    Console.WriteLine($"----------------------------------------------");
    Console.WriteLine($"                Bem Vindo                     ");
    Console.WriteLine($"                   ao                         ");
    Console.WriteLine($"               Jacareca Food                  ");
    Console.WriteLine($"----------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Escolha um opcao no menu:");
    Console.WriteLine();
    Console.WriteLine($"  1)  HotRoll....................................R$ 29,90");
    Console.WriteLine($"  2)  Sashimi.....................................R$ 30,00");
    Console.WriteLine($"  3)  Yakisoba....................................R$ 67,20");
    Console.WriteLine($"  4)  Temaki......................................R$ 35,90");
    Console.WriteLine($"  5)  Guioza......................................R$ 49,90");
    Console.WriteLine($"  6)  Shimeji.....................................R$ 50,90");
    Console.WriteLine($"  0)  Sair");
    Console.WriteLine($"Opcao:");//exibe o texto sem pular linha
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo ...");

            Console.ReadLine();// so pra parar o programa aui
            break;
        case 1:
            HotRoll();
            break;
        case 2:
            Sashimi();
            break;
        case 3:
            Yakisoba();
            break;
        case 4:
            Temaki(); 
            break;
        case 5:
            Guioza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opcao Invalida");
            break;
    }// fim so switch

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine();
} while (opcao != 0);

void HotRoll()
{
   Console.WriteLine($"Boa escolha, vamos prepara seu HOtRoll com carinho"); 
}
void Sashimi()
{
   Console.WriteLine($"Boa escolha, vamos prepara seu Sashimi com carinho"); 
}
void Yakisoba()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Yakisoba com carinho");
}
void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Temaki com carinho");
}
void  Guioza()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Guioza com carinho");
}
void  Shimeji()
{
     Console.WriteLine($"Boa escolha, vamos prepara seu Shimeji com carinho");
}





