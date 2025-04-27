using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RNB339I\SQLEXPRESS;Initial Catalog=MAHI;Integrated Security=True;TrustServerCertificate=True");
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Enrollment_Number", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox5.Text;
                cmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = textBox6.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Details Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }

        }
    }
}
