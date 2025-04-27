namespace Library_Management_System
{
    partial class Dashboard
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(542, 9);
            label1.Name = "label1";
            label1.Size = new Size(743, 65);
            label1.TabIndex = 0;
            label1.Text = "Library Managment System ";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(417, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1050, 698);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(12, 86);
            button1.Name = "button1";
            button1.Size = new Size(385, 70);
            button1.TabIndex = 2;
            button1.Text = "Add Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Beige;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(12, 162);
            button2.Name = "button2";
            button2.Size = new Size(385, 75);
            button2.TabIndex = 3;
            button2.Text = "View Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Beige;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(12, 243);
            button3.Name = "button3";
            button3.Size = new Size(385, 82);
            button3.TabIndex = 4;
            button3.Text = "Add Students";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Beige;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(12, 422);
            button4.Name = "button4";
            button4.Size = new Size(385, 68);
            button4.TabIndex = 5;
            button4.Text = "Issue Book";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Beige;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(12, 496);
            button5.Name = "button5";
            button5.Size = new Size(385, 67);
            button5.TabIndex = 6;
            button5.Text = "Return Book";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Beige;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(12, 331);
            button6.Name = "button6";
            button6.Size = new Size(385, 85);
            button6.TabIndex = 7;
            button6.Text = "View Student";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Beige;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(12, 569);
            button7.Name = "button7";
            button7.Size = new Size(385, 106);
            button7.TabIndex = 8;
            button7.Text = "Issue Book Reports ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Beige;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(12, 681);
            button8.Name = "button8";
            button8.Size = new Size(385, 103);
            button8.TabIndex = 9;
            button8.Text = "Return Book Reports";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1537, 838);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}