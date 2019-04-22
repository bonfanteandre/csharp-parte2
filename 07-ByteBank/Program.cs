using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(123, 456789);

            Console.WriteLine(contaCorrente.Agencia);
            Console.WriteLine(contaCorrente.Numero);

            ContaCorrente contaCorrente2 = new ContaCorrente(321, 987654);

            Console.WriteLine(contaCorrente2.Agencia);
            Console.WriteLine(contaCorrente2.Numero);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Console.ReadKey();
        }
    }
}
