namespace VSTracki
{
    partial class fuel_expense_tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fuel_expense_tracker));
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            fuel_total = new TextBox();
            fuel_price = new TextBox();
            fuel_litre = new TextBox();
            fuel_date = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            fuel_expense = new DataGridView();
            fuel_summary_total = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fuel_expense).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(248, 147);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(fuel_total);
            groupBox1.Controls.Add(fuel_price);
            groupBox1.Controls.Add(fuel_litre);
            groupBox1.Controls.Add(fuel_date);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(235, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 187);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 13;
            label3.Text = "Litres Required:";
            // 
            // fuel_total
            // 
            fuel_total.Location = new Point(474, 93);
            fuel_total.Name = "fuel_total";
            fuel_total.ReadOnly = true;
            fuel_total.Size = new Size(150, 31);
            fuel_total.TabIndex = 12;
            // 
            // fuel_price
            // 
            fuel_price.Location = new Point(577, 42);
            fuel_price.Name = "fuel_price";
            fuel_price.Size = new Size(150, 31);
            fuel_price.TabIndex = 11;
            // 
            // fuel_litre
            // 
            fuel_litre.Location = new Point(147, 90);
            fuel_litre.Name = "fuel_litre";
            fuel_litre.Size = new Size(150, 31);
            fuel_litre.TabIndex = 10;
            // 
            // fuel_date
            // 
            fuel_date.Location = new Point(90, 37);
            fuel_date.Name = "fuel_date";
            fuel_date.Size = new Size(300, 31);
            fuel_date.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 43);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 8;
            label2.Text = "Price Per Liter:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 96);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 7;
            label1.Text = "Total Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 43);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 6;
            label7.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 96);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(330, 9);
            label5.Name = "label5";
            label5.Size = new Size(332, 45);
            label5.TabIndex = 4;
            label5.Text = "Fuel Expense Tracker";
            // 
            // fuel_expense
            // 
            fuel_expense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fuel_expense.Location = new Point(50, 57);
            fuel_expense.Name = "fuel_expense";
            fuel_expense.RowHeadersWidth = 62;
            fuel_expense.Size = new Size(1043, 225);
            fuel_expense.TabIndex = 7;
            // 
            // fuel_summary_total
            // 
            fuel_summary_total.AutoSize = true;
            fuel_summary_total.Location = new Point(406, 516);
            fuel_summary_total.Name = "fuel_summary_total";
            fuel_summary_total.Size = new Size(59, 25);
            fuel_summary_total.TabIndex = 13;
            fuel_summary_total.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(64, 472);
            button2.Name = "button2";
            button2.Size = new Size(131, 69);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fuel_expense_tracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 574);
            Controls.Add(button2);
            Controls.Add(fuel_summary_total);
            Controls.Add(label5);
            Controls.Add(fuel_expense);
            Controls.Add(groupBox1);
            Name = "fuel_expense_tracker";
            Text = "fuel_expense_tracker";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fuel_expense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView fuel_expense;
        private DateTimePicker fuel_date;
        private Label label2;
        private Label label1;
        private TextBox fuel_total;
        private TextBox fuel_price;
        private TextBox fuel_litre;
        private Label fuel_summary_total;
        private Label label3;
        private Button button2;
    }
}