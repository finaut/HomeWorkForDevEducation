namespace HomeWorkForDevEducation14.Class
{
    public class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public int Value { get; set; }
        
        public Node(int value)
        {
            Value = value;  
            Next = null;
            Previous = null;
        }
    }
}