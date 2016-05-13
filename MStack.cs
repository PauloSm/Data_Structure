using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithms
{
    class MStack
    {
        public int top_index;
        private ArrayList list;

        public MStack()
        {
            list = new ArrayList();
            top_index = -1;
        }

        public int count
        {
            get
            {
                return list.Count;
            }
        }

        public void push(Object item)
        {
            list.Add(item);
            top_index++;
        }

        public object pop()
        {
            object obj = list[top_index];
            list.RemoveAt(top_index);
            top_index--;
            return obj;
        }

        public void Clear()
        {
            list.Clear();
            top_index = -1;
        }

        public object peek()
        {
            return list[top_index];
        }
    }
}
