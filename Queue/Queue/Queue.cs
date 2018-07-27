using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Count;
        public Queue(T value)
        {
            Head = new Node<T>(value);
            Tail = Head;
            Count++;
        }
        public Queue()
        {
            Head = null;
        }
        public void Enqueue(T value)
        {
            if(IsEmpty())
            {
                Head = new Node<T>(value);
                Tail = Head;
            }
            else
            {
                Head.Prev = new Node<T>(value);
                Head.Prev.Next = Head;
                Head = Head.Prev;
                Tail = Head;
                while(Tail.Next != null)
                {
                    Tail = Tail.Next;
                }
            }
            Count++;
        }
        public T Dequeue()
        {
            
            if(IsEmpty())
            {
                
                throw new Exception("The Queue is empty.");
            }
            else if(Count == 1)
            {
                T value = Head.Item;
                Head = null;
                Tail = Head;
                Count--;
                return value;
                
            }
            else
            {
                T value = Tail.Item;
                Tail = Tail.Prev;
                Tail.Next = null;
                Head = Tail;
                while(Head.Prev != null)
                {
                    Head = Head.Prev;
                }
                Count--;
                return value;
            }
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}
