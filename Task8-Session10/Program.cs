using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Session10
{
    internal class Program
    {
        static void OptimizationBubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no two elements were swapped by inner loop, then break
                if (!swapped)
                    break;
            }
        }


        static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }

        static int FirstNonRepeatedCharacter(string str)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            // Count each character
            foreach (char c in str)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            // Find the first non-repeated character
            for (int i = 0; i < str.Length; i++)
            {
                if (counts[str[i]] == 1)
                    return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            // ---- optimized bubble sort ----
            int[] numbers = { 1, 2, 3, 5, 4 };

            OptimizationBubbleSort(numbers);

            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("\n---------------------------------------------------------------");

            // ---- Range class ----
            Range<int> range = new Range<int>(10, 20);

            Console.WriteLine(range.IsInRange(15)); // True
            Console.WriteLine(range.IsInRange(25)); // False
            Console.WriteLine(range.Length());      // 10

            Console.WriteLine("---------------------------------------------------------------");

            // ---- Reverse ArrayList ----
            ArrayList numbers2 = new ArrayList() { 1, 2, 3, 4, 5 };

            ReverseArrayList(numbers2);

            foreach (object number in numbers2 )
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n---------------------------------------------------------------");

            // ---- Get Even Numbers ----
            List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> evenNumbers = GetEvenNumbers(numbers3);

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n---------------------------------------------------------------");

            // ----- Fixed size array ----
            FixedSizeList<int> numbers4 = new FixedSizeList<int>(3);

            numbers4.Add(10);
            numbers4.Add(20);
            numbers4.Add(30);

            Console.WriteLine(numbers4.Get(0));
            Console.WriteLine(numbers4.Get(1));
            Console.WriteLine(numbers4.Get(2));

            Console.WriteLine("\n---------------------------------------------------------------");

            // ---- First Non-Repeated Character ----
            string text = "swiss";

            int index = FirstNonRepeatedCharacter(text);

            Console.WriteLine(index);

            Console.WriteLine("\n---------------------------------------------------------------");
        }
    }
}
