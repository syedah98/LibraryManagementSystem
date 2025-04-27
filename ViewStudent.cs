using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    partial class ViewStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 30;
            label1.Text = "Enrollment No :";
            label1.Click += this.label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(643, 138);
            button1.Name = "button1";
            button1.Size = new Size(214, 49);
            button1.TabIndex = 29;
            button1.Text = "Search Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(393, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 35);
            textBox1.TabIndex = 28;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Beige;
            label7.Font = new Font("Cambria", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(304, 33);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(280, 52);
            label7.TabIndex = 26;
            label7.Text = "View Student";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(908, 404);
            dataGridView1.TabIndex = 31;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1000, 697);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ViewStudent";
            Text = "ViewStudent";
            Load += ViewStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
