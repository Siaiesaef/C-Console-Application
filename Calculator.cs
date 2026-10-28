// input 1 ///////////////////////////////////////////////

// Enter appliance name:     Kitchen tap

// 1) time-based appliances
// 2) cycle-based appliances
// Enter your mode of use (1 or 2):   1

// What's the price per 1000L for your Kitchen tap: 
// If you dont know please enter 0   2.5

// What's the flow rate for your Kitchen tap:  9

// How many minutes a day do you use your Kitchen tap: 10
//////////////////////////////////////////////////////////

// expected output 1 ////////////////////////////////////
// Appliance Name: Kitchen tap
// -------------------------------------------
// Your daily usage is: 90L
// Your monthly water usage is: 2700L
// Your yearly water usage is: 32850L

// Your price per 1000L:
// -------------------------------------------
// Your estimated daily cost is: £0.23
// Your estimated monthly cost is: £6.75
// Your estimated yearly cost is: £82.13
//////////////////////////////////////////////////////

// actual output 1 ///////////////////////////////////
// Appliance Name: Kitchen tap
// -------------------------------------------
// Your daily usage is: 90L
// Your monthly water usage is: 2700L
// Your yearly water usage is: 32850L

// Your price per 1000L:
// -------------------------------------------
// Your estimated daily cost is: £0.22
// Your estimated monthly cost is: £6.75
// Your estimated yearly cost is: £82.12
/////////////////////////////////////////////////






// input 2 ///////////////////////////////////////////////

// Enter appliance name: Washing machine

// 1) time-based appliances
// 2) cycle-based appliances
// Enter your mode of use (1 or 2):   2

// What's the price per 1000L for your Washing machine: 
// If you dont know please enter 0   2.5

// What's the volume per cycle for your Washing machine:  50

// How many cycles a day would your Washing machine do: 3
//////////////////////////////////////////////////////////

// expected output 2//////////////////////////////////////
// Appliance Name: Washing machine
// -------------------------------------------
// Your daily usage is: 150L
// Your monthly water usage is: 4500L
// Your yearly water usage is: 54750L

// Your price per 1000L:
// -------------------------------------------
// Your estimated daily cost is: £0.38
// Your estimated monthly cost is: £11.25
// Your estimated yearly cost is: £136.88
//////////////////////////////////////////////////////////

// actual output 2//////////////////////////////////////
// Appliance Name: Washing machine
// -------------------------------------------
// Your daily usage is: 150L
// Your monthly water usage is: 4500L
// Your yearly water usage is: 54750L

// Your price per 1000L:
// -------------------------------------------
// Your estimated daily cost is: £0.38
// Your estimated monthly cost is: £11.25
// Your estimated yearly cost is: £136.88
//////////////////////////////////////////////////////////





// input 3 ///////////////////////////////////////////////

// Enter appliance name: Shower

// 1) time-based appliances
// 2) cycle-based appliances
// Enter your mode of use (1 or 2):   1

// What's the price per 1000L for your Shower: 
// If you dont know please enter 0   2.99

// What's the flow rate for your Shower:  5

// How many minutes a day do you use your Shower: 12
//////////////////////////////////////////////////////////

// expected output 3//////////////////////////////////////
// Appliance Name: Shower
// Your daily usage is: 60L
// Your monthly water usage is: 1800L
// Your yearly water usage is: 21900L

// Your price per 1000L:
// -------------------------------------------
// Your estimated daily cost is: £0.18
// Your estimated monthly cost is: £5.38
// Your estimated yearly cost is: £65.48
///////////////////////////////////////////////////

// actual output 3//////////////////////////////////////
// Appliance Name: Shower
// Your daily usage is: 60L
// Your monthly water usage is: 1800L
// Your yearly water usage is: 21900L

// Your price per 1000L:
// -------------------------------------------
// Your estimated daily cost is: £0.18
// Your estimated monthly cost is: £5.38
// Your estimated yearly cost is: £65.48
///////////////////////////////////////////////////






// input 4 ////////////////////
// Enter appliance name: Shower

// 1) time-based appliances
// 2) cycle-based appliances
// Enter your mode of use (1 or 2):   1

