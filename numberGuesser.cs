using System;

namespace numberGuesser {
    class MainClass {
        public static void Main(string[] args) {
            //string name = "nore";
            //int age = 31;
            //Console.WriteLine("{0} is {1}", name, age);

            GetAppInfo(); // Run getAppInfo function to get info

            GreetUser(); // Ask for users name and greet


            while (true) {
                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("guess a number between 1 and 10...");

                // While guess is not correct
                while (guess != correctNumber) {
                    string input = Console.ReadLine();

                    // Make sure guess is a number
                    if (!int.TryParse(input, out guess)) {

                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber) {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }


                // Print error message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT! :-)");

                // Ask to play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    Console.WriteLine("Okay cool, lets play again!");
                    continue;
                } else if (answer == "N") {
                    Console.WriteLine("Okay, Bye!");
                    return;
                }

            }

        }

        // Get and display app info
        static void GetAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nore McVay";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text colour
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game....", inputName);
        }

        //Print colour message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text colour
            Console.ForegroundColor = color;

            // Tell user to choose an actual number
            Console.WriteLine(message);

            // Reset text colour
            Console.ResetColor();
        }
    }
}
