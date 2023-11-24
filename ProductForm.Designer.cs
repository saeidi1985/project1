namespace Project1
{
    partial class ProductForm
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
            Name_label = new Label();
            Name_textBox = new TextBox();
            save_button = new Button();
            IsActive_checkBox = new CheckBox();
            BrandName_textBox = new TextBox();
            BrandName_label = new Label();
            Price_textBox = new TextBox();
            Price_label = new Label();
            Count_textBox = new TextBox();
            Count_label = new Label();
            SuspendLayout();
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Location = new Point(24, 18);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(39, 15);
            Name_label.TabIndex = 0;
            Name_label.Text = "Name";
            Name_label.Click += label1_Click;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(84, 15);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(100, 23);
            Name_textBox.TabIndex = 1;
            // 
            // save_button
            // 
            save_button.Location = new Point(24, 179);
            save_button.Name = "save_button";
            save_button.Size = new Size(174, 32);
            save_button.TabIndex = 2;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // IsActive_checkBox
            // 
            IsActive_checkBox.AutoSize = true;
            IsActive_checkBox.Location = new Point(100, 141);
            IsActive_checkBox.Name = "IsActive_checkBox";
            IsActive_checkBox.Size = new Size(67, 19);
            IsActive_checkBox.TabIndex = 3;
            IsActive_checkBox.Text = "IsActive";
            IsActive_checkBox.UseVisualStyleBackColor = true;
            // 
            // BrandName_textBox
            // 
            BrandName_textBox.Location = new Point(84, 44);
            BrandName_textBox.Name = "BrandName_textBox";
            BrandName_textBox.Size = new Size(100, 23);
            BrandName_textBox.TabIndex = 5;
            // 
            // BrandName_label
            // 
            BrandName_label.AutoSize = true;
            BrandName_label.Location = new Point(24, 44);
            BrandName_label.Name = "BrandName_label";
            BrandName_label.Size = new Size(70, 15);
            BrandName_label.TabIndex = 4;
            BrandName_label.Text = "BrandName";
            // 
            // Price_textBox
            // 
            Price_textBox.Location = new Point(84, 72);
            Price_textBox.Name = "Price_textBox";
            Price_textBox.Size = new Size(100, 23);
            Price_textBox.TabIndex = 7;
            // 
            // Price_label
            // 
            Price_label.AutoSize = true;
            Price_label.Location = new Point(24, 72);
            Price_label.Name = "Price_label";
            Price_label.Size = new Size(33, 15);
            Price_label.TabIndex = 6;
            Price_label.Text = "Price";
            // 
            // Count_textBox
            // 
            Count_textBox.Location = new Point(84, 101);
            Count_textBox.Name = "Count_textBox";
            Count_textBox.Size = new Size(100, 23);
            Count_textBox.TabIndex = 9;
            // 
            // Count_label
            // 
            Count_label.AutoSize = true;
            Count_label.Location = new Point(24, 99);
            Count_label.Name = "Count_label";
            Count_label.Size = new Size(40, 15);
            Count_label.TabIndex = 8;
            Count_label.Text = "Count";
            Count_label.Click += label4_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 320);
            Controls.Add(Count_textBox);
            Controls.Add(Count_label);
            Controls.Add(Price_textBox);
            Controls.Add(Price_label);
            Controls.Add(BrandName_textBox);
            Controls.Add(BrandName_label);
            Controls.Add(IsActive_checkBox);
            Controls.Add(save_button);
            Controls.Add(Name_textBox);
            Controls.Add(Name_label);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_label;
        private TextBox Name_textBox;
        private Button save_button;
        private CheckBox IsActive_checkBox;
        private TextBox BrandName_textBox;
        private Label BrandName_label;
        private TextBox Price_textBox;
        private Label Price_label;
        private TextBox Count_textBox;
        private Label Count_label;
    }
}