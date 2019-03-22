using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
    class LinkedList
    {
        private Node first_node;
        private Node last_node;
        private int length;

        public LinkedList()
        {
            length = 0;
        }

        public void Append(int value)
        {
            Node new_node = new Node(value);

            if (first_node == null)
            {
                first_node = new_node;
            }
            else
            {
                last_node.NextNode = new_node;
            }

            last_node = new_node;
            length++;
        }

        public override string ToString()
        {
            if (first_node == null)
            {
                return "[]";
            }
            return first_node.print_all();
        }

        public int Get(int index)
        {
            Node node = first_node;
            for (int i = 0; i < index + 1; i++)
            {
                if (i == index)
                {
                    return node.Value;
                }

                if (node.NextNode != null)
                {
                    node = node.NextNode;
                }
            }
            throw new Exception();
        }

        public void Set(int index, int value)
        {
            Node node = first_node;
            for (int i = 0; i < index + 1; i++)
            {
                if (i == index)
                {
                    node.Value = value;
                    return;
                }

                if (node.NextNode != null)
                {
                    node = node.NextNode;
                }
            }
            throw new Exception();
        }

        public bool Swap(int from_index, int to_index)
        {
            int from_value = Get(from_index);
            int to_value = Get(to_index);

            Set(from_index, to_value);
            Set(to_index, from_value);

            return true;
        }

        public void Delete(int index)
        {
            Node node = first_node;
            Node prev_node = null;

            if (index == 0)
            {
                first_node = node.NextNode;
                length -= 1;
            }
            else
            {
                for (int i = 0; i < index + 1; i++)
                {
                    if (i == (index - 1))
                    {
                        prev_node = node;
                    }

                    if (i == index)
                    {
                        prev_node.NextNode = node.NextNode;
                        length -= 1;
                    }

                    if (node.NextNode != null)
                    {
                        node = node.NextNode;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }

        public bool BubbleSort()
        {
            for (int a = 0; a < length - 1; a++)
            {
                for (int b = 0; b < length - (a + 1); b++)
                {
                    if (Get(b) > Get(b + 1))
                    {
                        Swap(b, b + 1);
                    }
                }
            }

            return true;
        }
    }
}
