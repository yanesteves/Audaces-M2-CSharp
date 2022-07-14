using BancoCentral.Dapper;
using BancoCentral.Entities;
using BancoCentral.UI;
using System;
using System.Collections.Generic;
using static System.Console;
namespace BancoCentral
{
    class Program
    {
        static Conta conta;

        static void Main(string[] args)
        {
            WriteLine("=========================== BANCO ===========================");            
            WriteLine("Em que conta você deseja acessar? Informe agência e conta \n");
            Write("Agência: ");
            var _agencia = ReadLine();
            Write("Conta: ");
            var _conta = ReadLine();
            
            IContasRepository contasRepository = new IContasRepository();            
            conta = contasRepository.getConta(_agencia, _conta);
            Clear();
            if (conta != null)
            {
                while (true)
                {
                    
                    Menu.menuPrincipal();
                    var op = ReadKey();
                    Clear();
                    if (op.Key > ConsoleKey.D3) continue;
                    if (op.Key == ConsoleKey.D0) break;

                    if (op.Key == ConsoleKey.D1) { contasRepository.verSaldo(conta); }
                    else if (op.Key == ConsoleKey.D2) {
                        var dadosTransferencia = Menu.menuTransferencia(conta);
                        conta = contasRepository.transferirPix(conta, dadosTransferencia);
                    }
                    else if (op.Key == ConsoleKey.D3) { }

                    Console.Read();
                }
            } 
            else
            {
                WriteLine("Sua conta não está ativa ou não existe.");
            }              
            ReadKey();
        }
    }
}

