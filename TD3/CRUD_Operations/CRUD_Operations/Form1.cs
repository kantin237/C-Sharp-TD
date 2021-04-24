using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BILVMID\SQLEXPRESS;Initial Catalog=CRUD_Database;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        public int StudentID;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentsTb", con);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            StudentRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTb VALUES (@Name,@FatherName,@RollNumber,@Address,@Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student is successfully saved in the database ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if(txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Student name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtRollNumber.Clear();
            txtMobile.Clear();
            txtAddress.Clear();

            txtStudentName.Focus();
        }

        private void StudentRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtStudentName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile.Text = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentsTb SET Name = @Name, FatherName = @FatherName, RollNumber = @Roll, Address = @Address, Mobile = @Mobile WHERE StudentId = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@Roll", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student information is updated successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("please select an Student to update his Information ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTb WHERE StudentId = @ID", con);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student is deleted from the system ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("please select an Student to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
