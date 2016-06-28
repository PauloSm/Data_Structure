using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
    class LinkedList
    {
        public Node Head;
        public int count;

        public LinkedList()
        {
            Head = new Node();
            count = 0;
        }

        public void Insert(Node node, int data)
        {
            //LIFO Data Structure
            node.Data = data;

            if ( count == 0 )
            {
                Head.Next = node;
            }

            else
            {
                Node temp = Head.Next;
                Head.Next = node;
                node.Next = temp;
            }

            count++;
        }

        public void Remove ()
        {
            if (count <= 1)
            {
                Head.Next = null;
            }

            else
            {
                Node temp = Head.Next;
                Head.Next = temp.Next;
                temp.Next = null;
            }
            count--;
        }

        public void Display()
        {
            Node i = Head.Next;

            while (i != null)
            {
                Console.WriteLine(i.Data);
                i = i.Next;
            }
        }
    }
}
