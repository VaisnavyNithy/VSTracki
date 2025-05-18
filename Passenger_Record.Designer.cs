namespace VSTracki
{
    partial class Passenger_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Record));
            dataGridView1 = new DataGridView();
          
            button2 = new Button();
            printButton = new Button();
            printDialog1 = new PrintDialog();
            button6 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1223, 374);
            dataGridView1.TabIndex = 1;
            // 
           
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(903, 477);
            button2.Name = "button2";
            button2.Size = new Size(156, 67);
            button2.TabIndex = 5;
            button2.Text = "Edit Passenger";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // printButton
            // 
            printButton.BackColor = Color.FromArgb(255, 128, 128);
            printButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printButton.Location = new Point(1065, 476);
            printButton.Name = "printButton";
            printButton.Size = new Size(133, 68);
            printButton.TabIndex = 9;
            printButton.Text = "Print ";
            printButton.UseVisualStyleBackColor = false;
            printButton.Click += printButton_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 128, 255);
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(1048, -1);
            button6.Name = "button6";
            button6.Size = new Size(200, 67);
            button6.TabIndex = 14;
            button6.Text = "Bookings";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(99, 458);
            button1.Name = "button1";
            button1.Size = new Size(150, 67);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Passenger_Record
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1275, 556);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(printButton);
            Controls.Add(button2);
       
            Controls.Add(dataGridView1);
            Name = "Passenger_Record";
            Text = "Passenger_Record";
            Load += Passenger_Record_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
      
        private Button button2;
        private Button printButton;  // Corrected reference for printButton
        private PrintDialog printDialog1;
        private Button button6;
        private Button button1;
    }
}
