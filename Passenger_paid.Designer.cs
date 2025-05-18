namespace VSTracki
{
    partial class Passenger_paid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_paid));
            label1 = new Label();
            p_fare = new TextBox();
            p_arrival = new ComboBox();
            p_departure = new ComboBox();
            button1 = new Button();
            p_status = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            p_id = new TextBox();
            label5 = new Label();
            label6 = new Label();
            view_payment = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 38);
            label1.TabIndex = 0;
            label1.Text = "Passenger Payment Form";
            // 
            // p_fare
            // 
            p_fare.Location = new Point(229, 259);
            p_fare.Name = "p_fare";
            p_fare.Size = new Size(150, 31);
            p_fare.TabIndex = 2;
            // 
            // p_arrival
            // 
            p_arrival.FormattingEnabled = true;
            p_arrival.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            p_arrival.Location = new Point(218, 198);
            p_arrival.Name = "p_arrival";
            p_arrival.Size = new Size(182, 33);
            p_arrival.TabIndex = 3;
            // 
            // p_departure
            // 
            p_departure.FormattingEnabled = true;
            p_departure.Items.AddRange(new object[] { "Kankesanthurai", "Ampara", "Batticalo", "Mullaitivu", "Kilinochi", "Colombo", "Mannar", "Kandy", "Nuwara Eliya", "Anuradhapura", "Pollanaruwa" });
            p_departure.Location = new Point(218, 129);
            p_departure.Name = "p_departure";
            p_departure.Size = new Size(182, 33);
            p_departure.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(87, 359);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // p_status
            // 
            p_status.FormattingEnabled = true;
            p_status.Items.AddRange(new object[] { "Paid", "Not Paid" });
            p_status.Location = new Point(229, 315);
            p_status.Name = "p_status";
            p_status.Size = new Size(182, 33);
            p_status.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 128);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 7;
            label2.Text = "Departure:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 197);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 8;
            label3.Text = "Arrival";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 69);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 9;
            label4.Text = "Booking ID:";
            
            // 
            // p_id
            // 
            p_id.Location = new Point(218, 68);
            p_id.Name = "p_id";
            p_id.Size = new Size(150, 31);
            p_id.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 260);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 11;
            label5.Text = "Fare:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 314);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 12;
            label6.Text = "Status:";
            // 
            // view_payment
            // 
            view_payment.BackColor = Color.FromArgb(255, 192, 192);
            view_payment.Location = new Point(440, 196);
            view_payment.Name = "view_payment";
            view_payment.Size = new Size(197, 34);
            view_payment.TabIndex = 13;
            view_payment.Text = "View Payment";
            view_payment.UseVisualStyleBackColor = false;
            view_payment.Click += view_payment_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(427, 359);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(135, 444);
            button3.Name = "button3";
            button3.Size = new Size(130, 78);
            button3.TabIndex = 15;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(p_id);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(view_payment);
            groupBox1.Controls.Add(p_status);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(p_departure);
            groupBox1.Controls.Add(p_arrival);
            groupBox1.Controls.Add(p_fare);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(358, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 412);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // Passenger_paid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1206, 553);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Name = "Passenger_paid";
            Text = "Passenger_paid";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox p_fare;
        private ComboBox p_arrival;
        private ComboBox p_departure;
        private Button button1;
        private ComboBox p_status;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox p_id;
        private Label label5;
        private Label label6;
        private Button view_payment;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
    }
}