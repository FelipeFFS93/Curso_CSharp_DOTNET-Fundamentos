using System;

namespace MetodosAVS
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse(3.1415);

            Console.WriteLine(mClasse.RetornarValor()); 
            mClasse.MetodoVirtual();
            mClasse.MetodoEmMinhaClasse();

            Console.WriteLine();

            var mOutraClasse = new MinhaOutraClasse("Felipe");
            Console.WriteLine(mOutraClasse.RetornarValor()); 
            mOutraClasse.MetodoVirtual();
            mOutraClasse.MetodoEmMinhaClasse();

            Console.WriteLine();

            ClasseAbstrata cAbstrata = new MinhaClasse(75.18);
            Console.WriteLine(cAbstrata.RetornarValor());
            cAbstrata.MetodoVirtual();

        }
    }

    public abstract class ClasseAbstrata
    {
        public abstract object RetornarValor();

        public virtual void MetodoVirtual()
        {
            Console.WriteLine("Metodo virtual em classe abstrata.");
        }


    }
    public class MinhaClasse : ClasseAbstrata
    {
        double _value;

        public MinhaClasse(double value)
        {
            _value = value;
        }

        public void MetodoEmMinhaClasse() => Console.WriteLine("Metodo em MinhaClasse");

        public override object RetornarValor()
        {
            return _value;
        }

        public override void MetodoVirtual()
        {
            Console.WriteLine("Metodo virtual em MinhaClasse.");
        }
    }

    public class MinhaOutraClasse : ClasseAbstrata
    {
        string _name;

        public MinhaOutraClasse(string name)
        {
            _name = name;
        }
        public void MetodoEmMinhaClasse() => Console.WriteLine("Metodo em MinhaOutraClasse");

        public override object RetornarValor()
        {
            return _name;
        }

         public override void MetodoVirtual()
        {
            base.MetodoVirtual();
            Console.WriteLine("Metodo virtual em MinhaOutraClasse.");
        }
    }
}
