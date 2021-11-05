using System;

namespace MetodosEstaticosEDeInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity.SetNextSerialNo(1000);

            Entity e1 = new Entity();
            Entity e2 = new Entity();

            Console.WriteLine(e1.GetSerialNo());
            Console.WriteLine(e2.GetSerialNo());
            Console.WriteLine(Entity.GetNextSeralNo());
        }
    }

    class Entity
    {
        static int s_nextSealNo;
        int _seralNo;

        public Entity()
        {
            _seralNo = s_nextSealNo++;
        }

        public int GetSerialNo()
        {
            return _seralNo;
        }

        public static int GetNextSeralNo()
        {
            return s_nextSealNo;
        }

        public static void SetNextSerialNo(int value)
        {
            s_nextSealNo = value;
        }
    }
}
