using BancoCentral.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral.UI
{
    public static class Menu
    {
        public static void menuPrincipal()
        {
            Console.Clear();
            Console.WriteLine(
                "1 - Ver Saldo\n" +
                "2 - Realizar Transferência\n" +
                "3 - PIX\n" +
                "0 - Sair\n"
            );
        }

        public static string[] menuTransferencia(Conta conta)
        {
            string[] dados = new string[2];
            Console.Clear();
            Console.WriteLine("==== Área PIX ====");
            Console.Write($"Informe o valor da transferência (Saldo disponível em conta R$ {conta.Saldo}): ");
            dados[0] = Console.ReadLine();
            Console.Write($"Para quem você quer transferir R$ {dados[0]}: ");
            dados[1] = Console.ReadLine();            
            return dados;
        }
    }
}
