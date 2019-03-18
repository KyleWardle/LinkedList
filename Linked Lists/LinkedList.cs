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
                last_node = new_node;
            }
            else
            {
                last_node.NextNode = new_node;
                last_node = new_node;
                length++;
            }
        }

        public override string ToString()
        {
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
    }
}
