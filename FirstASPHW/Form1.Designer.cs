namespace FirstASPHW
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
            ReturnAllBtn = new Button();
            ReturnMaxBtn = new Button();
            ReturnMinBtn = new Button();
            CustomQueryBtn = new Button();
            ResultsBox = new RichTextBox();
            QueryTxtBox = new TextBox();
            SuspendLayout();
            // 
            // ReturnAllBtn
            // 
            ReturnAllBtn.Location = new Point(12, 12);
            ReturnAllBtn.Name = "ReturnAllBtn";
            ReturnAllBtn.Size = new Size(94, 29);
            ReturnAllBtn.TabIndex = 0;
            ReturnAllBtn.Text = "Return All";
            ReturnAllBtn.UseVisualStyleBackColor = true;
            ReturnAllBtn.Click += ReturnAllBtn_Click;
            // 
            // ReturnMaxBtn
            // 
            ReturnMaxBtn.Location = new Point(125, 12);
            ReturnMaxBtn.Name = "ReturnMaxBtn";
            ReturnMaxBtn.Size = new Size(94, 29);
            ReturnMaxBtn.TabIndex = 1;
            ReturnMaxBtn.Text = "Return Max";
            ReturnMaxBtn.UseVisualStyleBackColor = true;
            ReturnMaxBtn.Click += ReturnMaxBtn_Click;
            // 
            // ReturnMinBtn
            // 
            ReturnMinBtn.Location = new Point(243, 12);
            ReturnMinBtn.Name = "ReturnMinBtn";
            ReturnMinBtn.Size = new Size(94, 29);
            ReturnMinBtn.TabIndex = 2;
            ReturnMinBtn.Text = "Return Min";
            ReturnMinBtn.UseVisualStyleBackColor = true;
            ReturnMinBtn.Click += ReturnMinBtn_Click;
            // 
            // CustomQueryBtn
            // 
            CustomQueryBtn.Location = new Point(694, 10);
            CustomQueryBtn.Name = "CustomQueryBtn";
            CustomQueryBtn.Size = new Size(94, 29);
            CustomQueryBtn.TabIndex = 3;
            CustomQueryBtn.Text = "Start Query";
            CustomQueryBtn.UseVisualStyleBackColor = true;
            CustomQueryBtn.Click += CustomQueryBtn_Click;
            // 
            // ResultsBox
            // 
            ResultsBox.Location = new Point(12, 47);
            ResultsBox.Name = "ResultsBox";
            ResultsBox.Size = new Size(776, 391);
            ResultsBox.TabIndex = 4;
            ResultsBox.Text = "";
            // 
            // QueryTxtBox
            // 
            QueryTxtBox.Location = new Point(358, 12);
            QueryTxtBox.Name = "QueryTxtBox";
            QueryTxtBox.Size = new Size(317, 27);
            QueryTxtBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QueryTxtBox);
            Controls.Add(ResultsBox);
            Controls.Add(CustomQueryBtn);
            Controls.Add(ReturnMinBtn);
            Controls.Add(ReturnMaxBtn);
            Controls.Add(ReturnAllBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnAllBtn;
        private Button ReturnMaxBtn;
        private Button ReturnMinBtn;
        private Button CustomQueryBtn;
        private RichTextBox ResultsBox;
        private TextBox QueryTxtBox;
    }
}