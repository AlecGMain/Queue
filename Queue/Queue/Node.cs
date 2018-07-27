using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Node<T>
    {
        //Public accessors
        public Node<T> Prev { get; set; }
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        /// <summary>
        /// Construct a node with an item of generic type (Any type you specify)
        /// </summary>
        /// <param name="itemToStore">Generic item to add</param>
        /// <param name="prev">The Node that comes before it in a Queue</param>
        /// <param name="next">The Node that comes after it in a Queue</param>
        public Node(T itemToStore, Node<T> prev = null, Node<T> next = null)
        {
            Item = itemToStore;
            Prev = prev;
            Next = next;
        }
        public Node()
        {

        }
    }
}
    
