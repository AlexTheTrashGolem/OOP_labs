namespace OP_laba7_sharp
{
    public class OneSideLinkedList
    {
        public class Node
        {
            public char _data;
            public Node _next;
            public Node(char data, Node next = null)
            {
                this._data = data;
                this._next = next;
            }
        }
        private Node _head;
        public int Size { get; private set; }
        
        public OneSideLinkedList()
        {
            _head = null;
            Size = 0;
        }
        public void PushForward(char data) 
        {
            _head = new Node(data, _head);
            Size++;
        }
        

        public void RemoveA()
        {
            Node current = this._head;
            int counter = 0;
            while(current != null)
            {
                if(current._data == 'a')
                {
                    Remove(current);
                    current = current._next;
                    continue;
                }
                counter++;
                current = current._next;
            }
        }
        public void Remove(Node node)
        {
            if (node == _head)
                PopForward();
            else
            {
                Node previous = this._head;
                while (previous != null & previous._next != node)
                {
                    previous = previous._next;
                    if (previous == null)
                    {
                        return;
                    }
                }

                Size--;
                previous._next = node._next;
                
            }
                
        }
        public void PopForward()
        {
            _head = _head._next;
            --Size;
        }

        public int FirstExclamation()
        {
            Node current = this._head;
            int counter = 0;
            while(current != null)
            {
                if(current._data == '!')
                {
                    return counter;
                }
                counter++;
                current = current._next;
            }

            return -1;
        }
        
        public void Print()
        {
            int counter = 0;
            Node current = this._head;
            System.Console.WriteLine("Your list: ");
            while(current != null) 
            {
                System.Console.Write(current._data + ((counter != this.Size - 1) ? " -> " : "\n"));
                current = current._next;
                counter++;
            }                
        }
    }
}