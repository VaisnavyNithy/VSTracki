namespace VSTracki
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            passenger = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // passenger
            // 
            passenger.BackColor = Color.FromArgb(255, 224, 192);
            passenger.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passenger.Location = new Point(64, 116);
            passenger.Name = "passenger";
            passenger.Size = new Size(126, 132);
            passenger.TabIndex = 0;
            passenger.Text = "Manage Passenger";
            passenger.UseVisualStyleBackColor = false;
            passenger.Click += passenger_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 27);
            label1.Name = "label1";
            label1.Size = new Size(369, 48);
            label1.TabIndex = 1;
            label1.Text = "Admin Control Panel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passenger);
            groupBox1.Location = new Point(385, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 427);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(233, 272);
            button3.Name = "button3";
            button3.Size = new Size(126, 132);
            button3.TabIndex = 6;
            button3.Text = "Fuel Expense Teacker";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(426, 116);
            button2.Name = "button2";
            button2.Size = new Size(126, 132);
            button2.TabIndex = 5;
            button2.Text = "Manage Buses";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(250, 116);
            button1.Name = "button1";
            button1.Size = new Size(126, 132);
            button1.TabIndex = 4;
            button1.Text = "Manage Driver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1050, 46);
            button4.Name = "button4";
            button4.Size = new Size(126, 132);
            button4.TabIndex = 7;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1302, 666);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Name = "Home";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button passenger;
        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}