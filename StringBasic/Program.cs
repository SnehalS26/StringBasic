using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            str1 = "Hello to all";
            string str2 = " Good Night";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            Console.WriteLine(str1.Length);
            string str3 = string.Concat(str1, str2);
            Console.WriteLine(str3.IndexOf('o'));
            Console.WriteLine(str3.LastIndexOf('o'));
            Console.WriteLine(str3);

            string str4 = str3.Substring(2, 6);
            Console.WriteLine(str4);

            Console.WriteLine(String.IsNullOrEmpty(str4));

            // string str5 = string.Empty;
            string str5 = null;
            Console.WriteLine(string.IsNullOrEmpty(str5));

            Console.WriteLine("Enter name");
            string s = Console.ReadLine();
            Console.WriteLine(string.IsNullOrEmpty(s));
            //char[] ch= str1.ToCharArray();
            // for (int i = 0; i < ch.Length; i++)
            // {
            //     Console.WriteLine(ch[i]);
            // }



        }
    }
}
