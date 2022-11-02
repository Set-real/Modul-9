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
            catch (Exception e1) when (e1.Message == Array[1])
            {     
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2) when (e2.Message == Array[2])
            {
                Console.WriteLine(e2.Message);
            }
            catch (Exception e3) when (e3.Message == Array[3])
            {
                Console.WriteLine(e3.Message);
            }
            catch (Exception e4) when (e4.Message == Array[4])
            {
                Console.WriteLine(e4.Message);
            }
            catch (Exception e5) when (e5.Message == Array[5])
            {
                Console.WriteLine(e5.Message);
            }
            Console.ReadLine();
        }
    }
}
