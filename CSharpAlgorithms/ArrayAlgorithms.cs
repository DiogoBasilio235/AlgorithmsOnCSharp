using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class ArrayAlgorithms
    {
        //Built in function: Array.Find()
        public int? LinearSearch(int[] input, int n )
        {
            foreach( int current in input ) {
                if (n == current)
                {
                    return n;
                }
            }
            return null;
        }

        //Built in function: Array.BinarySearch()
        //Binary search is an efficient algorithm for finding an item from a sorted list of items.
        //It works by repeatedly dividing in half the portion of the list that could contain the item,
        //until you've narrowed down the possible locations to just one.
        public bool BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while ( min <= max )
            {
                int mid = (min + max) / 2;
                if (item == inputArray[mid]) 
                { 
                    return true;
                } else if (item < inputArray[mid])
                {
                    max = mid - 1;
                } else 
                {
                    min = mid + 1; 
                }
            }
            return false;
        }

        public int[] FindEvenNumbers(int[] array1, int[] array2)
        {
            // We create an ArrayList as we don't know
            // how many even numbers we will have on the result array
            ArrayList result = new ArrayList();

            foreach(var num in array1)
            {
                if (num % 2 == 0) { result.Add(num); }                
            }

            foreach (var num in array2)
            {
                if (num % 2 == 0) { result.Add(num); }
            }
            return (int[])result.ToArray(typeof(int));
        }

        public int[] ReverseArray(int[] input)
        {
            int[] reversed = new int[input.Length];

            //This will take what's at the bacj of the input array
            // and put it at the front of the reversed array.
            // Will also take what's at the front of the input array
            // and put at the end of the reversed array
            for(int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }
            return reversed;
        }

        // This function returns a void because it changes the input array
        // instead of creating a new array
        public void ReverseInPlace(int[] input)
        {
            for(int i = 0; i <input.Length / 2; i++)
            {
                // Swap index(i) with index(input.Length - i - 1)
                var temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        //Code Challenge - Move the whole array one step to the left (attempt)
        public void RotateArrayLeft(int[] input) {
            int temp = input[0];

            for(var i = 0; i < input.Length - 1; i++)
            {
                // This gives us the array without the last index
                input[i] = input[i + 1];
            }
            // The array at this moment is [2, 3, 4, 5, 6, 6]
            input[input.Length - 1] = temp;
        }

        public void RotateArrayRight(int[] input)
        {
            int temp = input[input.Length - 1];

            for (var i = input.Length -1; i > 0; i--)
            {
                // This gives us the array without the last index
                input[i] = input[i - 1];
            }
            // The array at this moment is [1, 1, 2, 3, 4, 5]
            input[0] = temp;
        }


    }
}
