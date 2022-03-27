using System.Collections.Generic;

namespace LinkedList.DoblyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public int Count { get; private set; }
        public DbNode<T> Head { get; private set; }
        public DbNode<T> Tail { get; private set; }
        private bool isHeadNull => Head == null;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;  
        }
        public DoublyLinkedList(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                //AddLast(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new DbNode<T>(value);

            if (isHeadNull)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
                return;
            }

            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
            Count++;
            return;
        }
    }
}
