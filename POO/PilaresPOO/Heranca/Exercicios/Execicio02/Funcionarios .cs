
namespace Exercico02
{
    public class Funcionarios
    {
        public string Nome;

        public float  SalarioBase;

         public virtual float CalcularSalario()
        {
           return SalarioBase;
           
        }
    }
}

