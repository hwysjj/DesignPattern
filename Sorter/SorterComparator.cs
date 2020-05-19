using System;
namespace Strategy
{
    public class SorterComparator<T>
    {
        // select sort
        public static void Sort(T[] arr, Comparator<T> comparator)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    minPos = comparator.Compare(arr[j], arr[minPos]) < 0
                        ? j
                        : minPos;
                }
                Swap(arr, i, minPos);
            }
        }

        private static void Swap(T[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
