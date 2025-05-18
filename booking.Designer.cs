namespace VSTracki
{
    partial class booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            p_name = new TextBox();
            button1 = new Button();
            p_Email = new TextBox();
            date = new DateTimePicker();
            departure = new ComboBox();
            arrival = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            p_id = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button8 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // p_name
            // 
            p_name.Location = new Point(574, 30);
            p_name.Name = "p_name";
            p_name.Size = new Size(150, 31);
            p_name.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(779, 30);
            button1.Name = "button1";
            button1.Size = new Size(101, 58);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // p_Email
            // 
            p_Email.Location = new Point(235, 30);
            p_Email.Name = "p_Email";
            p_Email.Size = new Size(150, 31);
            p_Email.TabIndex = 2;
            // 
            // date
            // 
            date.Location = new Point(226, 222);
            date.Name = "date";
            date.Size = new Size(300, 31);
            date.TabIndex = 6;
            // 
            // departure
            // 
            departure.FormattingEnabled = true;
            departure.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            departure.Location = new Point(228, 99);
            departure.Name = "departure";
            departure.Size = new Size(182, 33);
            departure.TabIndex = 7;
            // 
            // arrival
            // 
            arrival.FormattingEnabled = true;
            arrival.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            arrival.Location = new Point(228, 161);
            arrival.Name = "arrival";
            arrival.Size = new Size(182, 33);
            arrival.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(687, 552);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 9;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(75, 282);
            button3.Name = "button3";
            button3.Size = new Size(112, 54);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 255);
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(343, 282);
            button4.Name = "button4";
            button4.Size = new Size(112, 54);
            button4.TabIndex = 11;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // p_id
            // 
            p_id.Location = new Point(153, 24);
            p_id.Name = "p_id";
            p_id.Size = new Size(150, 31);
            p_id.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 27);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 18;
            label1.Text = "Passenger Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(440, 9);
            label3.Name = "label3";
            label3.Size = new Size(251, 38);
            label3.TabIndex = 20;
            label3.Text = "Booking Platform";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(126, 30);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 21;
            label4.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 96);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 23;
            label6.Text = "Departure:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(116, 158);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 24;
            label7.Text = "Arrival:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(118, 221);
            label8.Name = "label8";
            label8.Size = new Size(69, 32);
            label8.TabIndex = 25;
            label8.Text = "Date:";
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(92, 546);
            button8.Name = "button8";
            button8.Size = new Size(138, 63);
            button8.TabIndex = 29;
            button8.Text = "Back";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(p_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(p_name);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(113, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 119);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 19;
            label2.Text = "Passenger ID:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveCaption;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(arrival);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(departure);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(p_Email);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(date);
            groupBox2.Location = new Point(248, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 377);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1128, 614);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(label3);
            Name = "booking";
            Text = "booking";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox p_Email;
        private TextBox p_Phone;
        private DateTimePicker dateTimePicker1;
        private ComboBox departure;
        private ComboBox arrival;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private TextBox p_name;
        private TextBox p_id;
        private DateTimePicker date;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button6;
        private Button button8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
    }
}