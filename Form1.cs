using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            // Initialize the SqlConnection object
            con = new SqlConnection(@"Data Source=DESKTOP-RNB339I\SQLEXPRESS;Initial Catalog=MAHI;Integrated Security=True;TrustServerCertificate=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters with the Text property of the TextBox controls
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
