namespace ToDoListApp
{
    partial class Form1
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
            this.Add_item_button = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.todoList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Add_item_button
            // 
            this.Add_item_button.Location = new System.Drawing.Point(168, 56);
            this.Add_item_button.Name = "Add_item_button";
            this.Add_item_button.Size = new System.Drawing.Size(104, 23);
            this.Add_item_button.TabIndex = 0;
            this.Add_item_button.Text = "Add New Item";
            this.Add_item_button.UseVisualStyleBackColor = true;
            this.Add_item_button.Click += new System.EventHandler(this.Add_item_button_Click);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(12, 59);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(150, 20);
            this.itemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "My To-Do List App";
            // 
            // todoList
            // 
            this.todoList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoList.FormattingEnabled = true;
            this.todoList.Location = new System.Drawing.Point(12, 90);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(260, 270);
            this.todoList.TabIndex = 2;
            this.todoList.SelectedIndexChanged += new System.EventHandler(this.todoList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.Add_item_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_item_button;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox todoList;
    }
}