// What's the price per 1000L for your Shower: 
// If you dont know please enter 0   0

// What's the flow rate for your Shower:  5

// How many minutes a day do you use your Shower: 12
///////////////////////////////////////

// expected output 4///////////////////////
// Appliance Name: Shower
// Your daily usage is: 60L
// Your monthly water usage is: 1800L
// Your yearly water usage is: 21900L
//////////////////////////////////////////

// actual output 4///////////////////////
// Appliance Name: Shower
// Your daily usage is: 60L
// Your monthly water usage is: 1800L
// Your yearly water usage is: 21900L
//////////////////////////////////////////

namespace coursework
{ 
    //new file to keep everything seperate
    //creating calculator class
    public class Calculator
    {
        public static void Run()
        {
            bool nameNotValid = true;
            string name;
            //do while loop to check the user has entered an appliance name
            do
            {
                Console.WriteLine("Enter the appliance name: ");
                name = Console.ReadLine();

                //searched up string.IsNullOrEmpty
                //https://turbo360.com/blog/how-to-check-if-a-string-is-null-or-empty-in-logic-apps#:~:text=This%20is%20relatively%20easy%20to,empty%22%3B%20else%20return%20String.
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("You have not provided an appliance name!");
                    Console.WriteLine("Please enter the name of your appliance");
                }
                else
                {
                    nameNotValid = false;
                }
            } while (nameNotValid);

            bool invalidMode = true;
            string mode_of_use ;
            //do while loop to ask again if other value has been given
            do
            {
                Console.WriteLine("1) time-based appliances");
                Console.WriteLine("2) cycle-based appliances");
                Console.WriteLine("Enter your mode of use (1 or 2): ");
                mode_of_use = Console.ReadLine().Trim(); //trim gets rid of accidental spaces

                //makes sure the do while loop repeats if the input is not 1 or 2
                if (mode_of_use == "1" || mode_of_use == "2")
                {
                    invalidMode = false;
                }
                else
                {
                    Console.WriteLine("Invalid input! \n Please enter a value 1 or 2");
                }
            } while (invalidMode);

            // //no neg values
            // bool negPrice = true;
            // double water_price;
            // string inputWaterPrice;
            // do {
            //     Console.WriteLine($"What's the water price for your {name}: ");
            //     inputWaterPrice = Console.ReadLine().Trim();

            //     if (double.TryParse(inputWaterPrice, out water_price) && water_price > 0)
            //     {
            //         negPrice = false;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Please enter a valid price (positive number)");
            //     }
            // } while (negPrice);

            //error check for neg values
            double price_per_1000L;
            bool invalidPrice=true;
            string inputPricePer1000L;
            do
            {
                Console.WriteLine($"What's the price per 1000L for your {name}: ");
                Console.WriteLine("If you dont know please enter 0");
                inputPricePer1000L = Console.ReadLine().Trim();
                
                if(double.TryParse(inputPricePer1000L, out price_per_1000L))
                {
                    invalidPrice=false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid price (number)");
                }

            }while(invalidPrice);

