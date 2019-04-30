using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.WriteLine("Hello user, What is your name?");
            // string name = Console.ReadLine().ToLower();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            // Console.WriteLine("Hello, " + name + "." + " It sounds like " + name + " is " + age + " years old");
            // Console.WriteLine($"Hello, {name}. It sounds like {name} is {age} years old");
            // Console.WriteLine("Hello, {0}. It sounds like {0} is {1} years old", name, age);
            // int myNum = 37;
            // myNum = myNum * 2;
            // myNum *= 2;

            // int otherNum = 8;
            //This isn't working
            // if (name.ToLower() == "patrick" && age == "37")
            // {
            //     Console.WriteLine("You're the best");
            // } 
            // else if (name.ToLower() == "zach")
            // {
            //     Console.WriteLine("Wazzzup Bossman!!!!!");
            // } 
            // else 
            // {
            //     System.Console.WriteLine("Yo dawg I heard you like else's");
            // }
            // switch (name)
            // {
            //     case "patrick":
            //         System.Console.WriteLine("You Rock");
            //         break;
            //     case "zach":
            //     case "jake":
            //         System.Console.WriteLine("Yo Bossman");
            //         if (name == "jake"){
            //             System.Console.WriteLine("Good luck sleeping");
            //         }
            //         break;
            //     default:
            //         System.Console.WriteLine("I don't know you");
            //         break;

            // }

            int intAge = 0;

            if (Int32.TryParse(age, out intAge))
            {
                if (intAge > 20) 
                {
                    System.Console.WriteLine("Cool, welcome to the club");
                }
                else
                {
                System.Console.WriteLine("Go back to school, kid");
                }
                
            }
            else
            {
                System.Console.WriteLine("Invalid input");
            }

            System.Console.WriteLine("Goodbye");
        }
    }
}
