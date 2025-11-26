


namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;

        private string Modelo;

        private int VelocidadeAtual;

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }
         public string ObterMarca(string valor)
        {
            return Marca;
        }
        
          public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
         public string ObterModelo()
        {
            return Modelo;
        }

         public int ObterVelocidadeAtual()
        {
            return VelocidadeAtual;
        }
        
        public void Acelerar(int valor)
        {
            if (valor >= 0 && valor <= Acelerar)
            {
                Acelerar -= valor;
                Console.WriteLine($"Acelerara a velocidade!");
            }
            else
            {
               Console.WriteLine($"Desacelerar a velocidade!");
               
            }
        }
    }
}