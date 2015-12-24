using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 41, 22, 13, 64, 99, 10, 55, 66, 28 };
            Console.WriteLine("Sorting Algorithms\n");
            DisplayArray(array);
            var ansBubble = BubbleSort(array);
            Console.WriteLine("Bubble Sort Answer\n\n");
            DisplayArray(ansBubble);
/*
            //----------------------
            var ansQuick = QuickSort(array);
            Console.WriteLine("  QuickSort Answer\n\n");
            DisplayArray(ansBubble);

            //----------------------
            var ansInsersionSort = InsersionSort(array);
            Console.WriteLine("InsersionSort  Answer\n\n");
            DisplayArray(ansBubble);


            //----------------------
            var ansSelectionSort = SelectionSort(array);
            Console.WriteLine("SelectionSort Answer\n\n");
            DisplayArray(ansBubble);

            //----------------------
            var ansMergeSort = MergeSort(array);
            Console.WriteLine("Bubble Sort Answer\n\n");
            DisplayArray(ansBubble);*/


            Console.ReadLine();
        }

        private static object MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        private static object SelectionSort(int[] array)
        {
            throw new NotImplementedException();
        }

        private static object InsersionSort(int[] array)
        {
            throw new NotImplementedException();
        }

        private static object QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }

        private static int[] BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
                Console.WriteLine("Iteration : " + i + "\n");
                DisplayArray(array);
            }
            return array;
        }

        private static void DisplayArray(int[] array)
        {
            var str = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                str = str + "  " + array[i];
            }
            Console.WriteLine(str);
        }
    }
}
