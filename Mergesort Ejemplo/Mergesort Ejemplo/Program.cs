using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mergesort_Ejemplo
{
    internal class Program
    {
        public class MergeSort
        {
            // Método principal para ordenar el array
            public void Sort(int[] array)
            {
                // Si el array tiene menos de 2 elementos, ya está ordenado
                if (array.Length < 2)
                    return;

                // Dividir el array en dos mitades
                int mid = array.Length / 2;
                int[] left = new int[mid]; // Array izquierdo
                int[] right = new int[array.Length - mid]; // Array derecho

                // Copiar los elementos en los arrays izquierdo y derecho
                Array.Copy(array, 0, left, 0, mid);
                Array.Copy(array, mid, right, 0, array.Length - mid);

                // Llamar recursivamente a Sort para las mitades
                Sort(left);
                Sort(right);
                // Combinar las mitades ordenadas
                Merge(array, left, right);
            }

            // Método para combinar dos arrays ordenados en uno solo
            private void Merge(int[] result, int[] left, int[] right)
            {
                int i = 0, j = 0, k = 0;

                // Combinar los elementos de left y right en result
                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                        result[k++] = left[i++]; // Agregar elemento de left
                    else
                        result[k++] = right[j++]; // Agregar elemento de right
                }

                // Agregar los elementos restantes de left
                while (i < left.Length)
                    result[k++] = left[i++];
                // Agregar los elementos restantes de right
                while (j < right.Length)
                    result[k++] = right[j++];
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSort mergeSort = new MergeSort();

            Console.WriteLine("Array original:");
            Console.WriteLine(string.Join(", ", array));

            mergeSort.Sort(array);

            Console.WriteLine("Array ordenado:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
//Alternativa
//if (array == null || array.Length < 2) return;

//Sort(array, 0, array.Length - 1);
//            }

//            private void Sort(int[] array, int left, int right)
//{
//    if (left < right)
//    {
//        int mid = (left + right) / 2;

//        Sort(array, left, mid);
//        Sort(array, mid + 1, right);
//        Merge(array, left, mid, right);
//    }
//}

//private void Merge(int[] array, int left, int mid, int right)
//{
//    int[] temp = new int[right - left + 1];
//    int i = left, j = mid + 1, k = 0;

//    while (i <= mid && j <= right)
//    {
//        if (array[i] <= array[j])
//            temp[k++] = array[i++];
//        else
//            temp[k++] = array[j++];
//    }

//    while (i <= mid)
//        temp[k++] = array[i++];
//    while (j <= right)
//        temp[k++] = array[j++];

//    for (i = left; i <= right; i++)
//        array[i] = temp[i - left];
//}
//        }