namespace WindowsFormsApplication1
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
            this.todoListing = new System.Windows.Forms.CheckedListBox();
            this.newTodo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListing
            // 
            this.todoListing.FormattingEnabled = true;
            this.todoListing.Items.AddRange(new object[] {
            "Enter a new todo item"});
            this.todoListing.Location = new System.Drawing.Point(13, 13);
            this.todoListing.Name = "todoListing";
            this.todoListing.Size = new System.Drawing.Size(182, 140);
            this.todoListing.TabIndex = 0;
            // 
            // newTodo
            // 
            this.newTodo.Location = new System.Drawing.Point(13, 160);
            this.newTodo.Name = "newTodo";
            this.newTodo.Size = new System.Drawing.Size(100, 22);
            this.newTodo.TabIndex = 1;
            this.newTodo.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toDelete
            // 
            this.toDelete.Location = new System.Drawing.Point(202, 13);
            this.toDelete.Name = "toDelete";
            this.toDelete.Size = new System.Drawing.Size(75, 23);
            this.toDelete.TabIndex = 3;
            this.toDelete.Text = "Delete";
            this.toDelete.UseVisualStyleBackColor = true;
            this.toDelete.Click += new System.EventHandler(this.toDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.toDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newTodo);
            this.Controls.Add(this.todoListing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox todoListing;
        private System.Windows.Forms.TextBox newTodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button toDelete;
    }
}

