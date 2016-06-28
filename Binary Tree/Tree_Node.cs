using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    class Tree_Node
    {
        public Tree_Node Left_node;
        public Tree_Node Right_node;
        public int Data;

        public void DisplayNode()
        {
            Console.WriteLine(Data + " ");
        }


    }
}
