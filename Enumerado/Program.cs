using System;

namespace Enumerado
{

    public enum Semaforo
    {
        Verde, Amarelo, Vermelho
    }
    [Flags]
    public enum Seasons
    {
        none = 0,
        summer = 1,
        autumn = 2,
        winter = 4,
        spring = 8,

        all = summer | autumn | winter | spring
    }
    class Program
    {
        static void Main(string[] args)
        {
            var estado = Semaforo.Verde;

            if (estado == Semaforo.Verde)
            {
                Console.WriteLine("Siga em frente");
            }
            else if (estado == Semaforo.Amarelo)
            {
                Console.WriteLine("Atenção, sinal amarelo");
            }
            else
            {
                Console.WriteLine("Pare!");
            }

            var Spring = Seasons.spring;
            var startingOnEquinox = Seasons.spring | Seasons.autumn;
            var theYear = Seasons.all;

            Console.WriteLine(Spring);
            Console.WriteLine(startingOnEquinox);
            Console.WriteLine(theYear);
        }
    }
}
