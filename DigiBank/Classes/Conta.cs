using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroConta = "001";
            Conta.NumeroContaSequencial++;
        }

        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroConta { get; protected set; }
        public static int NumeroContaSequencial { get; private set; }

        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public bool Saca(double valor)
        {
            if (valor > this.ConsultaSaldo())
                return false;

            this.Saldo -= valor;
            return true;

        }
        public string GetCodigoBanco()
        {
            return this.Codigobanco;
        }

        public string GetNumeroConta()
        {
            return this.NumeroConta;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }
    }
}
