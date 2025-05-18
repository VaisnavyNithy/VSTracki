namespace VSTracki
{
    partial class bus_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bus_insert));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bus_no = new TextBox();
            driver_id = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            Arrival = new ComboBox();
            Departure = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 0;
            label1.Text = "Bus No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Departure";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 249);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 2;
            label3.Text = "Driver ID:";
            // 
            // bus_no
            // 
            bus_no.Location = new Point(350, 30);
            bus_no.Name = "bus_no";
            bus_no.Size = new Size(150, 31);
            bus_no.TabIndex = 3;
            // 
            // driver_id
            // 
            driver_id.Location = new Point(350, 250);
            driver_id.Name = "driver_id";
            driver_id.Size = new Size(150, 31);
            driver_id.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(139, 324);
            button1.Name = "button1";
            button1.Size = new Size(112, 54);
            button1.TabIndex = 6;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(421, 329);
            button2.Name = "button2";
            button2.Size = new Size(127, 54);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(298, 505);
            button3.Name = "button3";
            button3.Size = new Size(112, 44);
            button3.TabIndex = 8;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(147, 172);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 10;
            label4.Text = "Arrival";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(632, 9);
            label5.Name = "label5";
            label5.Size = new Size(225, 38);
            label5.TabIndex = 11;
            label5.Text = "Bus Insert Form";
            // 
            // Arrival
            // 
            Arrival.FormattingEnabled = true;
            Arrival.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            Arrival.Location = new Point(350, 173);
            Arrival.Name = "Arrival";
            Arrival.Size = new Size(182, 33);
            Arrival.TabIndex = 12;
            // 
            // Departure
            // 
            Departure.FormattingEnabled = true;
            Departure.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            Departure.Location = new Point(350, 99);
            Departure.Name = "Departure";
            Departure.Size = new Size(182, 33);
            Departure.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(bus_no);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Arrival);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Departure);
            groupBox1.Controls.Add(driver_id);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(427, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(697, 440);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // bus_insert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1462, 636);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Name = "bus_insert";
            Text = "bus_insert";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox bus_no;
        private TextBox driver_id;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private ComboBox Arrival;
        private ComboBox Departure;
        private GroupBox groupBox1;
    }
}