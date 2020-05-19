using System;
namespace Strategy
{
    public class SorterComparable<T>
    {
        // select sort
        public static void Sort(Comparable<T>[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    minPos = arr[j].CompareTo((T)arr[minPos]) < 0 ? j : minPos;
                }
                Swap(arr, i, minPos);
            }

        }

        private static void Swap(Comparable<T>[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
