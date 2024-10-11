// See https://aka.ms/new-console-template for more information

using System;

class BinarySearcher
{
    static int BinarySearch(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        // si llega aqui, entonces el numero no esta
        return -1;
    }

    static void Main()
    {
        // el array siempre tiene que estar ordenado
        int[] array = { 1, 3,4, 5, 7,20,38,47,59,210 };

        int result = BinarySearch(array, 4);

        if (result != -1)
        {
            Console.WriteLine("Elemento encontrado");
        }
        else
        {
            Console.WriteLine("Elemento no encontrado");
        }

        Console.ReadKey();
    }
}
