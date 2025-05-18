namespace VSTracki
{
    partial class booking_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking_report));
            booking_details = new DataGridView();
            button1 = new Button();
            booking = new PrintDialog();
            payment = new PrintDialog();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)booking_details).BeginInit();
            SuspendLayout();
            // 
            // booking_details
            // 
            booking_details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booking_details.Location = new Point(167, 66);
            booking_details.Name = "booking_details";
            booking_details.RowHeadersWidth = 62;
            booking_details.Size = new Size(1138, 414);
            booking_details.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1019, 486);
            button1.Name = "button1";
            button1.Size = new Size(134, 73);
            button1.TabIndex = 30;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // booking
            // 
            booking.UseEXDialog = true;
            // 
            // payment
            // 
            payment.UseEXDialog = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(426, 486);
            button2.Name = "button2";
            button2.Size = new Size(191, 73);
            button2.TabIndex = 31;
            button2.Text = "View Payment Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(197, 486);
            button3.Name = "button3";
            button3.Size = new Size(134, 73);
            button3.TabIndex = 32;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(513, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 54);
            label1.TabIndex = 33;
            label1.Text = "Booking Details";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(697, 486);
            button4.Name = "button4";
            button4.Size = new Size(191, 73);
            button4.TabIndex = 34;
            button4.Text = "Update Bookings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // booking_report
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1578, 613);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(booking_details);
            Name = "booking_report";
            Text = "booking_report";
            Load += booking_report_Load;
            ((System.ComponentModel.ISupportInitialize)booking_details).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView booking_details;
        private Button button1;
        private PrintDialog booking;
        private PrintDialog payment;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}