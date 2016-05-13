using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Algo
    {
        private bool done;
        private int temp;

        
        /*Best Case: O(n)
          Average: O(n²)
          Worst Case: O(n²)*/
        public void myBubble(int[] arr)
        {
            done = false;

            while (done == false)
            {
                done = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        done = false;
                    }
                }
            }
            //return arr;
        }

        /*Best Case: O(n²)
          Average: O(n²)
          Worst Case: O(n²)*/
        public void mySelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int k = i + 1; k <= arr.Length - 1; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
        }


        /*
         Best Case: O(n²)
         Average: O(n²)
         Worst Case: O(n²)
         */
        public void myInsertion(int[] arr)
        {
            int value, index;
            for (int i = 1; i <= arr.Length - 1; i++) /*Loop da seg pos ate a ultima*/
            {
                value = arr[i]; // valor da pos selecionada
                index = i; // index da pos selecionadda

                while (index > 0 && value < arr[index - 1]) // loop q verifica se o valor anterio e maior q o selecionado
                {
                    arr[index] = arr[index - 1]; // empurra os elementos para a direita
                    index--;
                }

                arr[index] = value; // encaixa o valor selecionado na pos correta
            }
        }

        public int myLinearSrch(int[] arr, int value)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == value)
                {
                    return arr[i];
                }
            }
            return -1;
        }
    }
}