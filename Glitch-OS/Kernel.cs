using Cosmos.System.Network.IPv4.UDP.DNS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Sys = Cosmos.System;

namespace Glitch_OS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Sucessful Boot, Type 2 Numbers To Add And Get An Answer!");
        }

        protected override void Run()
        {
            Console.WriteLine("Please Enter Number 1 ");
            Console.WriteLine("");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please Enter Number 2 ");
            Console.WriteLine("");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Which Operation Would You Like To Use?");
            Console.WriteLine("");
            Console.WriteLine("You Can Use (mul) For Multiply, (div) For Divide, (add) For Addition, (sub) For Subtraction");
            Console.WriteLine("");
            var operation = Console.ReadLine();
            if (operation == "mul")
            {
                int result = num1 * num2;
                Console.WriteLine("");
                Console.WriteLine("Answer = " + result);
                Console.WriteLine("");
                
            }
            else if (operation == "div")
            {
                int result = num1 / num2;
                Console.WriteLine("");
                Console.WriteLine("Answer = " + result);
                Console.WriteLine("");

            }
            else if (operation == "add")
            {
                int result = num1 + num2;
                Console.WriteLine("");
                Console.WriteLine("Answer = " + result);
                Console.WriteLine("");

            }
            else if (operation == "sub")
            {
                int result = num1 - num2;
                Console.WriteLine("");
                Console.WriteLine("Answer = " + result);
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Unknown Operation, Please Enter Operation Correctly | Error Code: 0x1838");
                Console.WriteLine("");

            }

        }
    }
}
