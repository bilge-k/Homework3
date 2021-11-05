using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Askerlik("erkek", 22);
            BeslikSistem(88);
        }
        static void Askerlik(string cinsiyet, int yas)
        {
            string a = "asker kaçağı>:/ ";
            string b = "vatananına milletine hayırlı*";
            if (cinsiyet == "erkek" && yas > 20)
            {
                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void BeslikSistem(int p, double k=0.05)
        {
            double s;
            string d = "Puanınız: ";
           
            s = k * p;
            Console.WriteLine(d+s);

        }
    }
}
