using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class node
    {
        public int key;
        public node next;

        public void Set(int key, node next)
        {
            this.key = key;
            this.next = next;
        }
    }

    class SLL
    {
        public node head;
        public node tail;

        public SLL()
        {
            head = new node();
            tail = new node();
            head.Set(0, tail);
            tail.Set(0, tail);
        }
    }
}
