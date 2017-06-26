using System;
namespace LinkedList
{
	public class LinkedListNode<NodeDataType>
	{
		private NodeDataType data;
		private LinkedListNode<NodeDataType> next;

		public LinkedListNode(NodeDataType data, LinkedListNode<NodeDataType> next)
		{
			this.data = data;
			this.next = next;
		}

		public NodeDataType Data
		{
			get { return this.data; }
			set { data = value; }
		}

		public LinkedListNode<NodeDataType> Next
		{
			get { return this.next; }
			set { next = value; }
		}
	}
}
