using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpAlgorithms.LinkedListAlgorithms;

namespace CSharpAlgorithms
{
    public class HashStructureAlgorithms
    {
        public List<int> FindMissingElements(int[] first, int[] second)
        {
            List<int> missingElements = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach(int item in second) {
                secondArrayItems.Add(item);
            }

            foreach(int item in first)
            {
                if (!secondArrayItems.Contains(item))
                {
                    missingElements.Add(item);
                }
            }
            return missingElements;
        }

        public void DisplayFreqOfEachElement(int[] arr)
        {
            Dictionary<int, int> freqDictionary = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (freqDictionary.ContainsKey(arr[i]))
                {
                    freqDictionary[arr[i]]++;
                } else
                {
                    freqDictionary[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int, int> x in freqDictionary)
            {
                Console.WriteLine(x.Key + " " +  x.Value);
            }
        }

    }


}
