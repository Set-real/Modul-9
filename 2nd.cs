using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }
    internal class Program
    {
        private string Value
        {
            get { return Value; }
            set
            {
                if (Value != "1" || Value != "2")
                {
                    throw new MyException("Вы ввели некоректное значение");
                }
                else
                {
                    Value = value;
                }
            }
        }
        public delegate string MyDelegat(string message);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 или 2");
            string Value = Console.ReadLine();

            try
            {
                if (Value == "1")
                {
                    MyDelegat myDelegat = SortArray;
                    string meaning = myDelegat.Invoke(Value);
                }
                if (Value == "2")
                {
                    MyDelegat myDelegat = SortArray1;
                    string meaning = myDelegat.Invoke(Value);
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static public string SortArray(string resalt)
        {
            string[] NameArray = new string[] { "Павел", "Илья", "Марина", "Владислав", "Тарас" };
            {
                Array.Sort(NameArray);
                Console.WriteLine(NameArray[0]);
                return NameArray[0];
            }
        }
        static public string SortArray1(string resalt)
        {
            string[] NameArray = new string[] { "Павел", "Илья", "Марина", "Владислав", "Тарас" };
            Array.Sort(NameArray);
            Console.WriteLine(NameArray[NameArray.Length - 1]);
            return NameArray[NameArray.Length - 1];
        }
    }
}
