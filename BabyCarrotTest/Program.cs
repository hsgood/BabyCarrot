using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyCarrot.Tools;
using BabyCarrot.Extensions;

namespace BabyCarrotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            //LogManager log = new LogManager();
            LogManager log = new LogManager(null,"_BabyCarrotText");

            log.WriteLine("[Begin Processing]........");

            for (int index=0; index<10; index++)
            {
                //log.WriteLine("Processing: " + index);
                log.Write("Processing: " + index);

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done: " + index);
            }

            log.WriteLine("[End Processing].......");

            //Console.WriteLine(BabyCarrot.Tools.Application.Root);
            //Console.WriteLine(Application.Root);
            //Console.ReadLine();
            **/

            //LogManager log = new LogManager();
            //log.WriteConsole("test");   //확장메소드 호출

            string temp = "12:25";
            Console.WriteLine("IsNumeric  ? : " + temp.IsNumeric());
            Console.WriteLine("IsDateTime ? : " + temp.IsDateTime());

            DateTime tmdate;
            tmdate = new DateTime(2018, 02, 01);
            Console.WriteLine(tmdate.Year +"/"+ tmdate.Month + "의 첫번째 날은 : " + tmdate.FirstDateOfMonth());
            Console.WriteLine(tmdate.Year +"/"+ tmdate.Month + "의 마지막 날은 : " + tmdate.LastDateOfMonth());

            //email 
            

        }


    }

    public static class ExtensionText
    {
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.Write(data);
        }
    }
}
