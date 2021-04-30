
using System;

namespace ClassWork13
{
    public class ArrayList
    {
        public int Length { get; set; }
        private Node _root;
        private Node _tail;

        public ArrayList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public ArrayList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public ArrayList(int[] values)
        {
            Length = values.Length;
            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }    
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public int IndexOf(int value)
        {
            
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (value == current.Value)
                {
                    return i;
                    break;                    
                }
                current = current.Next;
            }
            throw new ArgumentException("Error: Such a meaning does not exist.");
        }

        public int ValueByIndex(int index)
        {
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (index == i)
                {
                    return current.Value;
                    break;
                }
                current = current.Next;
            }

            throw new ArgumentException("Error: no such index exists.");
        }
        public void Revers()
        {
            var template = _root.Next;
            _root.Next = null;
            for (int i = 0; i < Length - 1; i++)
            {
                var current = template;
                template = template.Next;
                current.Next = _root;
                _root = current;
            }
        }
        public int GetMaxValue()
        {
            Node current = _root;
            int maxValue = current.Value;
            for (int i = 0; i < Length; i++)
            {
                if (maxValue <= current.Value)
                    maxValue = current.Value;
                current = current.Next;
            }
            return maxValue;
        }

        public int GetMinValue()
        {
            Node current = _root;
            int minValue = current.Value;
            for (int i = 0; i < Length; i++)
            {
                if (minValue >= current.Value)
                    minValue = current.Value;
                current = current.Next;
            }
            return minValue;
        }

        public void AddItemByIndex(int index, int value)
        {
            if ((index > Length) || (index < 0))
                throw new ArgumentException("Error: the index is out of bounds of the array.");
            else 
            {
                Node current = _root;
                for (int i = 0; i < Length + 1; i++)
                {
                    if (i == index - 1)
                    {
                        var temp = current.Next;
                        current.Next = new Node(value);
                        current.Next.Next = temp;
                        Length++;
                        break;
                    }
                    current = current.Next;
                }
            }
        }
        public void RemoveItemByIndex(int index)
        {
            if ((index < 0) || (index > Length))
                throw new ArgumentException("Error: no such index exists.");
            
            Node current = _root;

            for (int i = 0; i < Length + 1; i++)
            {
                if (i == index - 1)
                {
                    current.Next = current.Next.Next;
                    Length--;
                    break;
                }
                current = current.Next;
            }
        }

        public void AddFirst(int value)
        {
            var temp = _root;
            _root = new Node(value);
            _root.Next = temp;
            Length++;
        }
        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        public void RemoveFirst()
        {
            _root = _root.Next;
            Length--;
        }

        public string Show()
        {
            string answer = "[";
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (i == Length - 1)
                {
                    answer += Convert.ToString(current.Value);
                    break;
                }
                answer += Convert.ToString(current.Value) + ", ";
                current = current.Next;
            }

            answer += "]";
            return answer;
        }
        
        public override bool Equals(object obj)
        {
            ArrayList list = (ArrayList)obj;
            if (Length != list.Length)
                return false;
            
            Node currentThis = _root;
            Node currentObj = list._root;

            do
            {
                if (currentThis.Value != currentObj.Value)
                {
                    return false;
                }

                currentThis = currentThis.Next;
                currentObj = currentObj.Next;
            } while (!(currentThis.Next is null));
            return true;
        }
    }
}