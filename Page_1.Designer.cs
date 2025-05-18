namespace VSTracki
{
    partial class Page_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_1));
            gg = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            gg.SuspendLayout();
            SuspendLayout();
            // 
            // gg
            // 
            gg.BackColor = SystemColors.ScrollBar;
            gg.Controls.Add(button1);
            gg.Controls.Add(button2);
            gg.Controls.Add(label2);
            gg.Controls.Add(label1);
            gg.Location = new Point(242, 79);
            gg.Name = "gg";
            gg.Size = new Size(737, 549);
            gg.TabIndex = 0;
            gg.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(77, 240);
            button1.Name = "button1";
            button1.Size = new Size(212, 152);
            button1.TabIndex = 4;
            button1.Text = "Passenger Booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(419, 240);
            button2.Name = "button2";
            button2.Size = new Size(212, 152);
            button2.TabIndex = 3;
            button2.Text = "Admin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 138);
            label2.Name = "label2";
            label2.Size = new Size(300, 48);
            label2.TabIndex = 1;
            label2.Text = "Select Your Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(126, 48);
            label1.Name = "label1";
            label1.Size = new Size(471, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome To VS Tracki!!!";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(-5, -3);
            button3.Name = "button3";
            button3.Size = new Size(250, 211);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // Page_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 752);
            Controls.Add(button3);
            Controls.Add(gg);
            Name = "Page_1";
            Text = "Welcome Page";
            gg.ResumeLayout(false);
            gg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gg;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button1;
        private Button button3;
    }
}