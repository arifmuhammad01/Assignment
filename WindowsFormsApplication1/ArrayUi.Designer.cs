namespace WindowsFormsApplication1
{
    partial class ArrayUi
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.firstArrayTextBox = new System.Windows.Forms.RichTextBox();
            this.cloneTextBox = new System.Windows.Forms.RichTextBox();
            this.oddTextBox = new System.Windows.Forms.RichTextBox();
            this.evenTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Even";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.evenbutton_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(371, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Odd";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.oddbutton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Clone";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(219, 21);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(197, 20);
            this.addTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_Click);
            // 
            // firstArrayTextBox
            // 
            this.firstArrayTextBox.Location = new System.Drawing.Point(22, 183);
            this.firstArrayTextBox.Name = "firstArrayTextBox";
            this.firstArrayTextBox.Size = new System.Drawing.Size(117, 194);
            this.firstArrayTextBox.TabIndex = 3;
            this.firstArrayTextBox.Text = "";
            // 
            // cloneTextBox
            // 
            this.cloneTextBox.Location = new System.Drawing.Point(160, 183);
            this.cloneTextBox.Name = "cloneTextBox";
            this.cloneTextBox.Size = new System.Drawing.Size(135, 194);
            this.cloneTextBox.TabIndex = 3;
            this.cloneTextBox.Text = "";
            // 
            // oddTextBox
            // 
            this.oddTextBox.Location = new System.Drawing.Point(343, 183);
            this.oddTextBox.Name = "oddTextBox";
            this.oddTextBox.Size = new System.Drawing.Size(124, 194);
            this.oddTextBox.TabIndex = 3;
            this.oddTextBox.Text = "";
            // 
            // evenTextBox
            // 
            this.evenTextBox.Location = new System.Drawing.Point(513, 183);
            this.evenTextBox.Name = "evenTextBox";
            this.evenTextBox.Size = new System.Drawing.Size(122, 194);
            this.evenTextBox.TabIndex = 3;
            this.evenTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inputed Array";
            // 
            // ArrayUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evenTextBox);
            this.Controls.Add(this.oddTextBox);
            this.Controls.Add(this.cloneTextBox);
            this.Controls.Add(this.firstArrayTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "ArrayUi";
            this.Text = "ArrayUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox firstArrayTextBox;
        private System.Windows.Forms.RichTextBox cloneTextBox;
        private System.Windows.Forms.RichTextBox oddTextBox;
        private System.Windows.Forms.RichTextBox evenTextBox;
        private System.Windows.Forms.Label label1;
    }
}