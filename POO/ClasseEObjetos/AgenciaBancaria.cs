
namespace ClasseEObjetos

{
    public class AgenciaBancaria
    {

        public string Titular;

        public float Saldo;
        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito efetuado  com sucesso!");
                Console.WriteLine($"Novo Saldo: {Saldo:F2}");

            }
            else
            {
                Console.WriteLine($"O valor do deposito deve ser positivo");
                Console.WriteLine($"Saldo: {Saldo:F2}");
            }

        }
        public void Sacar(float valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso!");
                Console.WriteLine($"Novo Saldo: {Saldo:F2}");
                return;
            }
            Console.WriteLine($"Saldo insuficiente");
            Console.WriteLine($"Saldo: {Saldo:F2}");


        }

    }
}