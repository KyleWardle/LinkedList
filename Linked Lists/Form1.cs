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

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            LinkedList = LinkedList.MergeSort();
            UpdateText();
        }

        private void btnRandArray_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            LinkedList = new LinkedList();

            int arrayLength = rnd.Next(1, 30);
            arrayLength = 1000;

            for (int i = 0; i < arrayLength; i++)
            {
                LinkedList.Append(rnd.Next(1, 100));
            }

            UpdateText();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            for (int i = 25; i <= 1000; i = i + 25)
            {
                int b = i;
                LinkedList LinkedList = new LinkedList();

                while (b > 0)
                {
                    LinkedList.Append(b);
                    b--;
                }

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();

                LinkedList.MergeSort();

                watch.Stop();

                Console.WriteLine($"{watch.ElapsedMilliseconds}");

            }
        }
    }
}
