using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasic
{
    public class StringBuilder
    {
       
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder("Hello to All");
            // or

            StringBuilder sb2 = new StringBuilder(20);// capacity --> max no of characters that we want to store

            // or



            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());

            sb.Append("Good Morning");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());

            sb.Insert(5, "TEST DATA");
            sb.Remove(5, 4);

            sb.Replace("DATA", "new data");
            Console.WriteLine(sb);


            StringBuilder sb3 = new StringBuilder("You amount is ");

            //sb3.AppendFormat("{0:C}", 25000); // C --> currency

            Console.WriteLine(sb3);

        }
    }
}
