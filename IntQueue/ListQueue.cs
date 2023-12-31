﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntQueue
{
    internal class ListQueue
    {
        //Field
        NodeQueue front;
        NodeQueue rear;
        //Properties
        public NodeQueue Front { get => front; set => front = value; }
        public NodeQueue Rear { get => rear; set => rear = value; }
        //Constructor
        public ListQueue() => front = rear = null;
        //Method
        public bool IsEmpty() => front == null;
        public bool EnQueue(int x)
        {
            var newQueue = new NodeQueue(x);
            if (newQueue == null) return false;
            if (IsEmpty()) front = rear = newQueue;
            else
            {
                rear.Next = newQueue;
                rear = newQueue;
            }
            return true;
        }
        public bool DeQueue(out int outItem)
        {
            outItem = 0;
            if (IsEmpty()) return false;
            outItem = front.Data;
            if(front == rear)
            {
                front = rear = null;
            }
            else
            {
                NodeQueue x = front;
                front = front.Next;
                x = null;
            }
            return true;
        }
        public bool GetFront(out int frontItem)
        {
            frontItem = 0;
            if (IsEmpty()) return false;
            else frontItem = front.Data;
            return true;
        }
        public bool GetRear(out int rearItem)
        {
            rearItem = 0;
            if (IsEmpty()) return false;
            else rearItem = rear.Data;
            return true;

        }
    }
}
