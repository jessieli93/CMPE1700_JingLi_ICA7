using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700_JingLi_ICA7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                int count = 0;
                Node head = null;
                JessieLinkedList.Append(ref head, 25); count++;
                JessieLinkedList.Append(ref head, 5); count++;
                JessieLinkedList.Append(ref head, 18); count++;
                JessieLinkedList.Append(ref head, 7); count++;
                
                // Console.WriteLine("Linked list:");
                RecursivePrintList(head);
                Console.WriteLine();
                head = JessieLinkedList.SortList(head, count);
                SortLinkedList(head, count);
                RecursivePrintList(head);
                JessieLinkedList.Reverse(ref head);
                Console.WriteLine();
                RecursivePrintList(head);
                

                Console.WriteLine();
               

                Console.WriteLine();
               

              
                
                Console.ReadKey();



            }
        }
        public Node newHead;
       
        static public void RecursivePrintList(Node head)
        {
            if (head == null)
            {
                Console.WriteLine();
                return;
            }

            Console.Write(head.Data + " ");

            //Head of the remainder of the list is just the next one after this one.
            RecursivePrintList(head.Next);

        }
        static public Node AddToHead(Node head, int val)
        {
            //Inserts a new node in front of the existing one, returns new head.

            //Create new node.
            Node newFirstorHeadNode = new Node();
            newFirstorHeadNode.Data = val;

            if (head == null) // Empty list
            {
                //easy.  My linked list has one node, the one I just created.
                return newFirstorHeadNode;
            }

            //Otherwise
            //Point new one to old first one (which will now be second).
            newFirstorHeadNode.Next = head;

            //Return my new first item:
            return newFirstorHeadNode;

        }
        public static Node SortLinkedList(Node head, int count)
        {
            // Basic Algorithm Steps
            //1. Find Min Node
            //2. Remove Min Node and attach it to new Sorted linked list
            //3. Repeat "count" number of times
            Node _current = head;
            Node _previous = _current;
            Node _min = _current;
            Node _minPrevious = _min;
            Node _sortedListHead = null;
            Node _sortedListTail = _sortedListHead;
            for (int i = 0; i < count; i++)
            {
                _current = head;
                _min = _current;
                _minPrevious = _min;
                //Find min Node
                while (_current != null)
                {
                    if (_current.Data < _min.Data)
                    {
                        _min = _current;
                        _minPrevious = _previous;
                    }
                    _previous = _current;
                    _current = _current.Next;
                }
                // Remove min Node 
                if (_min == head)
                {
                    head = head.Next;
                }
                else if (_min.Next == null) //if tail is min node
                {
                    _minPrevious.Next = null;
                }
                else
                {
                    _minPrevious.Next = _minPrevious.Next.Next;
                }
                //Attach min Node to the new sorted linked list
                if (_sortedListHead != null)
                {
                    _sortedListTail.Next = _min;
                    _sortedListTail = _sortedListTail.Next;
                }
                else
                {
                    _sortedListHead = _min;
                    _sortedListTail = _sortedListHead;
                }
            }
            return _sortedListHead;
        }
        public static Node append(Node head, int data)
        {
            if (head != null)
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new Node();
                current.Next.Data = data;
                return head;
            }
            else
            {
                head = new Node();
                head.Data = data;
                return head;
            }

        }

        public static class JessieLinkedList
        {

            public static Node SortList(Node head, int count)
            {
                // Basic Algorithm Steps
                //1. Find Min Node
                //2. Remove Min Node and attach it to new Sorted linked list
                //3. Repeat "count" number of times
                Node _current = head;
                Node _previous = _current;
                Node _min = _current;
                Node _minPrevious = _min;
                Node _sortedListHead = null;
                Node _sortedListTail = _sortedListHead;
                for (int i = 0; i < count; i++)
                {
                    _current = head;
                    _min = _current;
                    _minPrevious = _min;
                    //Find min Node
                    while (_current != null)
                    {
                        if (_current.Data < _min.Data)
                        {
                            _min = _current;
                            _minPrevious = _previous;
                        }
                        _previous = _current;
                        _current = _current.Next;
                    }
                    // Remove min Node 
                    if (_min == head)
                    {
                        head = head.Next;
                    }
                    else if (_min.Next == null) //if tail is min node
                    {
                        _minPrevious.Next = null;
                    }
                    else
                    {
                        _minPrevious.Next = _minPrevious.Next.Next;
                    }
                    //Attach min Node to the new sorted linked list
                    if (_sortedListHead != null)
                    {
                        _sortedListTail.Next = _min;
                        _sortedListTail = _sortedListTail.Next;
                    }
                    else
                    {
                        _sortedListHead = _min;
                        _sortedListTail = _sortedListHead;
                    }
                }
                return _sortedListHead;
            }
            public static int c;
            public static void Append(ref Node head, int data)
            {
                c++;
                if (head != null)
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = new Node();
                    current.Next.Data = data;
                }
                else
                {
                    head = new Node();
                    head.Data = data;
                }
            }

            public static void Print(Node head)
            {
                if (head == null) return;

                Node current = head;
                do
                {
                    Console.Write("{0} ", current.Data);
                    current = current.Next;
                } while (current != null);
            }

            public static void PrintRecursive(Node head)
            {
                if (head == null)
                {
                    Console.WriteLine();
                    return;
                }

                Console.Write("{0} ", head.Data);
                PrintRecursive(head.Next);
            }

            public static void Reverse(ref Node head)
            {
                if (head == null) return;

                Node prev = null, current = head, next = null;

                while (current.Next != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                }

                current.Next = prev;
                head = current;
            }

            public static Node newHead;

            public static void ReverseUsingRecursion(Node head)
            {
                if (head == null) return;

                if (head.Next == null)
                {
                    newHead = head;
                    return;
                }

                ReverseUsingRecursion(head.Next);
                head.Next.Next = head;
                head.Next = null;

            }
        }

        public class Node
        {
            public int Data = 0;
            public Node Next = null;
        }
    }
}
