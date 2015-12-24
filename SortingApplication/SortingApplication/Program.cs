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
            Console.WriteLine("\nBubble Sort Answer\n");
            DisplayArray(ansBubble);
            
            var ansInsersionSort = InsersionSort(array);
            Console.WriteLine("\nInsersionSort  Answer\n");
            DisplayArray(ansInsersionSort);
            
            var ansSelectionSort = SelectionSort(array);
            Console.WriteLine("\nSelectionSort Answer\n");
            DisplayArray(ansSelectionSort);

            var ansQuick = QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("\nQuickSort Answer\n");
            DisplayArray(ansQuick);

          
            //----------------------
            var ansMergeSort = MergeSort(array,0,array.Length-1);
            Console.WriteLine(" MergeSort Answer\n");
            DisplayArray(ansMergeSort);


            Console.ReadLine();
        }
         
        #region MergeSort


        static public int [] MergeSort(int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);

                MainMerge(array, left, (mid + 1), right);
            }
            return array;
        }

        static public void MainMerge(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (array[left] <= array[mid])
                    temp[pos++] = array[left++];
                else
                    temp[pos++] = array[mid++];
            }

            while (left <= eol)
                temp[pos++] = array[left++];

            while (mid <= right)
                temp[pos++] = array[mid++];

            for (i = 0; i < num; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
        
        #endregion

        private static int [] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            return array;
        }

        private static int[] InsersionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int index = array[i];
                int j = i;
                while (j > 0 && array[j - 1] > index)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = index;
            }
            return array;
        }

        private static int[] QuickSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q;
                q = Partition(array, p, r);
                QuickSort(array, p, q);
                QuickSort(array, q + 1, r);
            }
            return array;
        }

        private static int Partition(int[] array, int p, int r)
        {
            int i, j, pivot, temp;
            pivot = array[p];
            i = p;
            j = r;
            while (true)
            {
                while (array[i] < pivot && array[i] != pivot)
                    i++;
                while (array[j] > pivot && array[j] != pivot)
                    j--;
                if (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                else
                {
                    return j;
                }
            }
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
               // Console.WriteLine("Iteration : " + i + "\n");
                // DisplayArray(array);
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
