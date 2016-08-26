using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{   // My implementation of CLRS Heap
    class MyHeap
    {
        
        public static int Parent(int i)
        {
            return i / 2;
        }

        public static int Left_C(int i)
        {
            return 2 * i + 1;
        } 

        public static int Right_C(int i)
        {
            return 2 * i + 2;
        }

        public static void MaxHeapify(int[] A, int i, int heapSize)
        {
            int size = heapSize;
            int left = Left_C(i);
            int right = Right_C(i);
            int largest;
            
            if (left <= size && A[left] > A[i])
                largest = left;
            else
                largest = i;

            if (right <= size && A[right] > A[largest])
                largest = right;
            
            if (largest != i)
            {
                int temp = A[i];
                A[i] = A[largest];
                A[largest] = temp;

                MaxHeapify(A, largest, size);
            }
                
        }

        public static void BuildHeap(int[] Ray)
        {
            int middle = Ray.Length - 1;
            int size = Ray.Length - 1;
            for (int i = middle/2; i >= 0; i--)
            {
                MaxHeapify(Ray, i, size);
            }
        }

        public static void HeapSort(int[] Ray)
        {
            
            int size = Ray.Length - 1;
            BuildHeap(Ray);
            for (int i = size; i >= 1; i--)
            {
                int temp = Ray[0];
                Ray[0] = Ray[i];
                Ray[i] = temp;
                size = size - 1;
                MaxHeapify(Ray, 0, size);
            }
        }
    }
}
