using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSLL
{
	public class LinkedList
	{
		public int Count { get; set; }
		public Node? Head {  get; private set; }
		public Node? Tail { get; private set; }

		public LinkedList()
		{
			Head = null;
			Tail = null;
			Count = 0;
		}

		public void AddFirst(string value)
		{
			Node newNode = new Node(value);

			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;
			}
            else
			{
				newNode.Next = Head;
				Head = newNode;
            }

            Count++;
		}

		public void AddLast(string value)
		{
			Node newNode = new Node(value);

			if (Head == null)
			{
				Head = newNode;
			}
			else
			{
				Tail.Next = newNode;
			}

			Tail = newNode;

			Count++;
		}

		public void RemoveFirst()
		{
			if (Head != null)
			{
				Head = Head.Next;

				if (Head == null)
				{
					Tail = null;
				}

				Count--;
			}
			else
			{
				Console.WriteLine("List is empty.");
			}
			
		}

		public void RemoveLast()
		{
			if (Head == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			if (Head.Next == null)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Node current = Head;
				while (current.Next.Next != null)
				{
					current = current.Next;
				}

				current.Next = null;
				Tail = current;
			}

			Count--;
		}

		public Node GetValue(int index)
		{
			Node current = Head;

			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}

			return current;
		}
	}
}
