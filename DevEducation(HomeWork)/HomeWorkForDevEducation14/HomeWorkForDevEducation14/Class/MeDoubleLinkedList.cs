using System;
using System.Collections;
using System.Collections.Generic;
using HomeWorkForDevEducation14.Class;

namespace HomeWorkForDevEducation14
{
    public class MyDoubleLinkedList : IDoubleLinkedList<int>, IEnumerable
    {
        private sealed class RootTailLengthEqualityComparer : IEqualityComparer<MyDoubleLinkedList>
        {
            public bool Equals(MyDoubleLinkedList x, MyDoubleLinkedList y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return Equals(x._root, y._root) && Equals(x._tail, y._tail) && x.Length == y.Length;
            }

            public int GetHashCode(MyDoubleLinkedList obj)
            {
                unchecked
                {
                    var hashCode = (obj._root != null ? obj._root.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj._tail != null ? obj._tail.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ obj.Length;
                    return hashCode;
                }
            }
        }

        public static IEqualityComparer<MyDoubleLinkedList> RootTailLengthComparer { get; } = new RootTailLengthEqualityComparer();

        protected bool Equals(MyDoubleLinkedList other)
        {
            return Equals(_root, other._root) && Equals(_tail, other._tail) && Length == other.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MyDoubleLinkedList) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_root != null ? _root.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_tail != null ? _tail.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Length;
                return hashCode;
            }
        }

        public IEnumerator GetEnumerator()
        {
            int[] arrayForEnumerator = new int[Length];
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                arrayForEnumerator[i] = current.Value;
                current = current.Next;
            }

            return arrayForEnumerator.GetEnumerator();
        }

        public int Length { get; set; }
        private Node _root;
        private Node _tail;

        public MyDoubleLinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public MyDoubleLinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public MyDoubleLinkedList(int[] values)
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
        public void AddLast(int value)
        {
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if ( i == Length - 1)
                {
                    current.Next = new Node(value);
                    Length++;
                    break;
                }
                current = current.Next;
            }
        }

        public void AddFist(int value)
        {
            Node temp = _root;
            _root = new Node(value);
            _root.Next = temp;
            Length++;
        }

        public int IndexOf(int value)
        {
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                    return i; 
                current = current.Next;
            }
            throw new ArgumentException("Error: Value was not found.");
        }

        public bool Remove(int value)
        {
            Node current = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    Length--;
                    return true;
                }
                current = current.Next;
            }
            throw new ArgumentException("Error: No such value found."); 
        }
        

        public bool Contains(int value)
        {
            Node current = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                if (current.Value == value)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            _root = null;
            Length = 0;
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
        public int Count => Length;
        public bool isEmpty => Count != 0 ? false : true; 
        
        public IEnumerable<int> backEnumerable()
        {
            throw new System.NotImplementedException();
        }
    }
}