﻿namespace Linked_Lists
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
            System.Windows.Forms.Button btnReset;
            this.numAppend = new System.Windows.Forms.NumericUpDown();
            this.btnAppend = new System.Windows.Forms.Button();
            this.lblLinkedList = new System.Windows.Forms.Label();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAppend)).BeginInit();
            this.SuspendLayout();
            // 
            // numAppend
            // 
            this.numAppend.Location = new System.Drawing.Point(125, 306);
            this.numAppend.Margin = new System.Windows.Forms.Padding(4);
            this.numAppend.Name = "numAppend";
            this.numAppend.Size = new System.Drawing.Size(160, 22);
            this.numAppend.TabIndex = 0;
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(320, 306);
            this.btnAppend.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(100, 28);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // lblLinkedList
            // 
            this.lblLinkedList.AutoSize = true;
            this.lblLinkedList.Location = new System.Drawing.Point(200, 64);
            this.lblLinkedList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkedList.Name = "lblLinkedList";
            this.lblLinkedList.Size = new System.Drawing.Size(0, 17);
            this.lblLinkedList.TabIndex = 2;
            this.lblLinkedList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(320, 342);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(100, 23);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble ";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(13, 355);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linked_list_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 390);
            this.Controls.Add(btnReset);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.lblLinkedList);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.numAppend);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnBubbleSort;
    }
}

