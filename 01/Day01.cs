using System;

namespace AdventOfCode21
{
    class Day01
    {
        public static void Part1()
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

        public static void Part2()
        {
            int previousWindow = 99999;
            int countIncreased = 0; 
            int[] window = new int[]{0,0,0};

            string[] measurements = System.IO.File.ReadAllLines("01/input");
            foreach(string measurement in measurements)
            {                
                int currentMeasurement = int.Parse(measurement);
                window[0] = window[1];
                window[1] = window[2];
                window[2] = currentMeasurement;

                int currentWindow = window[0] + window[1] + window[2];

                if(currentWindow > previousWindow)
                {
                    countIncreased++;
                }
                
                if(window[0] != 0 && window[1] != 0 )  //skip incomplete windows
                {
                    previousWindow = currentWindow;
                }
            }
            Console.WriteLine(countIncreased);     
        }

    }
}
