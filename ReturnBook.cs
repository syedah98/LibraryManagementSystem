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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RNB339I\SQLEXPRESS;Initial Catalog=MAHI;Integrated Security=True;TrustServerCertificate=True");
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ViewIssueBook", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@Enrollment_no", SqlDbType.NVarChar).Value = textBox1.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
