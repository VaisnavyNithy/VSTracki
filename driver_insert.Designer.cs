namespace VSTracki
{
    partial class driver_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driver_insert));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Salary = new TextBox();
            bus_no = new TextBox();
            name = new TextBox();
            DriverID = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(110, 322);
            button1.Name = "button1";
            button1.Size = new Size(119, 60);
            button1.TabIndex = 0;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 62);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 1;
            label1.Text = "Driver ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 118);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 191);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 3;
            label3.Text = "Bus_No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 257);
            label4.Name = "label4";
            label4.Size = new Size(130, 30);
            label4.TabIndex = 4;
            label4.Text = "Basic Salary:";
            // 
            // Salary
            // 
            Salary.Location = new Point(240, 251);
            Salary.Name = "Salary";
            Salary.Size = new Size(150, 31);
            Salary.TabIndex = 5;
            // 
            // bus_no
            // 
            bus_no.Location = new Point(240, 191);
            bus_no.Name = "bus_no";
            bus_no.Size = new Size(150, 31);
            bus_no.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(240, 118);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 7;
            // 
            // DriverID
            // 
            DriverID.Location = new Point(240, 62);
            DriverID.Name = "DriverID";
            DriverID.Size = new Size(150, 31);
            DriverID.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(359, 327);
            button2.Name = "button2";
            button2.Size = new Size(112, 55);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(210, 472);
            button3.Name = "button3";
            button3.Size = new Size(112, 61);
            button3.TabIndex = 10;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DriverID);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Salary);
            groupBox1.Controls.Add(bus_no);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(306, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 388);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(471, 9);
            label5.Name = "label5";
            label5.Size = new Size(261, 38);
            label5.TabIndex = 10;
            label5.Text = "Driver Insert Panel";
            // 
            // driver_insert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 573);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Name = "driver_insert";
            Text = "driver_insert";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Salary;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox bus_no;
        private TextBox name;
        private TextBox DriverID;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Label label5;
    }
}