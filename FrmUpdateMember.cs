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

namespace OrtizSql
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }
        string value;
        private ClassRegistrationQuery cqr;
        SqlCommand command;
        SqlDataReader reader;
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            cbProgram.Items.Add("BSIT");
            cbProgram.Items.Add("BSHM");
            cbProgram.Items.Add("BSCS");
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Di ko sure");
            cqr = new ClassRegistrationQuery();
            using (SqlConnection sqlConn = new SqlConnection(cqr.connectionString))
            {
                sqlConn.Open();
                string query = "Select StudentId FROM ClubMembers";
                command = new SqlCommand(query, sqlConn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbStudentNum.Items.Add(reader.GetValue(0));
                }
                reader.Close();
                sqlConn.Close();
            }
            cbStudentNum.SelectedIndex = 0;
        }

        private void cbStudentNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = cbStudentNum.SelectedItem.ToString();

            cqr = new ClassRegistrationQuery();
            using (SqlConnection sqlConn = new SqlConnection(cqr.connectionString))
            {
                sqlConn.Open();
                string query = "Select * FROM ClubMembers WHERE StudentId = '" + value + "'";
                command = new SqlCommand(query, sqlConn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tbLname.Text = "" + reader.GetValue(4);
                    tbFname.Text = "" + reader.GetValue(2);
                    tbMname.Text = "" + reader.GetValue(3);
                    tbAge.Text = "" + reader.GetValue(5);
                    cbGender.Text = "" + reader.GetValue(6);
                    cbProgram.Text = "" + reader.GetValue(7);
                }
                reader.Close();
                sqlConn.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cqr = new ClassRegistrationQuery();
            using (SqlConnection sqlConn = new SqlConnection(cqr.connectionString))
            {
                sqlConn.Open();
                string updateQuery = "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = '" + value + "'";
                command = new SqlCommand(updateQuery, sqlConn);
                command.Parameters.AddWithValue("@FirstName", tbFname.Text);
                command.Parameters.AddWithValue("@MiddleName", tbMname.Text);
                command.Parameters.AddWithValue("@LastName", tbLname.Text);
                command.Parameters.AddWithValue("@Age", tbAge.Text);
                command.Parameters.AddWithValue("@Gender", cbGender.Text);
                command.Parameters.AddWithValue("@Program", cbProgram.Text);
                command.ExecuteNonQuery();
                sqlConn.Close();
            }
           

        }

        private void FrmUpdateMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmClubRegistration fcr = new FrmClubRegistration();
            fcr.RefreshListOfClubMembers();
        }
    }
}
