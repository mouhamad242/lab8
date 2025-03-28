namespace LinkedListProject0
{
    public class LinkedList
    {
        public Node Head { get; private set; }
        public int Count { get; private set; }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value)
            {
                Next = Head
            };
            Head = newNode;
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
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (Head == null)
                throw new InvalidOperationException("List is empty.");

            Head = Head.Next;
            Count--;
        }

        public void RemoveLast()
        {
            if (Head == null)
                throw new InvalidOperationException("List is empty.");

            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            Count--;
        }

        public string GetValue(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }
}
