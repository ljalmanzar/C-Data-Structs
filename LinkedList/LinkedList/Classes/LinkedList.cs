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
			}
            //if cursor is at end of list
            else if (_cursor.Next == null)
            {
                _cursor.Next = new LinkedListNode<DataType>(newItem, null);
                _cursor = _cursor.Next;
            }
            //if cursor is in the middle
            else
            {
                LinkedListNode<DataType> temp;

                temp = _cursor.Next;
                _cursor.Next = new LinkedListNode<DataType>(newItem, null);
                _cursor = _cursor.Next;
                _cursor.Next = temp;
            }

            _size++;
            return true;
		}

		public bool Remove()
		{
			//if cursor & head is null, create new node with data
			if (_head == null && _cursor == null)
			{
                return false;
			}
            //if cursor at beginning
            else if(_cursor==_head)
            {
                _head = _cursor.Next;
                _cursor = _head;
            }
			//if cursor is at end of list
			else if (_cursor.Next == null)
			{
                GoToPrior();
				_cursor.Next = null;
			}
			//if cursor is in the middle
			else
			{
                LinkedListNode<DataType> temp = _cursor.Next;
                GoToPrior();
                _cursor.Next = temp;
			}

            return true;
		}

		public bool Replace(DataType newItem)
		{
            if (_cursor == null)
            {
                return false;
            }
            else 
            {
                _cursor.Data = newItem;
                return true;
            }
		}

		public bool Clear()
		{
            //yay garbo collection
            _head = null;
            _cursor = null;
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
            _cursor = _head;
			return true;
		}

		public bool GoToEnd()
		{
            if (_cursor == null)
                return false;
            
            while(_cursor.Next != null)
            {
                _cursor = _cursor.Next;
            }

			return true;
		}

		public bool GoToNext()
		{
            if (_cursor == null || _cursor.Next == null)
                return false;
            else
                _cursor = _cursor.Next;
            
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

                return true;
            }

            return false;
		}

		public DataType GetCursor()
		{
            return _cursor.Data;
		}

		public bool MoveToBeginning()
		{
            _cursor = _head;
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
