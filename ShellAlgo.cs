using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class ShellAlgo
    {
        public void Shell(int[] ray)
        {
            
            int temp;
            int h = ray.Length / 2; // Acho que definir h como metade do tamanho do array é prudente e otimizado 

            while (h >= 2) // Quando a condição for falsa é pq ele já está organizado  suficiente para chamar o Insertion Sort
            {
                for (int i = 0; i < h; i++)
                {
                    if (ray[i] > ray[i + h])
                    {
                        temp = ray[i];
                        ray[i] = ray[i + h];
                        ray[i + h] = temp;
                    }
                }
                h = h / 2;
            }
            myInsertion(ray);
        }

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
    }
}
