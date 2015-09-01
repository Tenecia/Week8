using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookchpt11Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Program that checks Leap year 
            System.Console.WriteLine("1. Enter a Year");                        int year = Convert.ToInt32(System.Console.ReadLine()); //under the DateTime Class             if (DateTime.IsLeapYear(year))            {            Console.WriteLine("Is a Leap Year");                        }            else

            Console.WriteLine("Is not a Leap Year");
            //Console.ReadLine();

            //2. Print to console 10 random numbers 
            Console.WriteLine("2. Generating 10 random Numbers"); // using Class Random 
            Random rnd = new Random(); // new creates a new object 
            for (int i = 0; i < 10; i++) // starting at 0, ending at 10 numbers 
            {
                int numb = rnd.Next(0,100); // choosing a number between 1-100
                Console.Write(numb + " "); // writting those 10 numbers with a space between            
            }
            Console.WriteLine();
            //Console.ReadLine();
            // 3. Print which day of the week is Today  // Class DateTime 
            Console.WriteLine("3. Which Day of the week is Today? ");
            Console.WriteLine(DateTime.Today.DayOfWeek);
            //Console.ReadLine();
            //4.  count of days,hours, and minutes, which have passes since the computer is started. // Class Environment
            Console.WriteLine("4. How long has computer been on ? ");
           // DateTime DateAndTime = new DateTime();
            System.DateTime SystemStartTime = DateTime.Now.AddMilliseconds(-Environment.TickCount); //millisenconds - now
            System.TimeSpan Uptime = DateTime.Now - SystemStartTime;// taking current time - how long comp on 
            Console.WriteLine(Uptime); // prints out the span of time 
            //Console.ReadLine();
            // 5. Take square root of the two sides of the equation in order to get the length of the hypotenuse.
            Console.WriteLine("5. Find the Hypotonuse of the triangle."); // Math Class
            double a = 4;
            double b = 2;
            double hypot = Math.Sqrt(a * a + b * b); // a number that may be a fraction uses double 
            Console.WriteLine(hypot);
            //System.Console.ReadLine();
            //6.  Calculates the area of a triangle
            Console.WriteLine("6. Calculate area of Triangle");
            double h = 2;
                double b2 = 6;
                double area = h * b2 * 0.5; // base x height / 2 = area
            Console.WriteLine("area is  " + area);
           // Console.ReadLine();          

        }

               
        
    }
}
