using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class QueueAndStackAlgorithms
    {
        //For Queues
        public void PrintBinary(int n)
        {
            if(n <= 0) { return; }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for(int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }
            Console.WriteLine();
        }

        //For Stacks
        public void PrintNextGreaterElement(int[] arr)
        {
            if (arr.Length <= 0) {
                Console.WriteLine();
                return; 
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for(int i = 1; i < arr.Length; i++)
            {
                var next = arr[i];
                if (stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        Console.WriteLine(popped + "-->" + next);
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        popped = stack.Pop();
                    }

                    if (popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "-->" + -1);
            }
        }

        public bool HasMatchingParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(')
                {
                    stack.Push(current);
                    continue;
                }
                if (current == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    } else
                    {
                        return false;
                    }                  
                }
            }
            return stack.Count == 0;
        }

        public bool HasMatchingParentheses2(string s)
        {
            int matchingSymbolTracker = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(')
                {
                    matchingSymbolTracker++;
                    continue;
                }
                if (current == ')')
                {
                    if (matchingSymbolTracker > 0)
                    {
                        matchingSymbolTracker--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return matchingSymbolTracker == 0;
        }
    }
}
