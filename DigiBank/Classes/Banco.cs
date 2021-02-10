using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public abstract class Banco
    {
        public Banco()
        {
            this.NomedoBanco = "DigiBank";
            this.Codigobanco = "123";
        }

        public string NomedoBanco { get; private set; }
        public string Codigobanco { get; private set; }
    }
}
