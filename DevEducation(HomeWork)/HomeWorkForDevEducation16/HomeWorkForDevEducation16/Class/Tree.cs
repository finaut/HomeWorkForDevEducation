namespace HomeWorkForDevEducation16.Class
{
    public class Tree
    {
        private string _value;
        private Node _root;

        public Tree()
        {
            _value = "";
        }

        public Tree(string value)
        {
            _value = value;
        }

        public Node NextBranch()
        {
            _value = _value.Trim();
            while (_value.Contains(" "))
            {
                _value = _value.Replace(" ", "");
            }
            return _root;
        }

        public double Calculate()
        {
            return _root.Calculate();
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }
}