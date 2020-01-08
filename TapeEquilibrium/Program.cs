﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 1, 32, 4, 300, 5 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            if (A.Length == 2)
            {
                return Math.Abs(A[0] - A[1]);
            }

            int sumLeft = A[0];
            int sumRight = A.Sum() - A[0];
            int minDiff = Math.Abs(sumLeft - sumRight);
            for (int i = 1; i < A.Length - 1; i++)
            {
                sumLeft += A[i];
                sumRight -= A[i];
                if (Math.Abs(sumLeft - sumRight) < minDiff)
                {
                    minDiff = Math.Abs(sumLeft - sumRight);
                }

            }
            return minDiff;
        }


    }
}
