using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSLL
{
	public class LinkedList<T>
	{
		public int Count { get; private set; }
		public Node? Head {  get; private set; }
		public Node? Tail { get; private set; }

		// Creates the initializer for LinkedList
		public LinkedList()
		{
			Head = null;
			Tail = null;
			Count = 0;
		}

		// Creates the AddFirst method
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

		// Creates the AddLast method
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

		// Creates the RemoveFirst method
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
		}

		// Created the RemoveLast method
		public void RemoveLast()
		{
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

		// Creates the GetValue method
		public string? GetValue(int index)
		{
			Node current = Head;

			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}

			return current.Data;
		}
	}
}
