using System;

namespace LinkedList
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

	public class LinkedList<DataType>
	{
		private LinkedListNode<DataType> head;
		private LinkedListNode<DataType> cursor;

		public LinkedList()
		{
			head = cursor = null;
		}

		public bool Insert(DataType newItem)
		{
			return true;
		}

		public bool Remove()
		{
			return true;
		}

		public bool Replace(DataType newItem)
		{
			return true;
		}

		public bool Clear()
		{
			return true;
		}

		public bool IsEmpty()
		{
			return true;
		}

		public bool IsFull()
		{
			return false;
		}

		public bool GoToBeginning()
		{
			return true;
		}

		public bool GoToEnd()
		{
			return true;
		}

		public bool GoToNext()
		{
			return true;
		}

		public bool GoToPrior()
		{
            return true;
		}

		public DataType GetCursor()
		{
            DataType temp = head.Data;
            return temp;
		}

		public bool MoveToBeginning()
		{
			return true;
		}

		public bool InsertBefore(DataType newDataItem)
		{
			return true;
		}
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> List1 = new LinkedList<int>();


        }
    }
}
