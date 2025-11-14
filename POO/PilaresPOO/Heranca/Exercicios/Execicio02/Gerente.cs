
using Exercico02;

namespace Execicio02
{
    public class Gerente : Funcionarios
    {
        public float Bonus;

        public override float CalcularSalario()
        {
            return SalarioBase += Bonus;
        }
        
    }
}