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
        public delegate string MyDelegat(string message);
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите 1 или 2");            
            string value = Console.ReadLine();           

            try
            {
                switch (value)
                {
                    case "1":
                        MyDelegat myDelegat = SortArray;
                        string meaning = myDelegat.Invoke(value);
                        break;
                    case "2":
                        MyDelegat myDelegat1 = SortArray1;
                        string meaning1 = myDelegat1.Invoke(value);
                        break;
                    default:
                        throw new MyException("Вы выели неправильный символ!");                                      
                }                
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
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
