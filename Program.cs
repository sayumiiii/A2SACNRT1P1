using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool calc = false;

            while (calc == false)  //start loop 
            {
                string userChoice;

                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Option 1");
                Console.WriteLine("2: Option 2");
                Console.WriteLine("3: Option 3");
                Console.WriteLine("4: Exit");

                Console.Write("Enter the number of your choice: ");
                userChoice = Console.ReadLine();

                /* Declaring Variable */
                if (userChoice == "1")
                {
                    int i = 0;
                    int j = 0;

                    for (i = 1; i <= 25; i++)
                    {
                        Console.WriteLine("Number from 1-25: " + i);
                        if (i % 2 == 0) // if the number is odd,
                        {
                            j = i * 4;  //add 4
                            Console.WriteLine(i + " even number * 4: " + j);
                        }
                        else
                        {
                            if ((i == 3) || (i == 11) || (i == 21))  //if the number is 3,11, or 21 and odd
                            {
                                j = (i + 7) - 3;  // add 7 and substract 3

                                Console.WriteLine(i + " Odd number + 7 - 3: " + j);
                            }
                            else
                            {
                                j = i + 7;  //if number is odd other than 3,11,21
                                Console.WriteLine(i + " Odd number + 7: " + j);
                            }
                        }
                    }
                    Console.ReadKey();
                }
                else if (userChoice == "2")
                {
                    int number_1 = 0;
                    int number_2 = 0;
                    string strNumber_1 = "";
                    string strNumber_2 = "";
                    calc = true;  // CALC will be true

                    while (calc == true)
                    {
                        //prompt user
                        Console.WriteLine("Enter number 1 : ");
                        strNumber_1 = Console.ReadLine();
                        Console.WriteLine("Enter number 2 : ");
                        strNumber_2 = Console.ReadLine();


                        if ((strNumber_1 == "END") || (strNumber_2 == "END"))   //if user enters END
                        {
                            calc = false;  // go to main menu
                        }

                        else
                        {
                            try
                            {
                                number_1 = int.Parse(strNumber_1);  //converting input to int
                                number_2 = int.Parse(strNumber_2);

                                Console.WriteLine("number 1 devided by number 2 : " + number_1 / number_2);  //deviding number 1 by 2
                            }
                            catch (FormatException fEx)  //format Exception 
                            { 
                                Console.WriteLine("Error! Please enter only numerics.");
                            }

                            Console.ReadLine();
                        }
                    }
                }
            }    
        }
    }
}
