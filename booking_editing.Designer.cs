namespace VSTracki
{
    partial class booking_editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking_editing));
            label2 = new Label();
            label1 = new Label();
            p_id = new TextBox();
            button1 = new Button();
            p_name = new TextBox();
            dataGridView1 = new DataGridView();
            booking_id = new TextBox();
            arrival = new ComboBox();
            date = new DateTimePicker();
            departure = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 39);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 24;
            label2.Text = "Passenger ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(638, 38);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 23;
            label1.Text = "Passenger Name:";
            // 
            // p_id
            // 
            p_id.Location = new Point(405, 38);
            p_id.Name = "p_id";
            p_id.Size = new Size(150, 31);
            p_id.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1162, 30);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 21;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // p_name
            // 
            p_name.Location = new Point(930, 39);
            p_name.Name = "p_name";
            p_name.Size = new Size(150, 31);
            p_name.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 225);
            dataGridView1.TabIndex = 25;
            // 
            // booking_id
            // 
            booking_id.Location = new Point(350, 253);
            booking_id.Name = "booking_id";
            booking_id.Size = new Size(150, 31);
            booking_id.TabIndex = 26;
            // 
            // arrival
            // 
            arrival.FormattingEnabled = true;
            arrival.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            arrival.Location = new Point(295, 111);
            arrival.Name = "arrival";
            arrival.Size = new Size(182, 33);
            arrival.TabIndex = 29;
            // 
            // date
            // 
            date.Location = new Point(205, 195);
            date.Name = "date";
            date.Size = new Size(300, 31);
            date.TabIndex = 27;
            // 
            // departure
            // 
            departure.FormattingEnabled = true;
            departure.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            departure.Location = new Point(295, 40);
            departure.Name = "departure";
            departure.Size = new Size(182, 33);
            departure.TabIndex = 28;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(550, 253);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 30;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 255);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(81, 284);
            button3.Name = "button3";
            button3.Size = new Size(112, 49);
            button3.TabIndex = 31;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(614, 9);
            label3.Name = "label3";
            label3.Size = new Size(315, 38);
            label3.TabIndex = 32;
            label3.Text = "Booking Editing Portal";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(p_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(p_name);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(76, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1461, 102);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveCaption;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(booking_id);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(76, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(978, 333);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(151, 262);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 25;
            label4.Text = "Booking ID:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.InactiveCaption;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(date);
            groupBox3.Controls.Add(departure);
            groupBox3.Controls.Add(arrival);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(1048, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(511, 410);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 41);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 25;
            label5.Text = "Departure:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 112);
            label6.Name = "label6";
            label6.Size = new Size(86, 32);
            label6.TabIndex = 26;
            label6.Text = "Arrival:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 195);
            label7.Name = "label7";
            label7.Size = new Size(69, 32);
            label7.TabIndex = 27;
            label7.Text = "Date:";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 192);
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(318, 284);
            button4.Name = "button4";
            button4.Size = new Size(112, 49);
            button4.TabIndex = 32;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 255, 255);
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(426, 517);
            button5.Name = "button5";
            button5.Size = new Size(178, 123);
            button5.TabIndex = 33;
            button5.Text = "Proceed to Booking Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // booking_editing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1633, 642);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "booking_editing";
            Text = "booking_editing";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox p_id;
        private Button button1;
        private TextBox p_name;
        private DataGridView dataGridView1;
        private TextBox booking_id;
        private ComboBox arrival;
        private ComboBox departure;
        private DateTimePicker date;
        private Button button2;
        private Button button3;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
        private Button button5;
    }
}