using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WithoutIf_Else
{
    internal class Program
    {
        // public delegate void HelloFunc(string Message);
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enetr Number");
            Console.WriteLine("Enetr Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter age");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr Contact");
            long Contact=long.Parse(Console.ReadLine());
            int? nullableNum = null;
            string s = null;
            long? c = null;
            String s2 = null;
            string s3= null;
            repete:
            Console.WriteLine("1.Name\r\n2.Age\r\n3.Contact");
            int num= int.Parse(Console.ReadLine());
            Console.Write((num == 1) ? name : s); ;
            Console.Write((num == 2) ? age : nullableNum);
            Console.Write((num == 3) ? Contact : c);
            Console.WriteLine((num >= 4)? "Chose Correct Option" : s3);
            while(num>=4)
            {
                goto repete;
            }
            Console.ReadLine();
        }
    }
       
}
