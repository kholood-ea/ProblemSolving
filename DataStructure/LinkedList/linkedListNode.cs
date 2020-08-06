namespace Problems
{

    public class LinkedListNode<T>
    {
        public LinkedListNode()
        {
        }
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }


        public LinkedListNode<T> Previous { get; set; }
    }
}