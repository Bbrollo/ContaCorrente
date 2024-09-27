using System.Globalization;

namespace ContaCorrente {
    internal class Program {
        static void Main(string[] args) {

            Conta c;

            Console.WriteLine("--------Abrir conta no banco Brollo--------");
            Console.WriteLine();
            Console.Write("Digite o nome completo do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Haverá depósito inicial? (s/n) ");
            string depositoInicial = Console.ReadLine();
            double saldo=0;
            
            if (depositoInicial == "s" || depositoInicial == "S") {        
                Console.Write("Informe o valor do depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                c = new Conta(numeroConta, nome, saldo);
            }
            else {
               c = new Conta(numeroConta, nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:\n" + c);
            Console.Write("Informe o valor de depósito: ");
            double valor = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            c.DepositoSaldo(valor);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados\n" + c);
            Console.WriteLine();

            Console.Write("Informe o valor de saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.SacaSaldo(valor);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados\n" + c);

        }
    }
}
