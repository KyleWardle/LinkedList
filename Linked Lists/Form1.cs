using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_Lists
{
    public partial class linked_list_form : Form
    {
        private LinkedList LinkedList = new LinkedList();

        public linked_list_form()
        {
            InitializeComponent();
        }

        private void UpdateText()
        {
            lblLinkedList.Text = LinkedList.ToString();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            LinkedList.Append(Decimal.ToInt32(numAppend.Value));
            UpdateText();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            LinkedList.BubbleSort();
            UpdateText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LinkedList = new LinkedList();
            UpdateText();
        }
    }
}
