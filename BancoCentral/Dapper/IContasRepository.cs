using BancoCentral.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral.Dapper
{
    public class IContasRepository
    {
        public Conta getConta(string agencia, string conta)
        {
            return Data.contas.Find(c => c.Agencia == agencia && c.NumConta == conta);
        }

        public void verSaldo(Conta conta)
        {            
            Console.Write($"Seu saldo é");
            Console.ForegroundColor = ConsoleColor.Green;
            if (conta.Saldo < 0) Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" R${conta.Saldo}.\n", Console.BackgroundColor);            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione uma tecla para voltar.");
        }

        public void enumerarPix(Conta conta)
        {
        }

        static void addChave(Conta conta, string novaChave, TiposChave tipoChave)
        {

            conta.Chaves.Add(new Pix(novaChave, tipoChave));
            var c = Data.contas.FindIndex(i => i.Nome == conta.Nome);
            Data.contas[c] = conta;
        }

        internal Conta transferirPix(Conta conta, string[] dadosTransferencia)
        {
            double valorTransferencia = Convert.ToDouble(dadosTransferencia[0]);
            string pixDestino = dadosTransferencia[1];            
            var myIndex = Data.contas.FindIndex(c => c.NumConta == conta.NumConta);
            if (!conta.Status)
            {
                Console.WriteLine("Você não possui este valor para transferir.");
            }

            if (conta.Saldo >= valorTransferencia)
            {
                
                Data.contas[myIndex].Saldo -= valorTransferencia;
                Console.WriteLine("Pronto, enviamos sua transferência.");
            } else
            {
                Console.WriteLine("Você não possui saldo suficiente para esta transferência.");
            }

            
            return Data.contas[myIndex];
        }

        static Conta removerChave(Conta conta, string chaveRemover)
        {
            var myIndex = Data.contas.FindIndex(c => c.NumConta == conta.NumConta);

            var chaveIndex = conta.Chaves.FindIndex(t => t.Chave == chaveRemover);
            conta.Chaves.RemoveAt(chaveIndex);

            Data.contas[myIndex].Chaves = conta.Chaves;

            Console.WriteLine("Chave pix removida.");
            return Data.contas[myIndex];
        }

        private void notificacao(string remet, string dest, double valor)
        {
            Console.WriteLine($"O {remet} enviou R$ {valor} para ${dest}");
        }
    }
}
