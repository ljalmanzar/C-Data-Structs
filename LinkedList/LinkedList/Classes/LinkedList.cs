using System;
namespace LinkedList
{
	public class LinkedList<DataType>
	{
        private LinkedListNode<DataType> _head;
        private LinkedListNode<DataType> _cursor;
        private int _size;

		public LinkedList()
		{
			_head = _cursor = null;
            _size = 0;
		}

		public bool Insert(DataType newItem)
		{
			//if cursor & head is null, create new node with data
			if (_head == null && _cursor == null)
			{
                _head = new LinkedListNode<DataType>(newItem, null);
                _cursor = _head;

                return true;
			}

            //if cursor is at end of list
            if (_cursor.Next == null)
            {
                _cursor.Next = new LinkedListNode<DataType>(newItem, null);
                _cursor = _cursor.Next;

                return true;
            }
            //if cursor is in the middle
            else
            {
                LinkedListNode<DataType> temp;

                temp = _cursor.Next;
                _cursor.Next = new LinkedListNode<DataType>(newItem, null);
                _cursor = _cursor.Next;
                _cursor.Next = temp;

                return true;
            }
		}

		public bool Remove()
		{
			//if cursor & head is null, create new node with data
			if (_head == null && _cursor == null)
			{
                return false;
			}

			//if cursor is at end of list
			if (_cursor.Next == null)
			{
                GoToPrior();
                _cursor.Next = null;
                return true;
			}
			//if cursor is in the middle
			else
			{
                LinkedListNode<DataType> temp = _cursor.Next;
                GoToPrior();
                _cursor.Next = temp;
				return true;
			}
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
            return (_head == null ? true : false);
		}

		public bool IsFull()
		{
			return false;
		}

        public int GetSize()
        {
            return _size;
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
            if (_cursor != _head)
            {
                LinkedListNode<DataType> temp = _head;
                while(temp.Next != _cursor)
                {
                    temp = temp.Next;
                }

                _cursor = temp;
            }

			return true;
		}

		public DataType GetCursor()
		{
            return _cursor.Data;
		}

		public bool MoveToBeginning()
		{
			return true;
		}

		public bool InsertBefore(DataType newDataItem)
		{
			return true;
		}

        public void Print()
        {
            Console.Write("List: ");

            LinkedListNode<DataType> printCursor;

            printCursor = _head;

            if (_head != null)
            {
                Console.Write("{0} ", printCursor.Data);
				while (printCursor.Next != null)
				{
                    printCursor = printCursor.Next;
					Console.Write("{0} ", printCursor.Data);
				}
            }    

            Console.WriteLine();
        }

	}//end of class
}//end of namespace
