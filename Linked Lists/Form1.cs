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

        private void btnAppend_Click(object sender, EventArgs e)
        {
            LinkedList.Append(Decimal.ToInt32(numAppend.Value));
            lblLinkedList.Text = LinkedList.ToString();
        }
    }
}
