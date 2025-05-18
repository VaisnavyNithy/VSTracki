namespace VSTracki
{
    partial class View_Passenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Passenger));
            button1 = new Button();
            helpProvider1 = new HelpProvider();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            Booking_details = new DataGridView();
            passenger_id = new TextBox();
            passenger_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Booking_details).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(801, 78);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Booking_details);
            groupBox1.Controls.Add(passenger_id);
            groupBox1.Controls.Add(passenger_name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(243, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1091, 520);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(6, 435);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(430, 18);
            label3.Name = "label3";
            label3.Size = new Size(211, 38);
            label3.TabIndex = 6;
            label3.Text = "View Bookings";
            // 
            // Booking_details
            // 
            Booking_details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Booking_details.Location = new Point(160, 128);
            Booking_details.Name = "Booking_details";
            Booking_details.RowHeadersWidth = 62;
            Booking_details.Size = new Size(771, 341);
            Booking_details.TabIndex = 5;
            // 
            // passenger_id
            // 
            passenger_id.Location = new Point(160, 74);
            passenger_id.Name = "passenger_id";
            passenger_id.Size = new Size(150, 31);
            passenger_id.TabIndex = 4;
            // 
            // passenger_name
            // 
            passenger_name.Location = new Point(560, 80);
            passenger_name.Name = "passenger_name";
            passenger_name.Size = new Size(150, 31);
            passenger_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 77);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "Passenger_ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 80);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "Passenger_Name:";
            // 
            // View_Passenger
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1524, 589);
            Controls.Add(groupBox1);
            Name = "View_Passenger";
            Text = "View_Passenger";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Booking_details).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private HelpProvider helpProvider1;
        private GroupBox groupBox1;
        private TextBox passenger_id;
        private TextBox passenger_name;
        private Label label2;
        private Label label1;
        private DataGridView Booking_details;
        private Label label3;
        private Button button2;
    }
}