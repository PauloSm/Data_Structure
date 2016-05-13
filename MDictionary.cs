using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DicitionaryImplementation
{
    struct Element<T> //Implement Size
    {
        public int key; // O elemento que será usado como chave. Precisa ser do tipo Int para a fuc. Hash
        public T value; // Valor de tipo genérico 
        public int collision; // Armazena o numero de colisões  
        public ArrayList next; // Armazena a posição do elemento que colidiu 
    }
    class MDictionary <T>
    {
        Element<T>[] arr_items;
        int[] arr_index; // Array usado para armazenar os index's gerados
        int[] arr_keys;
        int index;
        int pointer;
        int size; // Tamanho do Array
        Element<T> item;
        ArrayList empty_position; // Armazena as posições vazias no array de index
        ArrayList primes; // armazena os números primos que serão usados na função hash

        public MDictionary()
        {
            primes = new ArrayList() { 11, 23, 43, 73, 149, 307, 509 };
            size = (int)primes[0];
            arr_items = new Element<T>[size];
            arr_index = new int[size];
            arr_keys = new int[size];
            empty_position = new ArrayList(); 
            pointer = 0;
            for (int i = 0; i < arr_index.Length; i++)
            {
                arr_index[i] = -1; //Array inicializado com -1 para facil identificação das pos. livres
                empty_position.Add(i);
                
            }
        }
        
        public int Hash(int key)
        {
            return key % size; // Modulo da Chave (Int) com o Primeiro primo da lista de primos.
        }
        public void Insert (int key, T value)
        {
            if (DuplicateKey(key))
            {
                throw new Exception("Key already in de Dictionary");
            }
            else
            {
                index = Hash(key);
                
                if (arr_index.Contains(index)) // houve colisão
                {
                    arr_items[index].collision += 1;
                    arr_items[index].next = new ArrayList();
                    int old = index;
                    index = Collision();
                    arr_items[old].next.Add(index);
                    arr_items[index] = item;
                    arr_items[index].key = key;
                    arr_items[index].value = value;
                    arr_items[index].collision = 0;
                }
                else
                {
                    arr_index[pointer] = index;
                    pointer++;

                    arr_items[index] = item;
                    arr_items[index].key = key;
                    arr_items[index].value = value;
                    arr_items[index].collision = 0;
                    empty_position.Remove(index);
                    
                }
                
                if (arr_index[arr_index.Length-1] != -1) // Se o array está lotado deve ser redimensionado 
                    Resize();
            }
        }

        private int Collision() // Verifica se ouve colisão nos index's gerados pela Func Hash
        {
            int index = (int)empty_position[0];
            empty_position.RemoveAt(0);
            return index;
        }

        private bool DuplicateKey(int key) // Verifica se há chaves duplicadas
        {
            if (arr_keys.Contains(key))
            {
                return true;
            }
            return false;
        }

        public void  Remove(int key)
        {
            int index = Hash(key);
            arr_index[index] = -1; // indica que a pos. do array voltou a estar livre
            empty_position.Add(index); // Adiciona a pos. a lista de pos. vagas
        }

        private void Resize()
        {
            primes.RemoveAt(0);
            size = (int)primes[0]; // pega o próximo primo da lista
            Array.Resize(ref arr_index, size); // Redefine o tamanho do Array baseado no número primo
            Array.Resize(ref arr_items, size);
            
        }

        public void Display(int key)
        {
            int index = Hash(key);
             
            if (empty_position.Contains(index)) // Verifica se é uma pos livre
                Console.WriteLine("Item not found");

            else if ((arr_items[index].collision > 0) && key != arr_items[index].key) // Se há colisões e a chave n está na pos original então busca na lista next
            {
                for (int i = 0; i < arr_items[index].next.Count; i++)
                {
                    int x = (int)arr_items[index].next[i];
                    if (arr_items[x].key == key)
                        Console.WriteLine(arr_items[x].value);
                    else
                        Console.WriteLine("Item not found");
                }
            }

            else
            {
                Console.WriteLine(arr_items[index].value);
            } 
        }
    }
}
