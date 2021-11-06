using System;

namespace Corresponder
{
    class Program
    {
        public enum Comando
        {
            SystemTest,Start, Stop, Reset
        }
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;

            }

            Comando c = Comando.SystemTest;

            string op = c switch
            {
                Comando.SystemTest => "Realizando testes no sistema...",
                Comando.Start => "Iniciando o sistema...",
                Comando.Stop => "Parando o sistema...",
                Comando.Reset => "Reiniciando o sistema...",
                _ => "Comando invalido."
            };

            Console.WriteLine(op);
        }
    }
}
