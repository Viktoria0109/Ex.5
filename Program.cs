internal class Program
{
    public enum SortType
    {
        Ascending,
        Descending
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of array elements");
        var count = int.Parse(Console.ReadLine());
        var array = new int[count];
        Random random = new();

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, count);
        }

        Console.WriteLine("Array output");

        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
        int action;

        do
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1: Find the sum of all the elements of the array.");
            Console.WriteLine("2: Find the maximum value for all elements of the array.");
            Console.WriteLine("3: Swap the values of the first and last elements of the array.");
            Console.WriteLine("4: Sort the array in ascending order.");
            Console.WriteLine("5: Sort the array in descending order.");
            Console.WriteLine("6: Complete the work.");

            action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Sum(array);
                    break;
                case 2:
                    Max(array);
                    break;
                case 3:
                    swap(array);
                    break;
                case 4:
                    Sort (array, SortType.Ascending);
                    break;
                case 5:
                    Sort (array, SortType.Descending);
                    break;
                case 6:
                    Console.WriteLine("Completion of work.");
                    break;
                default:
                    Console.WriteLine("Incorrect action.");
                    break;
            }
        } 
        while (action != 6);

        Console.WriteLine();

        static void Sum(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
                sum += number;

            Console.WriteLine($"The sum of all the elements of the array: {sum}");
        }

        static void Max(int[] array)
        {
            int max = array[0];

            for (var i = 1; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                }

            }

          Console.WriteLine($"The maximum element of the array is: {max}");
            
        }

        static void swap(int[] array)
        {
            var x = array[0];
            array[0] = array[^1];
            array[^1] = x;
            Console.WriteLine("Modified array:");

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine() ;
        }

        static void Sort(int[] array, SortType sortType)
        {
            if(sortType == SortType.Ascending)

                for (var i = 0; i < array.Length - 1; i++)
                {
                    for (var j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            var x = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = x;
                        }
                    }
                }

            else
            {

                for (var i = 0; i < array.Length - 1; i++)
                {
                    for (var j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            var x = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = x;
                        }
                    }
                }

            }

            Console.WriteLine("Sorted array:");

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine() ;
        }
    }
}