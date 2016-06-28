using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    class Binary_T
    {
        public Tree_Node root;

        public Binary_T()
        {
            root = null;
        }

        public void Insert (int i)
        {
            Tree_Node newNode = new Tree_Node();
            newNode.Data = i;

            if (root == null)
                root = newNode;
            else
            {
                Tree_Node current = root;
                Tree_Node parent;

                while (true)
                {
                    parent = current;
                    
                    if (i < current.Data)
                    {
                        current = current.Left_node;
                        if (current == null)
                        {
                            parent.Left_node = newNode;
                            break;
                        }
                    }

                    else
                    {
                        current = current.Right_node;
                        if (current == null)
                        {
                            parent.Right_node = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void InOrder (Tree_Node theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.Left_node);
                theRoot.DisplayNode();
                InOrder(theRoot.Right_node);
            }
        }


    }
}
