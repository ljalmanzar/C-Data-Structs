using System;

namespace LinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> List1 = new LinkedList<int>();

            Console.WriteLine("The list is empty: {0}", List1.IsEmpty());

            List1.Insert(6);
            List1.Print();

			List1.Insert(169);
			List1.Print();
			List1.Insert(70);
			List1.Print();
			List1.Insert(45);
			List1.Print();
			List1.Insert(20);
			List1.Print();

            List1.GoToPrior();
            Console.WriteLine("Cursor at {0}.", List1.GetCursor());

            List1.Insert(96);
            List1.Print();

			List1.GoToPrior();
			Console.WriteLine("Cursor at {0}.", List1.GetCursor());
			List1.GoToPrior();
			Console.WriteLine("Cursor at {0}.", List1.GetCursor());
			List1.GoToPrior();
			Console.WriteLine("Cursor at {0}.", List1.GetCursor());
			List1.GoToPrior();
			Console.WriteLine("Cursor at {0}.", List1.GetCursor());
			List1.GoToPrior();
			Console.WriteLine("Cursor at {0}.", List1.GetCursor());

            Console.WriteLine("The list is empty: {0}", List1.IsEmpty());
        }
    }
}
