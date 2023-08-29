namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };
                       
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(arr)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(reverseSorted)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(fewUniques)));
            Console.WriteLine("[{0}]", String.Join(", ", SortingAlgorithms.MergeSort(nearlySorted)));

        }
    }
}