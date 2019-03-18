namespace Linked_Lists
{
    partial class linked_list_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numAppend = new System.Windows.Forms.NumericUpDown();
            this.btnAppend = new System.Windows.Forms.Button();
            this.lblLinkedList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAppend)).BeginInit();
            this.SuspendLayout();
            // 
            // numAppend
            // 
            this.numAppend.Location = new System.Drawing.Point(94, 249);
            this.numAppend.Name = "numAppend";
            this.numAppend.Size = new System.Drawing.Size(120, 20);
            this.numAppend.TabIndex = 0;
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(240, 249);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // lblLinkedList
            // 
            this.lblLinkedList.AutoSize = true;
            this.lblLinkedList.Location = new System.Drawing.Point(150, 52);
            this.lblLinkedList.Name = "lblLinkedList";
            this.lblLinkedList.Size = new System.Drawing.Size(0, 13);
            this.lblLinkedList.TabIndex = 2;
            this.lblLinkedList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linked_list_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 317);
            this.Controls.Add(this.lblLinkedList);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.numAppend);
            this.Name = "linked_list_form";
            this.Text = "Linked List";
            ((System.ComponentModel.ISupportInitialize)(this.numAppend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numAppend;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Label lblLinkedList;
    }
}

