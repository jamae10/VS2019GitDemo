 using System;

namespace VS2019GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //sample hello world

            double i = 567.85866; //explicit casting bigger to lower value
            int j;
            j = (int)i;
            Console.WriteLine(j);

            int k = 55; //implicit casting, lower to bigger
            double l = k;
            Console.WriteLine(l);


            float myNum = 5.75F; //float
            Console.WriteLine(myNum);

            //double and float
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("\n" + name);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }
}
 