using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalDeltaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "14:01:57 12:47:11";
            string [] times =line.Split(' '); // separating the two times 
            System.DateTime endTime = System.DateTime.Parse(times[0]);    // changes the string into a time 
            System.DateTime startTime = System.DateTime.Parse(times[1]);

            System.TimeSpan timeDiff = endTime - startTime;

            System.Console.WriteLine(timeDiff.Duration());  // writeline = one result per line 
            // CodeEval is looking for the absolute value of the two number EX: -3 and + 3 = absolute value of 6
            // there is a Method of TimeSpan Called Duration, this goes on our timeDiff variable 
        }

    }
}
