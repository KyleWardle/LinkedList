using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
    class Node
    {
        private int _value;
        private Node _next_node;

        public Node(int input_value)
        {
            _value = input_value;
        }


        public Node NextNode
        {
            get { return _next_node; }
            set { _next_node = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string print_all(string previous = "[")
        {
            previous += _value;
            if (_next_node != null)
            {
                previous += ",";
                return _next_node.print_all(previous);
            }
            else
            {
                previous += "]";
                return previous;

            }
        }

    }
}
