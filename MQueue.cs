using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithms
{
    class MQueue
    {
        private ArrayList myQueue;

        public MQueue()
        {
            myQueue = new ArrayList();
        }

        public void Enqueue(Object item)
        {
            myQueue.Add(item);
        }

        public void Dequeu()
        {
            myQueue.RemoveAt(0);
        }

        public object Peek()
        {
            return myQueue[0];
        }

        public void ClearQueue()
        {
            myQueue.Clear();
        }

        public int Count()
        {
            return myQueue.Count;
        }

    }
}
