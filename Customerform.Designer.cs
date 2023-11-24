namespace Project1
{
    partial class Customerform
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
            FirstName_label = new Label();
            FirstName_textBox = new TextBox();
            LastName_textBox = new TextBox();
            LastName_label = new Label();
            PhoneNumber_textBox = new TextBox();
            PhoneNumber_label = new Label();
            Emaill_textBox = new TextBox();
            Emaill_label = new Label();
            Save_button = new Button();
            SuspendLayout();
            // 
            // FirstName_label
            // 
            FirstName_label.AutoSize = true;
            FirstName_label.Location = new Point(12, 17);
            FirstName_label.Name = "FirstName_label";
            FirstName_label.Size = new Size(61, 15);
            FirstName_label.TabIndex = 0;
            FirstName_label.Text = "FirstName";
            FirstName_label.Click += label1_Click;
            // 
            // FirstName_textBox
            // 
            FirstName_textBox.Location = new Point(103, 9);
            FirstName_textBox.Name = "FirstName_textBox";
            FirstName_textBox.Size = new Size(100, 23);
            FirstName_textBox.TabIndex = 1;
            // 
            // LastName_textBox
            // 
            LastName_textBox.Location = new Point(103, 38);
            LastName_textBox.Name = "LastName_textBox";
            LastName_textBox.Size = new Size(100, 23);
            LastName_textBox.TabIndex = 3;
            // 
            // LastName_label
            // 
            LastName_label.AutoSize = true;
            LastName_label.Location = new Point(12, 46);
            LastName_label.Name = "LastName_label";
            LastName_label.Size = new Size(60, 15);
            LastName_label.TabIndex = 2;
            LastName_label.Text = "LastName";
            // 
            // PhoneNumber_textBox
            // 
            PhoneNumber_textBox.Location = new Point(103, 102);
            PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            PhoneNumber_textBox.Size = new Size(100, 23);
            PhoneNumber_textBox.TabIndex = 7;
            // 
            // PhoneNumber_label
            // 
            PhoneNumber_label.AutoSize = true;
            PhoneNumber_label.Location = new Point(12, 105);
            PhoneNumber_label.Name = "PhoneNumber_label";
            PhoneNumber_label.Size = new Size(85, 15);
            PhoneNumber_label.TabIndex = 6;
            PhoneNumber_label.Text = "PhoneNumber";
            // 
            // Emaill_textBox
            // 
            Emaill_textBox.Location = new Point(103, 68);
            Emaill_textBox.Name = "Emaill_textBox";
            Emaill_textBox.Size = new Size(100, 23);
            Emaill_textBox.TabIndex = 5;
            // 
            // Emaill_label
            // 
            Emaill_label.AutoSize = true;
            Emaill_label.Location = new Point(12, 76);
            Emaill_label.Name = "Emaill_label";
            Emaill_label.Size = new Size(39, 15);
            Emaill_label.TabIndex = 4;
            Emaill_label.Text = "Emaill";
            Emaill_label.Click += label4_Click;
            // 
            // Save_button
            // 
            Save_button.Location = new Point(83, 155);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(147, 34);
            Save_button.TabIndex = 8;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // Customerform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(Save_button);
            Controls.Add(PhoneNumber_textBox);
            Controls.Add(PhoneNumber_label);
            Controls.Add(Emaill_textBox);
            Controls.Add(Emaill_label);
            Controls.Add(LastName_textBox);
            Controls.Add(LastName_label);
            Controls.Add(FirstName_textBox);
            Controls.Add(FirstName_label);
            Name = "Customerform";
            Text = "Customerform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName_label;
        private TextBox FirstName_textBox;
        private TextBox LastName_textBox;
        private Label LastName_label;
        private TextBox PhoneNumber_textBox;
        private Label PhoneNumber_label;
        private TextBox Emaill_textBox;
        private Label Emaill_label;
        private Button Save_button;
    }
}