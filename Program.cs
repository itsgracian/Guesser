using System;

namespace App
{
    //Main class
    class Program
    {
        //Entry m
        static void Main(string[] args)
        {
            // set app vars
            string appName = "Number Gueser";
            string appVersion = "1.0.0";
            string appAuthor = "gracian";

            //change text color
            Console.ForegroundColor =ConsoleColor.Green;
            Console.WriteLine("Your App is {0}: Version {1}: Author {2}",
            appName, appVersion,appAuthor);
            //reset text color
            Console.ResetColor();
           // ask Users name
           Console.WriteLine("What is your name ?");
           //@let first get user info
           string inputName= Console.ReadLine();
           Console.WriteLine("Hello {0} lets pray a game...",inputName);
           Console.WriteLine("Please Enter Your number ?");

           //@set a correct number 
           Random random=new Random();

           int correctNumber=random.Next(1,10);
           int guesNumber = 0;
           //while guesNumber is not equal to correnct number
           while(guesNumber!=correctNumber){
             string input=Console.ReadLine();
              
              //check if input is actual number
              if(!int.TryParse(input, out guesNumber)){
                  Console.ForegroundColor=ConsoleColor.Red;
                  Console.WriteLine("sorry enter an actual number");
                  Console.ResetColor();
                  continue;
              }
             //cast input value into an integer
             guesNumber=Int32.Parse(input);
             //check if guesNumber is not equel to correct number
             if(guesNumber!=correctNumber){
                 Console.ForegroundColor=ConsoleColor.Red;
                 Console.WriteLine("sorry your gues number({0}) is incorrect",guesNumber);
                 //Reset color
                 Console.ResetColor();
             }
           }
           Console.ForegroundColor=ConsoleColor.Blue;
           Console.WriteLine("Woow!! congratulation!! Your guesNumber is correct.");
        }
    }
}
