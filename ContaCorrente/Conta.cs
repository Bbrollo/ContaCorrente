using System.Globalization;

namespace ContaCorrente {
    internal class Conta {
        private int NumeroConta;
        public string Nome { get; private set;}
        public double Saldo { get; private set;}

        public Conta(int numeroConta, string nome, double saldo) {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
        }

        public Conta(int numeroConta, string nome) {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0;
        }

        public void DepositoSaldo(double saldo) {
            Saldo += saldo;
        }

        public void SacaSaldo(double saldo) {
            Saldo = Saldo - (saldo + 5);
        }

        public override string ToString() {
            return "Conta " + NumeroConta + " Titular: " + Nome + " Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
