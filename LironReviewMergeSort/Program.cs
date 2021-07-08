using System;
using System.Collections.Generic;

namespace LironReviewMergeSort
{
    class Program
    {


        // DO THIS WITH ARRAYS LATER
        public List<T> MergeSort<T>(List<T> list) where T : IComparable<T>
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
            while (leftCounter != leftSide.Count && rightCounter != rightSide.Count)
            {
                if(leftSide[leftCounter].CompareTo(rightSide[rightCounter]) > 0)
                {
                    totalResults.Add(rightSide[rightCounter]);
                    rightCounter++;
                }

                if (leftSide[leftCounter].CompareTo(rightSide[rightCounter]) < 0)
                {
                    totalResults.Add(leftSide[leftCounter]);
                    leftCounter++;
                }

            }
            return totalResults;
            // merge the resulting lists

        }
        static void Main(string[] args)
        {

        }
    }
}
