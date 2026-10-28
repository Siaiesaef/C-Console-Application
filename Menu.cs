//////////////////////////////////////////////////////////////////////////
//Artificial Intelligence has not been used for any part of the activity//
//////////////////////////////////////////////////////////////////////////
namespace coursework
{
    class Menu
    {
        static void Main(string[] args)
        { 

            //allows the program to end easily when an option to end the program is presented 
            bool running = true;
            while (running)
            {
                //menu screen
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("     Choose one of the following options:");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("a) Household Water Usage & Cost Calculator");
                Console.WriteLine("b) Library Catalogue");
                Console.WriteLine("c) Hexadecimal Converter");
                Console.WriteLine("d) End The Program");
                Console.WriteLine("-----------------------------------------------");

                string input=Console.ReadLine().Trim().ToLower();

                //displays Household Water Usage & Cost Calculator
                if (input == "a")
                {
                    Console.WriteLine("Household Water Usage & Cost Calculator");
                    Calculator.Run();
                    Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                }
                //displays library catalogue
                else if (input == "b")
                {
                    Console.WriteLine("Library Catalogue");
                    LibraryCatalogue.Run();
                    Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                }
                //displays hexadecimal converter
                else if (input == "c")
                {
                    Console.WriteLine("Hexadecimal Converter");
                    HexConverter.Run();
                    Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                }
                else if (input == "d")
                {
                    Console.WriteLine("the program has ended");
                    //ends program
                    running = false;
                }
                //if an input thats not a-d is entered
                else
                {
                    string userinput;

                    //asks user if they would like to choose a valid option
                    do
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Would you like to choose a valid option?(yes or no)");
                        //ToLower converts the whole string to lowercase characters
                        userinput = Console.ReadLine().Trim().ToLower();

                        //makes sure that the user enters yes or no
                        if (userinput != "yes" && userinput != "no")
                        {
                            Console.WriteLine("Please enter yes or no");
                        }
                    }
                    //continues to ask the do part until the user enters yes or no
                    while (userinput != "yes" && userinput != "no");

                    //ends program
                    if (userinput == "no")
                    {

                        Console.WriteLine("Goodbye!");
                        running = false;
                    }

                }
            }
        }
    }
}
