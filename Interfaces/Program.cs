using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            EditBox editBox = new EditBox();
            IControl control = new EditBox();

            editBox.Paint();
            editBox.Bind("Felipe");
        }
    }

    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox 
    {

    }

    interface IDataBound
    {
        void Bind(string b);
    }

    public class EditBox : IControl, IDataBound
    {
        public void Paint()
        {
            Console.WriteLine("Executando o metodo Paint()");
        }

        public void Bind(string b)
        {
            Console.WriteLine("Executando o metodo Bind()");
            Console.WriteLine(b);
        }
    }
}
