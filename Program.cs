using System;
using System.Collections.Generic;

namespace cSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
/*             List<string> mylist = new List<string>();
            mylist.Add("Hello");
            mylist.Add("World");

            Console.WriteLine(mylist[0] + " " + mylist[1]);
             */
            HelloWorld myWorld = new HelloWorld();
            myWorld.SayHello();
            myWorld.MyNumber = 8;
            Console.WriteLine(myWorld.MyNumber);
        }
        public class HelloWorld
        {
            string message = "Hello World";
/*             public int MyNumber{ get; set; }
 */
            private int myNumber;

            public int MyNumber
            {
                get{ return myNumber; }
                set{ myNumber = value; }
            }
            public void SayHello()
            {
                Console.WriteLine(ChangeMessage());
            }

            private string ChangeMessage()
            {
                return message;
            }
        }
    }

}