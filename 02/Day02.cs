using System;

namespace AdventOfCode21
{
    class Day02
    {
        public static void Part1()
        {
            int horizontalPos = 0, depth = 0;

            string[] commands = System.IO.File.ReadAllLines("02/input");
            foreach(string command in commands)
            {
                string[] commandParts = command.Split(' ');
                string direction = commandParts[0];
                int units = int.Parse(commandParts[1]);

                switch(direction)
                {
                    case "forward":
                        horizontalPos += units;
                        break;
                    case "up":
                        depth -= units;
                        break;
                    case "down":
                        depth += units;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(horizontalPos * depth);     
        }

        public static void Part2()
        {
            int horizontalPos = 0, depth = 0, aim = 0;

            string[] commands = System.IO.File.ReadAllLines("02/input");
            foreach(string command in commands)
            {
                string[] commandParts = command.Split(' ');
                string direction = commandParts[0];
                int units = int.Parse(commandParts[1]);

                switch(direction)
                {
                    case "forward":
                        horizontalPos += units;
                        depth += aim * units;
                        break;
                    case "up":
                        aim -= units;
                        break;
                    case "down":
                        aim += units;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(horizontalPos * depth);   
        }

    }
}
