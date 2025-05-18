namespace VSTracki
{
    partial class Passenger_Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Input));
            p_password = new TextBox();
            p_email = new TextBox();
            p_name = new TextBox();
            p_username = new TextBox();
            add = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Cancel = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // p_password
            // 
            p_password.Location = new Point(283, 239);
            p_password.Margin = new Padding(4);
            p_password.Name = "p_password";
            p_password.Size = new Size(179, 37);
            p_password.TabIndex = 1;
            p_password.UseSystemPasswordChar = true;
            // 
            // p_email
            // 
            p_email.Location = new Point(283, 170);
            p_email.Margin = new Padding(4);
            p_email.Name = "p_email";
            p_email.Size = new Size(359, 37);
            p_email.TabIndex = 3;
            // 
            // p_name
            // 
            p_name.Location = new Point(283, 28);
            p_name.Margin = new Padding(4);
            p_name.Name = "p_name";
            p_name.Size = new Size(179, 37);
            p_name.TabIndex = 4;
            // 
            // p_username
            // 
            p_username.Location = new Point(283, 98);
            p_username.Margin = new Padding(4);
            p_username.Name = "p_username";
            p_username.Size = new Size(179, 37);
            p_username.TabIndex = 5;
            // 
            // add
            // 
            add.Location = new Point(111, 338);
            add.Margin = new Padding(4);
            add.Name = "add";
            add.Size = new Size(134, 41);
            add.TabIndex = 7;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Cancel);
            groupBox1.Controls.Add(p_username);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(p_name);
            groupBox1.Controls.Add(p_email);
            groupBox1.Controls.Add(p_password);
            groupBox1.Location = new Point(355, 84);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(691, 509);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(468, 422);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(194, 41);
            button1.TabIndex = 16;
            button1.Text = "Customer Login";
            button1.UseVisualStyleBackColor = true;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 242);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 15;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 173);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 14;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 13;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 30);
            label2.TabIndex = 12;
            label2.Text = "Passenger Name:";
            // 
            // Cancel
            // 
            Cancel.Location = new Point(342, 338);
            Cancel.Margin = new Padding(4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(134, 41);
            Cancel.TabIndex = 10;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
           
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(553, 25);
            label8.Name = "label8";
            label8.Size = new Size(264, 32);
            label8.TabIndex = 18;
            label8.Text = "Passenger Input Form";
            // 
            // Passenger_Input
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1368, 772);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Passenger_Input";
            Text = "Passenger_Input";
         
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox gender;
        private TextBox p_phone;
        private TextBox p_email;
        private TextBox p_name;
        private TextBox p_id;
        private Button add;
        private GroupBox groupBox1;
        private Button Cancel;
        private Button button2;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox p_password;
        private TextBox p_username;
        private Button button1;
    }
}