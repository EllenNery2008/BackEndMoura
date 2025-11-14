
namespace Exemplos
{
    public class Pessoa : Animal
    {

        public string Nome;

        public int Idade;
        public override void FazerSom()
        {
          Console.WriteLine($"Ola, eu sou uma pessoa engracada :)");
          
        }

        public override void Mover()
        {
           Console.WriteLine($"Plac Plac Plac");
           
        }
           public void Dormir()
        {
           Console.WriteLine($"zzzz");
           
        }
        

    }
}