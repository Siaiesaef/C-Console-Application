// input 1/////////////
// 300 
//////////////////////

// expected ouput 1//
// Hexadecimal = 12C
//////////////////////

// actual output 1////
// Hexadecimal = 12C
/////////////////////



// input 2////////////
// 55
//////////////////////

// expected ouput 2///
// Hexadecimal = 37
//////////////////////

// actual ouput 2///
// Hexadecimal = 37
//////////////////////


// input 3 //////////
// 655
////////////////////

// expected ouput 3///
// Hexadecimal = 28F
//////////////////////

// actual ouput 3///
// Hexadecimal = 28F
//////////////////////


// input 4 //////////
// 1200
/////////////////////

// expected ouput 4///
// Hexadecimal = 4B0
//////////////////////

// actual ouput 4///
// Hexadecimal = 4B0
//////////////////////



// input 5 //////////
// 0
/////////////////////

// expected ouput 5///
// Hexadecimal = 0
//////////////////////

// actual ouput 5///
// Hexadecimal = 0
//////////////////////

namespace coursework
{
    //new file to keep everything seperate
    //creating hexConverter class
    public class HexConverter
    {
        public static void Run() 
        {
            bool runAgain=true;
            while(runAgain)
            {
                //makes sure a number is entered
                //no negatives
                int wNumber;
                string inputWNumber;
                bool wNumberValid=true;
                do
                {
                    Console.WriteLine("Enter a positive whole number: ");
                    inputWNumber = Console.ReadLine().Trim();

                    if(int.TryParse(inputWNumber, out wNumber) && wNumber >= 0)
                    {
                        wNumberValid=false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive whole number!");
                    }
                }while(wNumberValid);

                //creates list for remainders
                List<int> remainders = new List<int>();

                //does the hex steps for changing to a hex number from decimal
                int remainder;
                do
                {
                    remainder = wNumber % 16;
                    remainders.Add(remainder);

                    wNumber /= 16;
                }
                while (wNumber != 0);

                //reverses the remainders list so that its written right to left
                remainders.Reverse();

                string hexValue = "";
                //goes through each element in remainders list and converts it to the hexadecimal number/letter
                foreach (int r in remainders)
                {
                    //reference
                    hexValue += r.ToString("X");
                }

                Console.WriteLine($"Hexadecimal = {hexValue}");

                string answer;
                bool answerValid=true;
                do
                {
                    Console.WriteLine("Would u like to convert another number? (yes/no)");
                    answer=Console.ReadLine().Trim().ToLower();

                    if (answer == "yes")
                    {
                        answerValid=false;
                    }
                    else if (answer == "no")
                    {
                        runAgain=false;
                        answerValid=false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input of yes or no!");
                    }
                }while(answerValid);
            }
        }
    }
}