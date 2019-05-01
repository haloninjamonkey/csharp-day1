using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Hello Patrick");
            // Console.WriteLine("Hello user, What is your name?");
            // string name = Console.ReadLine().ToLower();
            // Console.WriteLine("How old are you?");
            // string age = Console.ReadLine();
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

            // int intAge = 0;

            // if (Int32.TryParse(age, out intAge))
            // {
            //     if (intAge > 20) 
            //     {
            //         System.Console.WriteLine("Cool, welcome to the club");
            //     }
            //     else
            //     {
            //     System.Console.WriteLine("Go back to school, kid");
            //     }
                
            // }
            // else
            // {
            //     System.Console.WriteLine("Invalid input");
            // }

            // for (int i = 0; i < 100; i++) {
            //     // int num = 0;
            //     // num += i;
            //     if(i == 3){
            //         System.Console.WriteLine("i is equal to 3");
            //         continue;
            //     }
            //     System.Console.WriteLine("i is not 3, it is " + i);
            //     if (i == 11){
            //         break;
            //     }
            // }
            // int i = 0;
            // while(i < 100){
            //     System.Console.Write('.');
            //     i++;
            // }
            Random num = new Random();
            int setNumber = num.Next(1,101);
            // System.Console.WriteLine(setNumber);
            for(int i = 5; i > 0; i--){
                System.Console.WriteLine("Guess a number between 1 and 100");
                string userGuess = Console.ReadLine();
                int intGuess = 0;                
                if (Int32.TryParse(userGuess, out intGuess)){
                    if (intGuess != setNumber){
                        if(i > 1 && intGuess > setNumber){
                            System.Console.WriteLine("Guess lower, you have {0} tries left", (i-1));
                        } else if (i > 1 && intGuess < setNumber) {
                            System.Console.WriteLine("Guess higher, you have {0} tries left", (i-1));
                        } else {
                            System.Console.WriteLine("You have no more guesses, you did not guess correctly. The number is {0}.", setNumber);
                        }
                    } else if (intGuess == setNumber){
                        System.Console.WriteLine("You win!");
                        break;
                    }
                } else {
                    System.Console.WriteLine("Integers only, please");
                }
            }
                    
                
            System.Console.WriteLine("Goodbye");
        }
    }
}
