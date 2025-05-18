namespace VSTracki
{
    partial class Passenger_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Register));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            name = new TextBox();
            label4 = new Label();
            username = new TextBox();
            label5 = new Label();
            label1 = new Label();
            button2 = new Button();
            email = new TextBox();
            button1 = new Button();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(username);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(199, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(810, 411);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 147);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // name
            // 
            name.Location = new Point(457, 222);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 221);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // username
            // 
            username.Location = new Point(457, 87);
            username.Name = "username";
            username.Size = new Size(150, 31);
            username.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(347, 27);
            label5.Name = "label5";
            label5.Size = new Size(348, 38);
            label5.TabIndex = 10;
            label5.Text = "Passenger Register Portal";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 88);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // button2
            // 
            button2.Location = new Point(495, 346);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            email.Location = new Point(457, 287);
            email.Name = "email";
            email.Size = new Size(150, 31);
            email.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(212, 346);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(457, 157);
            password.Name = "password";
            password.Size = new Size(150, 31);
            password.TabIndex = 8;
            password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 158);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 286);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // Passenger_Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1190, 582);
            Controls.Add(groupBox1);
            Name = "Passenger_Register";
            Text = "Passenger_Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox name;
        private Label label4;
        private TextBox username;
        private Label label5;
        private Label label1;
        private Button button2;
        private TextBox email;
        private Button button1;
        private TextBox password;
        private Label label2;
        private Label label3;
    }
}