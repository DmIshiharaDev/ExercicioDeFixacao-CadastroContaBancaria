﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeFixacao_CadastroContaBancaria
{
    public class CadastroConta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Deposito { get; private set; }

        public CadastroConta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public CadastroConta(int numero, string titular, double depositoInicial) : this(numero, titular) 
        {
            Deposito = depositoInicial;
        }

        public void valorDeposito (double deposito)
        {
            Deposito += deposito;
        }

        public void valorSaque (double saque)
        {
            Deposito -= saque + 5.0 ;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Deposito.ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}
