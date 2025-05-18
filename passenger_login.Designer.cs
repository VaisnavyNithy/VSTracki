namespace VSTracki
{
    partial class passenger_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passenger_login));
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            Username = new TextBox();
            Login = new Button();
            Password = new TextBox();
            button3 = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.InactiveCaption;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(Username);
            groupBox3.Controls.Add(Login);
            groupBox3.Controls.Add(Password);
            groupBox3.Location = new Point(298, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(646, 466);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(472, 379);
            button2.Name = "button2";
            button2.Size = new Size(112, 48);
            button2.TabIndex = 12;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(271, 379);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 143);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(252, 132);
            label4.Name = "label4";
            label4.Size = new Size(315, 38);
            label4.TabIndex = 9;
            label4.Text = "Passenger Login Portal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(227, 54);
            label3.Name = "label3";
            label3.Size = new Size(204, 54);
            label3.TabIndex = 8;
            label3.Text = "VS Tracki ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 209);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 304);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // Username
            // 
            Username.Location = new Point(281, 212);
            Username.Name = "Username";
            Username.Size = new Size(150, 31);
            Username.TabIndex = 3;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(104, 379);
            Login.Name = "Login";
            Login.Size = new Size(112, 48);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Password
            // 
            Password.Location = new Point(281, 304);
            Password.Name = "Password";
            Password.Size = new Size(150, 31);
            Password.TabIndex = 2;
            Password.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Location = new Point(981, 57);
            button3.Name = "button3";
            button3.Size = new Size(125, 108);
            button3.TabIndex = 9;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // passenger_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1294, 645);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Name = "passenger_login";
            Text = "passenger_login";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox Username;
        private Button Login;
        private TextBox Password;
        private Button button3;
    }
}