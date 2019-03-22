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

        private int ReCalculateLength()
        {
            Node node = first_node;
            int count = 0;

            while (true)
            {
                count += 1;
                if (node.NextNode != null)
                {
                    node = node.NextNode;
                }
                else
                {
                    return count;
                }
            }
        }

        private Node ReCalculateLastNode()
        {
            Node node = first_node;
            while (true)
            {
                if (node.NextNode != null)
                {
                    node = node.NextNode;
                }
                else
                {
                    return node;
                }
            }
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
            Node node = first_node;
            string str = "";

            while (node != null)
            {
                str += $" => {node.Value}";
                node = node.NextNode;
            }

            return str;
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

        public LinkedList Merge(LinkedList other)
        {
            LinkedList merged = new LinkedList();

            while (length > 0 && other.length > 0)
            {
                if (Get(0) < other.Get(0))
                {
                    merged.Append(Get(0));
                    Delete(0);
                }
                else
                {
                    merged.Append(other.Get(0));
                    other.Delete(0);
                }
            }

            if (length < other.length)
            {
                int length_of_arr = other.length;
                for (int i = 0; i < length_of_arr; i++)
                {
                    merged.Append(other.Get(0));
                    other.Delete(0);
                }
            }
            else
            {
                int length_of_arr = length;
                for (int i = 0; i < length_of_arr; i++)
                {
                    merged.Append(Get(0));
                    Delete(0);
                }
            }

            return merged;
        }

        public LinkedList[] Split()
        {
            Node slow = first_node;
            Node fast = first_node;

            while (fast != null && fast.NextNode != null)
            {
                fast = fast.NextNode;
                if (fast.NextNode != null)
                {
                    fast = fast.NextNode;
                    slow = slow.NextNode;
                }
            }

            LinkedList firstHalf = new LinkedList();
            LinkedList secondHalf = new LinkedList();

            secondHalf.first_node = slow.NextNode;
            secondHalf.last_node = secondHalf.ReCalculateLastNode();
            secondHalf.length = secondHalf.ReCalculateLength();

            firstHalf.first_node = first_node;
            slow.NextNode = null;
            firstHalf.last_node = firstHalf.ReCalculateLastNode();
            firstHalf.length = firstHalf.ReCalculateLength();

            LinkedList[] arr = new LinkedList[2];

            arr[0] = firstHalf;
            arr[1] = secondHalf;

            return arr;
        }

        public LinkedList MergeSort()
        {
            if (length == 1)
            {
                return this;
            }
            else
            {
                LinkedList[] split_arr = Split();
                LinkedList a = split_arr[0].MergeSort();
                LinkedList b = split_arr[1].MergeSort();

                return a.Merge(b);
            }
        }
    }
}
