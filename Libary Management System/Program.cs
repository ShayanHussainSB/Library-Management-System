using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_Management_System
{
    abstract class Libary
    {
        abstract public void Book_Name();
        abstract public void Book_price();
        abstract public void Book_adddition();
        abstract public void Book_Contact();
    }
    class The_War :Libary
    {
        public override void Book_Name()
        {
            Console.WriteLine("NAME : THE WAR");
        }

        public override void Book_price()
        {
            Console.WriteLine("Price : 20.30$");
        }

        public override void Book_adddition()
        {
            Console.WriteLine("Writter : Shayan M.Hussain");
        }

        public override void Book_Contact()
        {
            Console.WriteLine("CONTACT : 02132855840");
        }
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter Book Name");
            a = Console.ReadLine();
            if (a == "the war" || a == "the dead")
            {
                if (a == "the war")
                {
                    The_War b1 = new The_War();
                    Console.WriteLine("\nDetails OF Books The War\n");
                    b1.Book_Name();
                    b1.Book_price();
                    b1.Book_adddition();
                    b1.Book_Contact();
                }
                else if(a=="the dead")
                {
                    The_Dead b2 = new The_Dead();
                    Console.WriteLine("\nDetails OF Books The Dead\n");
                    b2.Book_Name();
                    b2.Book_price();
                    b2.Book_adddition();
                    b2.Book_Contact();
                }
                else
                {
                    Console.WriteLine("Enter Correct Input");
                }
            }
            Console.ReadKey();
        }
    }
}
