using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9_modul
{
    internal class Program
    {
        public class MyException : Exception
        {
            public MyException()
            { }

            public MyException(string message)
                : base(message)
            { }
        }
        static void Main(string[] args)
        {
            MyException myException = new MyException();
            FileNotFoundException file = new FileNotFoundException();
            DriveNotFoundException drive = new DriveNotFoundException();
            KeyNotFoundException key = new KeyNotFoundException();
            NotImplementedException metod = new NotImplementedException();

            Object[] Array = new Object[] { myException, file, drive, key, metod };
            try
            {
                
            }
            catch (MyException ex) 
            {
                ex =(MyException)Array[0];
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException e2)
            {
                e2 = (FileNotFoundException)Array[2];
                Console.WriteLine(e2.Message);
            }
            catch (DriveNotFoundException e3) 
            {
                e3 = (DriveNotFoundException)Array[2];
                Console.WriteLine(e3.Message);
            }
            catch (KeyNotFoundException e4)
            {
                e4 = (KeyNotFoundException)Array[3];
                Console.WriteLine(e4.Message);
            }
            catch (NotImplementedException e5) 
            {
                e5 = (NotImplementedException)Array[4];
                Console.WriteLine(e5.Message);
            }
            Console.ReadLine();
        }
    }
}
