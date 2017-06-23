using System;
namespace LinkedList.Classes
{
    public class LinkedListNode<DataType>
    {
        private DataType data;
        private LinkedListNode<DataType> next;

        public LinkedListNode(DataType data, LinkedListNode<DataType> next)
        {
            this.data = data;
            this.next = next;
        }

        public DataType Data
        {
            get { return this.data; }
            set { data = value; }
        }

        public LinkedListNode<DataType> Next
        {
            get { return this.next; }
            set { next = value; }
        }
    }
}
