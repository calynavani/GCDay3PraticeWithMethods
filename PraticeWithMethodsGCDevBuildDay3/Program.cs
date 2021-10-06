using System;

namespace PraticeWithMethodsGCDevBuildDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Best Practices with methods:
            // 1) Methds should be reuseable as possible
            // 2) Methods should generally (outside of the main method) have on single job and stick to just that job
            // 3) Methods should account for the most likely inputs(parameters)


            bool goOn = true;
            while (goOn == true)
            {
                // 1) Getting user input******************************************************************
                // Prompt the user
                // Read the input
                string result1 = GetInput("Please input your age: ");
                int age = int.Parse(result1);
                Console.WriteLine(age);

                string result2 = GetInput(" What is your name? ");
                Console.WriteLine(result2);


                // 2) Countinue Loop************************************************************************
                //Ask user woud you like to continue Y/N
                // 3 cases to code for:
                // user says Y -> Continue
                // N-> Stop the main loop
                //Anything else -> Try getting input again

                // 3) Representing Math Formulas************************************************************************************
                //Area
                //Perimeter
                //Calculates Paint Cans


                int x = 7;
                float f = 1.5f; //Floats must end in a f
                double area = GetArea(f, 5); // if something is a doube, it will accept all other number tyes.
                Console.WriteLine($"Area: {area}");

                // 4) Range Checking-checking if the inputs value falls between 1 and 100,*******************************************************************
                // used to do validation
                //Method calls are process in a Last in First out order 
                int min = int.Parse(GetInput("Please Input a minimum number: "));
                int max = int.Parse(GetInput("Please  input a max numer: "));
                int num = int.Parse(GetInput("Please input a numbebr to check if it is in range: "));

                bool inRange = RangeCheck(min, max, num);
                Console.WriteLine(inRange);

                goOn = Continue(); // see 2)
            }
        }
        //You could put in a second parameter telling GetInput what datatype you wish to convert to.
        public static string GetInput(string promptToUser)
        {
            Console.Write(promptToUser);
            string userOutput = Console.ReadLine().ToLower();

            return userOutput;
        }


        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? Y/N ");

            if(answer == "y")
            {
                return true;
            }
            else if(answer=="n")
            {
                Console.WriteLine("Goodbye!");
                return false;


            }
            else
            {
                Console.WriteLine("I'm sorry I didnt understand that");
                Console.WriteLine("Let's try again.");
                return Continue(); //this is called a recursion -> calling a method inside it's self
            }
            
        }
        
        public static double GetArea(double width, double length)
        {
            double area = length * width;
            return area;


        }

        public static bool RangeCheck(int min, int max, int num)
        {
            if (min < max)
            {


                if (num > min && num < max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                Console.WriteLine($"Min {min} is greater than max {max} so the range can't be checked!");
                return false;
            }
        }
    }
}
