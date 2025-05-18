namespace VSTracki
{
    partial class driver_salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driver_salary));
            salarydata = new DataGridView();
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)salarydata).BeginInit();
            SuspendLayout();
            // 
            // salarydata
            // 
            salarydata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salarydata.Location = new Point(46, 70);
            salarydata.Name = "salarydata";
            salarydata.RowHeadersWidth = 62;
            salarydata.Size = new Size(874, 354);
            salarydata.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(123, 434);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 1;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(311, 434);
            button3.Name = "button3";
            button3.Size = new Size(112, 52);
            button3.TabIndex = 3;
            button3.Text = "Insert Salary ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 4;
            label1.Text = "View Driver Salary";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(786, 430);
            button4.Name = "button4";
            button4.Size = new Size(112, 52);
            button4.TabIndex = 5;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // driver_salary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(987, 546);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(salarydata);
            Name = "driver_salary";
            Text = "driver_salary";
            Load += driver_salary_Load;
            ((System.ComponentModel.ISupportInitialize)salarydata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView salarydata;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}