using System;

namespace ConsoleApp.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHello("Aqil","Abbasov",22);
            //SayHello("Akif","Abisov",33);

            //string fullText = $"Salam,Aqil Abbasov / 27 yash!";


            //Console.WriteLine(fullText);
            l1:
            Console.Write("Eded:");
            string aStr = Console.ReadLine();
            double a;
            try
            {
                a = Convert.ToDouble(aStr);
            }
            catch (Exception)
            {
                Console.WriteLine("Yeniden Eded Daxil Et");
                goto l1;
            }

            double c = Power(a);

            Console.WriteLine(c);

            Console.Title = $"Result: {c}";

            Console.ReadKey();
        }

        static double Power (double a)
        {
            double cavab = a * a;
            return cavab;
        }

        //static string SayHello(string name,string surname,int age)
        //{
        //   // Console.WriteLine($"Salam,{name} {surname} / {age} yash!");

        //    string fullText = $"Salam,{name} {surname} / {age} yash!";
            

        //    return fullText;
        //}
       
    }
}
