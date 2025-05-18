namespace VSTracki
{
    partial class Passenger_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Edit));
            label1 = new Label();
            passengername = new TextBox();
            button1 = new Button();
            passenger = new Button();
            label3 = new Label();
            label4 = new Label();
            button6 = new Button();
            p_email = new TextBox();
            p_name = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            password = new TextBox();
            username = new TextBox();
            label5 = new Label();
            label2 = new Label();
            Cancel = new Button();
            passenger_id = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(170, 45);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // passengername
            // 
            passengername.Location = new Point(375, 44);
            passengername.Name = "passengername";
            passengername.Size = new Size(167, 31);
            passengername.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(598, 30);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passenger
            // 
            passenger.BackColor = Color.FromArgb(255, 192, 192);
            passenger.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passenger.Location = new Point(121, 541);
            passenger.Name = "passenger";
            passenger.Size = new Size(216, 114);
            passenger.TabIndex = 3;
            passenger.Text = "Back";
            passenger.UseVisualStyleBackColor = false;
            passenger.Click += passenger_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 226);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 160);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 224, 192);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(128, 433);
            button6.Name = "button6";
            button6.Size = new Size(188, 57);
            button6.TabIndex = 17;
            button6.Text = "Edit Passenger";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // p_email
            // 
            p_email.Location = new Point(238, 226);
            p_email.Name = "p_email";
            p_email.Size = new Size(490, 31);
            p_email.TabIndex = 23;
            // 
            // p_name
            // 
            p_name.Location = new Point(238, 160);
            p_name.Name = "p_name";
            p_name.Size = new Size(185, 31);
            p_name.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(502, 9);
            label10.Name = "label10";
            label10.Size = new Size(412, 45);
            label10.TabIndex = 26;
            label10.Text = "Edit The Passenger Details";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(passenger_id);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(username);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Cancel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passengername);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(p_email);
            groupBox1.Controls.Add(p_name);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(384, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 535);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(128, 106);
            label7.Name = "label7";
            label7.Size = new Size(42, 32);
            label7.TabIndex = 31;
            label7.Text = "ID:";
            // 
            // password
            // 
            password.Location = new Point(238, 363);
            password.Name = "password";
            password.Size = new Size(185, 31);
            password.TabIndex = 30;
            password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Location = new Point(238, 296);
            username.Name = "username";
            username.Size = new Size(185, 31);
            username.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(105, 283);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 28;
            label5.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 372);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 27;
            label2.Text = "Password:";
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(192, 192, 255);
            Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(413, 433);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(188, 57);
            Cancel.TabIndex = 26;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // passenger_id
            // 
            passenger_id.Location = new Point(238, 106);
            passenger_id.Name = "passenger_id";
            passenger_id.Size = new Size(185, 31);
            passenger_id.TabIndex = 32;
            // 
            // Passenger_Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1286, 698);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(passenger);
            Name = "Passenger_Edit";
            Text = "Passenger_Edit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passengername;
        private Button button1;
        private Button passenger;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button6;
        private TextBox p_id;
        private TextBox p_gender;
        private TextBox p_phone;
        private TextBox p_email;
        private TextBox p_name;
        private Label label10;
        private GroupBox groupBox1;
        private Button Cancel;
        private TextBox password;
        private TextBox username;
        private Label label7;
        private TextBox passenger_id;
    }
}