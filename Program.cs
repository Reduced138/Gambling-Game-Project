using System;
namespace Coding_Tutorials
{
    internal class Program
    
    {
        private const int V = 0;
        static void Main(string[] args)
        {
            // Console Ttitle
            Console.Title = "Gambling: The Game";
            //Variables
            Random numberGen = new Random();
            Random billRandom = new Random();
            int roll = 0;
            int attempts = 0;
            int Money = 10;
            int days = 0;
            int bill = 0;
            //intro
            Console.WriteLine("Welcome to the gambling life!");
            Console.WriteLine("Loading game...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Roll the Dice? (Press enter to roll and type Yes to start)");
            String? answer = Console.ReadLine();
            if(answer == "Yes")
            {
              goto ROLL;
            } 
            //bill check 
            ROLL:;
            Start:;
            if(days == 3)
            {
              Console.WriteLine("You need to pay your bills!");
            }
            // rolling  
            Console.Clear();
            Console.WriteLine("Your numbers are (press enter to roll) ");
            while(roll != 6) 
            {
              Console.ReadKey(); 
              roll = numberGen.Next(1, 7);
              Console.WriteLine("You rolled: " + roll);
              attempts++;      
            }
              Console.WriteLine("It took you " + attempts + " attemps to roll a six");
              //Win or loss
              if(attempts <= 4)
              {
                Console.WriteLine("You Win!");
                Money++;
                goto MOney;
              }
              else
              {
                Console.WriteLine("You lose!");
                Money--;
                goto MOney;
              }
              //Money Counter and retry 
              MOney:;
              //! Crashes when pressing enter twice without entering a number 
              Console.WriteLine("do you want to stop, try again or goto the bank? (1 = try again 2 = stop 3 = The bank), total Money is $" + Money);
              int num = Convert.ToInt32(Console.ReadLine());
              switch (num)
              {
                case 1:
                Console.WriteLine("sure thing!");
                days++;
                roll = 0;
                attempts = 0;
                goto Start;
                case 2:
                Console.WriteLine("Bye! (press any button to leave)");
                break;
                case 3:
                Console.WriteLine("Ok, Heading to the bank now");
                goto bank;
              }

            
            //The bank
            bank:;
            // Bank interface
            Console.WriteLine("Welcome to the bank! what would you like to check? 1 = bills");
            int num1 = Convert.ToInt32(Console.ReadLine());
            switch (num1)
            {
              case 1:
              Console.ReadKey(); 
              bill = numberGen.Next(1, 30);
               Console.WriteLine("you have " + bill ," in bills");
               days++;
               roll = 0;
               attempts = 0;
               System.Threading.Thread.Sleep(500); 
               Console.Clear();
               goto ROLL;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //wait before closing
            Console.ReadKey();
        }

    }
}