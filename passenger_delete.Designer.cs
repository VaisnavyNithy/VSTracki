namespace VSTracki
{
    partial class passenger_delete
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
            button1 = new Button();
            Passengername = new TextBox();
            ID = new Label();
            p_id = new TextBox();
            p_name = new TextBox();
            Delete = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1042, 107);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Passengername
            // 
            Passengername.Location = new Point(811, 107);
            Passengername.Name = "Passengername";
            Passengername.Size = new Size(150, 31);
            Passengername.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(188, 148);
            ID.Name = "ID";
            ID.Size = new Size(0, 25);
            ID.TabIndex = 2;
            // 
            // p_id
            // 
            p_id.Location = new Point(256, 158);
            p_id.Name = "p_id";
            p_id.Size = new Size(150, 31);
            p_id.TabIndex = 3;
            // 
            // p_name
            // 
            p_name.Location = new Point(256, 215);
            p_name.Name = "p_name";
            p_name.Size = new Size(150, 31);
            p_name.TabIndex = 4;
            // 
            // Delete
            // 
            Delete.Location = new Point(726, 377);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(973, 377);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 110);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 7;
            label1.Text = "Type Passenger ID:";
            // 
            // passenger_delete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 610);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(Delete);
            Controls.Add(p_name);
            Controls.Add(p_id);
            Controls.Add(ID);
            Controls.Add(Passengername);
            Controls.Add(button1);
            Name = "passenger_delete";
            Text = "passenger_delete";
            Load += passenger_delete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Passengername;
        private Label ID;
        private TextBox p_id;
        private TextBox p_name;
        private Button Delete;
        private Button button3;
        private Label label1;
    }
}