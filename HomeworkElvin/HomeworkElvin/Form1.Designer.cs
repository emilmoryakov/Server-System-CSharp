namespace HomeworkElvin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReturnBtn = new Button();
            MaximumBtn = new Button();
            MinimumBtn = new Button();
            ResultsBox = new RichTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnBtn.Location = new Point(3, 10);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(94, 29);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "Return All";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // MaximumBtn
            // 
            MaximumBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumBtn.Location = new Point(103, 9);
            MaximumBtn.Name = "MaximumBtn";
            MaximumBtn.Size = new Size(94, 29);
            MaximumBtn.TabIndex = 1;
            MaximumBtn.Text = "Max";
            MaximumBtn.UseVisualStyleBackColor = true;
            MaximumBtn.Click += MaximumBtn_Click;
            // 
            // MinimumBtn
            // 
            MinimumBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumBtn.Location = new Point(203, 9);
            MinimumBtn.Name = "MinimumBtn";
            MinimumBtn.Size = new Size(94, 29);
            MinimumBtn.TabIndex = 2;
            MinimumBtn.Text = "Min";
            MinimumBtn.UseVisualStyleBackColor = true;
            MinimumBtn.Click += MinimumBtn_Click;
            // 
            // ResultsBox
            // 
            ResultsBox.Location = new Point(9, 44);
            ResultsBox.Name = "ResultsBox";
            ResultsBox.Size = new Size(786, 668);
            ResultsBox.TabIndex = 4;
            ResultsBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 5;
            label1.Text = "Enter Query:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 27);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(734, 9);
            button1.Name = "button1";
            button1.Size = new Size(61, 29);
            button1.TabIndex = 7;
            button1.Text = "CustomQueryBtn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 727);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(ResultsBox);
            Controls.Add(MinimumBtn);
            Controls.Add(MaximumBtn);
            Controls.Add(ReturnBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnBtn;
        private Button MaximumBtn;
        private Button MinimumBtn;
        private RichTextBox ResultsBox;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}