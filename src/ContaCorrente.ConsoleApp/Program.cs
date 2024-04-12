﻿using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
namespace ContaCorrente.ConsoleApp
{
        //Uma conta corrente possui um número, um saldo, um status que informa se ela é especial ou não, um limite e um histórico de movimentações.
        //Uma movimentação possui um valor e uma informação se ela é uma movimentação de crédito ou débito. 
        //Cada conta terá operações de saques, depósitos, visualização de saldo, visualização de extrato e transferência entre contas.
       //Cada conta vai ter o nome, o sobrenome e cpf do cliente dono da conta.
       //Uma conta corrente só pode fazer saques desde que o valor não exceda o limite de saque que é o limite + saldo.
      //Não precisa implementar a interação com usuário.

    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Fulano", "Silva", "123.456.789-00");
            contaCorrente conta = new contaCorrente(123, 1000, true, 500, new List<Movimentação>(), cliente);
            conta.Deposito(100);
            conta.Saque(200);
            conta.Transferencia(300, new contaCorrente(124, 1000, true, 500, new List<Movimentação>(), new Cliente("Ciclano", "Silva", "987.654.321-00")));
            conta.Extrato();
        }
    }
}
