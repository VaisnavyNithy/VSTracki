namespace VSTracki
{
    partial class bus_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bus_update));
            button1 = new Button();
            bus_no = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            Driver_ID = new TextBox();
            button2 = new Button();
            button3 = new Button();
            Departure = new ComboBox();
            Arrival = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(159, 286);
            button1.Name = "button1";
            button1.Size = new Size(112, 57);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bus_no
            // 
            bus_no.Location = new Point(318, 32);
            bus_no.Name = "bus_no";
            bus_no.Size = new Size(150, 31);
            bus_no.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 97);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 2;
            label1.Text = "Departure";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 167);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 3;
            label2.Text = "Arrival";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 229);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 4;
            label3.Text = "Driver_ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 31);
            label5.Name = "label5";
            label5.Size = new Size(177, 30);
            label5.TabIndex = 6;
            label5.Text = "Type the Bus No:";
            // 
            // Driver_ID
            // 
            Driver_ID.Location = new Point(286, 229);
            Driver_ID.Name = "Driver_ID";
            Driver_ID.Size = new Size(150, 31);
            Driver_ID.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(500, 23);
            button2.Name = "button2";
            button2.Size = new Size(149, 47);
            button2.TabIndex = 10;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(423, 286);
            button3.Name = "button3";
            button3.Size = new Size(123, 63);
            button3.TabIndex = 11;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Departure
            // 
            Departure.FormattingEnabled = true;
            Departure.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            Departure.Location = new Point(286, 97);
            Departure.Name = "Departure";
            Departure.Size = new Size(182, 33);
            Departure.TabIndex = 12;
            // 
            // Arrival
            // 
            Arrival.FormattingEnabled = true;
            Arrival.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            Arrival.Location = new Point(286, 164);
            Arrival.Name = "Arrival";
            Arrival.Size = new Size(182, 33);
            Arrival.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(Arrival);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Driver_ID);
            groupBox1.Controls.Add(bus_no);
            groupBox1.Controls.Add(Departure);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(309, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 371);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(579, 9);
            label4.Name = "label4";
            label4.Size = new Size(342, 38);
            label4.TabIndex = 14;
            label4.Text = "Bus Details Update Form";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 255);
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(113, 431);
            button4.Name = "button4";
            button4.Size = new Size(123, 63);
            button4.TabIndex = 14;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // bus_update
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1190, 564);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "bus_update";
            Text = "bus_update";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox bus_no;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox Driver_ID;
        private Button button2;
        private Button button3;
        private ComboBox Departure;
        private ComboBox Arrival;
        private GroupBox groupBox1;
        private Label label4;
        private Button button4;
    }
}