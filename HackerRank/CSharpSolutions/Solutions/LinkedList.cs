namespace CSharpSolutions.Solutions
{
    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            data = nodeData;
            next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int nodeData)
        {
            var node = new SinglyLinkedListNode(nodeData);

            if (head == null)
                head = node;
            else
                tail.next = node;

            tail = node;
        }
    }

    class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            data = nodeData;
            next = null;
            prev = null;
        }
    }

    class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
            }

            tail = node;
        }
    }

    class LinkedList
    {
        public static void TestMethod()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.InsertNode(1);
            list.InsertNode(2);
            list.InsertNode(3);

            var troll = InsertNodeAtPosition(list.head, 7, 2);

            var dList = new DoublyLinkedList();
            dList.InsertNode(1);
            //dList.InsertNode(2);
            //dList.InsertNode(3);

            var troll2 = Reverse(dList.head);
            int ii = 0;
        }

        /// <summary>
        /// Returns head of the list.
        /// </summary>
        public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            var node = new SinglyLinkedListNode(data);
            if (position == 0)
            {
                // create new
                node.next = head;
                return node;
            }

            SinglyLinkedListNode prev = head;
            SinglyLinkedListNode next;
            for (int i = 0; i < position - 1; i++)
                prev = prev.next;

            next = prev.next;

            prev.next = node;
            node.next = next;

            return head;
        }

        public static DoublyLinkedListNode Reverse(DoublyLinkedListNode head)
        {
            // empty list
            if (head == null)
                return null;

            // one element long list
            if (head.next == null && head.prev == null)
                return head;

            DoublyLinkedListNode current = head, next;
            bool headCheck = true;

            while (true)
            {
                next = current.next;

                // the head
                if(headCheck)
                {
                    current.prev = current.next;
                    current.next = null;
                    headCheck = false;
                }
                else if(current.next == null) // last element
                {
                    current.next = current.prev;
                    current.prev = null;
                    return current;
                }
                else // all the middle elements
                {
                    DoublyLinkedListNode temp = current.prev;
                    current.prev = current.next;
                    current.next = temp;
                }

                current = next;
            }
        }

        /// <summary>
        /// Inserts a node to the DoublyLinkedList while maintaining the sort.
        /// Returns head of the list.
        /// Method assumes the provided list is sorted.
        /// </summary>
        public static DoublyLinkedListNode SortedInsert(DoublyLinkedListNode head, int data)
        {
            // assertion
            if (head == null)
                return head; // we could throw an exception here btw

            DoublyLinkedListNode 
                node = new DoublyLinkedListNode(data), 
                prev, 
                next = head;

            // edge case
            if(head.data > data)
            {
                node.next = head;
                head.prev = node;
                return node;
            }

            while(true)
            {
                prev = next;
                next = next.next; // beautiful

                if (next == null)
                {
                    // we insert it at the end
                    prev.next = node;
                    node.prev = prev;

                    return head;
                }
                else if (next.data > data)
                {
                    prev.next = node;
                    node.prev = prev;

                    node.next = next;
                    next.prev = node;

                    return head;
                }
            }
        }
    }
}