            //for time-based appliances 
            if (mode_of_use == "1")
            {
                double daily_usage_time, monthly_wtr_use_t, yrly_wtr_use_t, flow_rate, mins_per_day;
                string inputFlowRate;
                bool invalidFlowRate=true;
                do
                {
                    Console.WriteLine($"What's the flow rate for your {name}: ");
                    inputFlowRate = Console.ReadLine().Trim();

                    if (double.TryParse(inputFlowRate, out flow_rate) && flow_rate > 0)
                    {
                        invalidFlowRate=false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid flow rate (poistive number)");
                    }

                }while(invalidFlowRate);

                //error check for values above zero and below 1441
                string inputMinsPerDay;
                bool invalidMinsPerDay=true;
                do
                {
                    Console.WriteLine($"How many minutes a day do you use your {name}: ");
                    inputMinsPerDay = Console.ReadLine().Trim();
                    if (double.TryParse(inputMinsPerDay, out mins_per_day) && mins_per_day>0 && mins_per_day<1442)
                    {
                        invalidMinsPerDay=false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number of minutes per day (poistive number thats less than 1442)");
                    }
                }while(invalidMinsPerDay);

                daily_usage_time = flow_rate * mins_per_day;
                monthly_wtr_use_t = daily_usage_time * 30;
                yrly_wtr_use_t = daily_usage_time * 365;

                //presents values
                Console.WriteLine($"Appliance Name: {name}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Your daily usage is: {Math.Round(daily_usage_time, 2)}L");
                Console.WriteLine($"Your monthly water usage is: {Math.Round(monthly_wtr_use_t, 2)}L");
                Console.WriteLine($"Your yearly water usage is: {Math.Round(yrly_wtr_use_t, 2)}L");
                Console.WriteLine();

                if (price_per_1000L != 0)
                {
                    double est_daily_cost = (daily_usage_time / 1000) * price_per_1000L;
                    double est_monthly_cost = (monthly_wtr_use_t / 1000) * price_per_1000L;
                    double est_yrly_cost = (yrly_wtr_use_t / 1000) * price_per_1000L;
                    
                    //presents values
                    Console.WriteLine("Your price per 1000L: ");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Your estimated daily cost is: £{Math.Round(est_daily_cost, 2)}");
                    Console.WriteLine($"Your estimated monthly cost is: £{Math.Round(est_monthly_cost, 2)}");
                    Console.WriteLine($"Your estimated yearly cost is: £{Math.Round(est_yrly_cost, 2)}");
                }

            }

            //for cycle-based appliances
            else if (mode_of_use == "2")
            {
                double daily_usage_cycle, monthly_wtr_use_c, yrly_wtr_use_c, volume_per_cycle, cycles_per_day;

                string inputVolumePerCycle;
                bool invalidVolumePerCycle=true;
                do
                {
                    Console.WriteLine($"What's the volume per cycle for your {name}: ");
                    inputVolumePerCycle = Console.ReadLine().Trim();

                    if(double.TryParse(inputVolumePerCycle, out volume_per_cycle) && volume_per_cycle > 0)
                    {
                        invalidVolumePerCycle=false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid volume per cycle (poistive number)");
                    }
                }while(invalidVolumePerCycle);

                //error check for neg numbers and zero
                string inputCyclesPerDay;
                bool invalidCyclesPerDay=true;
                do
                {
                    Console.WriteLine($"How many cycles a day would your {name} do: ");
                    inputCyclesPerDay = Console.ReadLine().Trim();

                    if(double.TryParse(inputCyclesPerDay, out cycles_per_day) && cycles_per_day > 0)
                    {
                        invalidCyclesPerDay=false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number of cycles per day (poistive number)");
                    }
                }while(invalidCyclesPerDay);

                daily_usage_cycle = volume_per_cycle * cycles_per_day;
                monthly_wtr_use_c = daily_usage_cycle * 30;
                yrly_wtr_use_c = daily_usage_cycle * 365;

                Console.WriteLine($"Appliance Name: {name}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Your daily usage is: {Math.Round(daily_usage_cycle, 2)}L");
                Console.WriteLine($"Your monthly water usage is: {Math.Round(monthly_wtr_use_c, 2)}L");
                Console.WriteLine($"Your yearly water usage is: {Math.Round(yrly_wtr_use_c, 2)}L");
                Console.WriteLine();

                if (price_per_1000L != 0)
                {
                    double est_daily_cost = (daily_usage_cycle / 1000) * price_per_1000L;
                    double est_monthly_cost = (monthly_wtr_use_c / 1000) * price_per_1000L;
                    double est_yrly_cost = (yrly_wtr_use_c / 1000) * price_per_1000L;

                    Console.WriteLine("Your price per 1000L: ");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Your estimated daily cost is: £{Math.Round(est_daily_cost, 2)}");
                    Console.WriteLine($"Your estimated monthly cost is: £{Math.Round(est_monthly_cost, 2)}");
                    Console.WriteLine($"Your estimated yearly cost is: £{Math.Round(est_yrly_cost, 2)}");
                }

            }

            //if user enters anything thats not one or two
            else
            {
                
            }
        }
    }
}