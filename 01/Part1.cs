using System;

namespace AdventOfCode21.Day01
{
    class Part1
    {
        public static void Run()
        {
            int previousMeasurement = 99999;
            int countIncreased = 0; 

            string[] measurements = System.IO.File.ReadAllLines("01/input");
            foreach(string measurement in measurements)
            {
                int currentMeasurement = int.Parse(measurement);
                if(currentMeasurement > previousMeasurement)
                {
                    countIncreased++;
                }
                previousMeasurement = currentMeasurement;
            }
            Console.WriteLine(countIncreased);
        }
    }
}
