namespace VSTracki
{
    partial class Passenger_Control_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Control_Panel));
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(32, 126);
            button1.Name = "button1";
            button1.Size = new Size(166, 109);
            button1.TabIndex = 0;
            button1.Text = "Insert The Booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(367, 126);
            button2.Name = "button2";
            button2.Size = new Size(149, 109);
            button2.TabIndex = 1;
            button2.Text = "View Your Booking";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(124, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 341);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(479, 54);
            label1.TabIndex = 0;
            label1.Text = "Passenger Control Panel";
            
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(622, 12);
            button3.Name = "button3";
            button3.Size = new Size(166, 73);
            button3.TabIndex = 2;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Passenger_Control_Panel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Name = "Passenger_Control_Panel";
            Text = "Passenger_Control_Panel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label1;
        private Button button3;
    }
}