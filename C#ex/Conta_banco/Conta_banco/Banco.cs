using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_banco
{
    class Banco
    {
        public int _accountNum { get; private set; }
        public string _name { get; private set; }
        public double _money { get; private set; }

        public Banco(int num, string name)
        {
            _accountNum = num;
            _name = name;
            _money = 0;
        }

        public string Deposit(double cash)
        {
            if (cash > 0)
            {
                _money += cash;
                return "Deposito feito com sucesso!";
            }
            else
            {
                return "Valor invalido";
            }
        }

        public string Withdrawn(double cash)
        {
            if (cash > 0 && _money - cash - 5 > 0)
            {
                _money -= cash + 5;
                return "Saque efetuado com sucesso!";
            }
            return "Valor invalido";
        }

        public override string ToString()
        {
            return "Conta " + _accountNum + ", Titular: " + _name + ", Saldo: $ " +
                _money.ToString("F2");
        }
    }
}
