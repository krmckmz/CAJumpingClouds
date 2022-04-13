﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 0, 0,0, 1, 0, 0 };
            int stepCount = CalculateStepCount(list);
            Console.WriteLine(stepCount);
        }
        static int CalculateStepCount(List<int> c)
        {
            int stepCount = 0;
            int index = 0;

            while (index < c.Count - 1)
            {
                if (c[index + 2] == 1)
                {
                    index++;
                    stepCount++;
                    continue;
                }

                if (c[index + 1] == 1)
                {
                    index += 2;
                    stepCount++;
                }

            }

            return stepCount;
        }
    }
}
