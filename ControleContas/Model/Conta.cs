using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Conta
    {
        //private long _numero;
        
        public long Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public Conta(long numero) //método construtor,com msmo nome da classe
       
        {
            Numero = numero;
        }

        public void Deposito(decimal valor)
        {
            Saldo = valor;
            
        }
        public bool Saque(decimal valor)
        {
            
            if (valor <= Saldo)
            {
                Saldo -= valor; //saldo = saldo-valor
                return true;
            }
                
                return false;       
        }
        public bool Transferencia(decimal valor, Conta destino)
        {
            if(Saque(valor))
            {
                destino.Deposito(valor);
                return true;
            }
            return false;
        }
             
        public override string ToString()
        {
            return $"Conta {this.Numero}, saldo {this.Saldo}"; 
        }

    }
}

