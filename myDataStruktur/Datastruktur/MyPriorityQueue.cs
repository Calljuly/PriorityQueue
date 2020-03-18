using PriorityQueue;
using System;


namespace Datastruktur
{
     internal class Node<T>
     {
        internal T Data { get; set; }
        internal Node<T> LeftChild { get; set; }
        internal Node<T> RightChild { get; set; }
        internal Node<T> Parent { get; set; }

        public Node(T input)
        {
            Data = input;
        }
     }
     public class MyPriorityQueue<T> : IPriorityQueue<T> where T : IComparable, IComparable<T>
     {
        private Node<T> Root { get; set; }
        private Node<T> Pointer { get; set; }

        public int count = 0;

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                count++;
            }
            else
            {
                Pointer = Root;
                string bitCount = Convert.ToString(count + 1, 2);

                for (int i = 1; i < bitCount.Length; i++)
                {
                    if (bitCount[i] == '0')
                    {
                        if (Pointer.LeftChild == null)
                        {
                            Pointer.LeftChild = new Node<T>(data);
                            Pointer.LeftChild.Parent = Pointer;
                            count++;
                        }
                        Pointer = Pointer.LeftChild;
                    }
                    else
                    {
                        if (Pointer.RightChild == null)
                        {
                            Pointer.RightChild = new Node<T>(data);
                            Pointer.RightChild.Parent = Pointer;
                            count++;
                        }
                        Pointer = Pointer.RightChild;
                    }
                }

                while (true)
                {
                    if(Pointer.Parent == null)
                    {
                        break;
                    }
                    if (Pointer.Data.CompareTo(Pointer.Parent.Data) < 0)
                    {
                        T temporary = Pointer.Data;
                        Pointer.Data = Pointer.Parent.Data;
                        Pointer.Parent.Data = temporary;
                        Pointer = Pointer.Parent;
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Root does not have a value, the list is empty");
            }
            else
            {
                return Root.Data;
            }
        }
        public T Pop()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Root does not have a value, the list is empty");
            }
            else
            {
                T output = Root.Data;
                Pointer = Root;

                string bitcount = Convert.ToString(count, 2);
                for (int i = 1; i < bitcount.Length; i++)
                {
                    if (bitcount[i] == '0')
                    {
                        Pointer = Pointer.LeftChild;
                    }
                    else
                    {
                        Pointer = Pointer.RightChild;
                    }
                }

                Root.Data = Pointer.Data;

                if (Pointer != Root)
                {
                    if (Pointer.Parent.LeftChild == Pointer)
                    {
                        Pointer.Parent.LeftChild = null;
                    }
                    else
                    {
                        Pointer.Parent.RightChild = null;
                    }
                    count--;
                    ChangeOrderOfData();
                }
                else
                {
                    Root = null;
                    count--;
                }

                return output;
            }
        }


        private void ChangeOrderOfData()
        {
            Node<T> compare = null;
            Node<T> pointer = Root;

            while (true)
            {
                if (pointer.LeftChild == null)
                {
                    break;
                }
                if (pointer.RightChild == null)
                {
                    compare = pointer.LeftChild;
                }
                else
                {
                    if (pointer.LeftChild.Data.CompareTo(pointer.RightChild.Data) <= 0)
                    {
                        compare = pointer.LeftChild;
                    }
                    else
                    {
                        compare = pointer.RightChild;
                    }
                }
                if (pointer.Data.CompareTo(compare.Data) > 0)
                {
                    T temporary = pointer.Data;
                    pointer.Data = compare.Data;
                    compare.Data = temporary;
                    pointer = compare;
                }
                else
                {
                    break;
                }
            }
        }
     }
}
