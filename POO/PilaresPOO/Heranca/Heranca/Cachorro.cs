
namespace Heranca
{
    public class Cachorro
    {
        public string Nome;

        public string Raca;

        public int Idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Raca: {Raca},Idade: {Idade}");

        }
        
        public void FazerSom()
        {
            Console.WriteLine($"Au au au...");
            
        }
    }
}