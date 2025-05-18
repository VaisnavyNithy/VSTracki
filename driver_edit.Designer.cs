namespace VSTracki
{
    partial class driver_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driver_edit));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            salary = new TextBox();
            bus_no = new TextBox();
            driver_name = new TextBox();
            driver_id = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(94, 302);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(460, 18);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 1;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 27);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 2;
            label1.Text = "Enter Driver ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 103);
            label2.Name = "label2";
            label2.Size = new Size(141, 30);
            label2.TabIndex = 3;
            label2.Text = "Driver Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 165);
            label3.Name = "label3";
            label3.Size = new Size(93, 30);
            label3.TabIndex = 4;
            label3.Text = " Bus No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 232);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 5;
            label4.Text = "Salary:";
            // 
            // salary
            // 
            salary.Location = new Point(272, 231);
            salary.Name = "salary";
            salary.Size = new Size(150, 31);
            salary.TabIndex = 6;
            // 
            // bus_no
            // 
            bus_no.Location = new Point(272, 166);
            bus_no.Name = "bus_no";
            bus_no.Size = new Size(150, 31);
            bus_no.TabIndex = 7;
            // 
            // driver_name
            // 
            driver_name.Location = new Point(272, 103);
            driver_name.Name = "driver_name";
            driver_name.Size = new Size(150, 31);
            driver_name.TabIndex = 8;
            // 
            // driver_id
            // 
            driver_id.Location = new Point(252, 27);
            driver_id.Name = "driver_id";
            driver_id.Size = new Size(150, 31);
            driver_id.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(salary);
            groupBox1.Controls.Add(bus_no);
            groupBox1.Controls.Add(driver_name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(driver_id);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(219, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 364);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(370, 302);
            button3.Name = "button3";
            button3.Size = new Size(112, 45);
            button3.TabIndex = 10;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(67, 436);
            button4.Name = "button4";
            button4.Size = new Size(112, 45);
            button4.TabIndex = 11;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(375, 9);
            label5.Name = "label5";
            label5.Size = new Size(280, 38);
            label5.TabIndex = 12;
            label5.Text = "Driver Update Panel";
           
            // 
            // driver_edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 518);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Name = "driver_edit";
            Text = "driver_edit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox salary;
        private TextBox bus_no;
        private TextBox driver_name;
        private TextBox driver_id;
        private GroupBox groupBox1;
        private Button button3;
        private Button button4;
        private Label label5;
    }
}