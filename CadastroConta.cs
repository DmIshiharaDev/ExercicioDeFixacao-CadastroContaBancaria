using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacao_CadastroContaBancaria
{
    internal class CadastroConta
    {
        private int _conta { get ; set; }
        private string _titular;
        private char _opcao;
       
        private CadastroConta(int conta, string titular, char opcao) 
        {
            _conta = conta;
            _titular = titular;
            _opcao = opcao;
        }
    }
}
