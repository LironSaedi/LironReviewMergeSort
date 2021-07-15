using System;
using System.Collections.Generic;

namespace LironReviewMergeSort
{
    class Program
    {
        static  public List<T> MergeSort<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count < 2)
            {
                return list;
            }

            int middleNumber = list.Count / 2;
            List<T> leftSide = list.GetRange(0, middleNumber);
            List<T> rightSide = list.GetRange(middleNumber, list.Count - middleNumber);

            // call merge sort
            List<T> leftResult = MergeSort(leftSide);

            List<T> rightResult = MergeSort(rightSide);
            List<T> totalResults = new List<T>();
            int leftCounter = 0;
            int rightCounter = 0;
            while (leftCounter != leftResult.Count && rightCounter != rightResult.Count)
            {
                if(leftResult[leftCounter].CompareTo(rightResult[rightCounter]) > 0)
                {
                    totalResults.Add(rightResult[rightCounter]);
                    rightCounter++;
                }
                else
                {
                    totalResults.Add(leftResult[leftCounter]);
                    leftCounter++;
                }

            }

            while(leftCounter < leftResult.Count)
            {
                totalResults.Add(leftResult[leftCounter]);
                leftCounter++;
            }

            while (rightCounter < rightResult.Count)
            {
                totalResults.Add(rightResult[rightCounter]);
                rightCounter++;
            }
            return totalResults;
            // merge the resulting lists

        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> sorted = new List<int>();
            Random gen = new Random(432509823);

            for (int i = 0; i < 10; i++)
            {
                list.Add(gen.Next(0, 20));
            }

            sorted = MergeSort<int>(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i]);
            }

        }
    }
}
