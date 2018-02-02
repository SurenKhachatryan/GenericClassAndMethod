using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //All Type
            Console.WriteLine(MyEquals1.EqualsAllType("hello", "hello"));       //True
            Console.WriteLine(MyEquals1.EqualsAllType(4294967295, 4294967295)); //True
            Console.WriteLine(MyEquals1.EqualsAllType((char)63, 'A'));          //False
            Console.WriteLine(MyEquals1.EqualsAllType(false, false));           //True

            //For Reference Type Only
            Console.WriteLine(MyEquals1.EqualsRefernceType("", ""));             //True
            Console.WriteLine(MyEquals1.EqualsRefernceType("Hello", "Bob"));     //False

            //For Value Type Only
            Console.WriteLine(MyEquals1.EqualsValueType(56, 80));                //False
            Console.WriteLine(MyEquals1.EqualsValueType(58.8, 58.8));            //True



            Console.ReadKey();
        }
    }
}
