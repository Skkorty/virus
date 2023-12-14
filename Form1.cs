using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtizSql
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        private ClassRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember fum = new FrmUpdateMember();
            fum.ShowDialog();
        }

        long StudentID;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ID = RegistrtionID();
            Age = Convert.ToInt32(tbAge.Text);
            FirstName = tbFname.Text;
            MiddleName = tbMname.Text;
            LastName = tbLname.Text;
            Gender = cbGender.Text;
            Program = cbProgram.Text;
            StudentID = Convert.ToInt64(tbStudentNum.Text);
            clubRegistrationQuery = new ClassRegistrationQuery();
            clubRegistrationQuery.RegisterStudent(ID, StudentID,FirstName, MiddleName, LastName, Age, Gender, Program);
            RefreshListOfClubMembers();
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            cbProgram.Items.Add("BSIT");
            cbProgram.Items.Add("BSHM");
            cbProgram.Items.Add("BSCS");
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Di ko sure");
            RefreshListOfClubMembers();
        }

        public void RefreshListOfClubMembers() 
        {
            try 
            {
                ClassRegistrationQuery crq = new ClassRegistrationQuery();
                crq.DisplayList();
                dataGridView1.DataSource = crq.bindingSource;
            }
           catch(Exception ex) 
            {
                Console.WriteLine("Error po kuya");
            }
        }
        public int RegistrtionID()
        {
            count++;
            return count;
        }

    }
}
