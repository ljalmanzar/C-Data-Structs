using System;
namespace LinkedList.Classes
{
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
		/*bool insert(const DataType& newDataItem);
    bool remove();
		bool replace(const DataType& newDataItem);
    bool clear();

		bool isEmpty() const;
		bool isFull() const;

		bool gotoBeginning();
		bool gotoEnd();
		bool gotoNext();
		bool gotoPrior();

		DataType getCursor() const;

		// Programming exercise 2
		bool moveToBeginning();

		// Programming exercise 3
		bool insertBefore(const DataType& newDataItem);*/
    }
}
