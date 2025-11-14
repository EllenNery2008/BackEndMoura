
namespace Heranca
{
    public class Carro : Veiculo
    {
      public int QtbPorta;

       public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantas portas: {QtbPorta}");
            
            
        }
    }
}

