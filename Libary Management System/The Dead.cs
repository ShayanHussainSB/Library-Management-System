using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_Management_System
{
    class The_Dead:Libary
    {
        public override void Book_Name()
        {
            Console.WriteLine("NAME : The Dead");
        }

        public override void Book_price()
        {
            Console.WriteLine("Price : 10.22$");
        }

        public override void Book_adddition()
        {
            Console.WriteLine("Writter : Ammar");
        }

        public override void Book_Contact()
        {
            Console.WriteLine("CONTACT : 0213525845");
        }
    }
}
