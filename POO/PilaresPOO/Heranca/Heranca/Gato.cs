
namespace Heranca
{
    public class Gato : Animal
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
            Console.WriteLine($"Miau");
            
        }

    }
}