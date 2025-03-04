using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;

namespace mysql_student
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=csstudentinfo;password=");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            viewGridData();
        }

        void viewGridData()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM student", con);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void Clear()
        {
            txtRegNo.Text = "";
            txtStudentName.Text = "";
            txtAddress.Text = "";
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewGridData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Please select an image.");
                    return;
                }

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_array = ms.ToArray();

                string query = "INSERT INTO student (RegNo, Student, Address, Photo) VALUES (@RegNo, @Student, @Address, @photo)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RegNo", int.Parse(txtRegNo.Text));
                cmd.Parameters.AddWithValue("@Student", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@photo", photo_array);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Inserted Successfully");
                viewGridData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_array = ms.ToArray();

                string query = "UPDATE student SET RegNo = @RegNo, Student = @Student, Address = @Address, Photo = @photo WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RegNo", int.Parse(txtRegNo.Text));
                cmd.Parameters.AddWithValue("@Student", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@photo", photo_array);
                cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Updated Successfully");
                viewGridData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                string sql = "DELETE FROM student WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Removed Successfully");
                viewGridData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog find = new OpenFileDialog();

            if (find.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(find.FileName);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtRegNo.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtStudentName.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();

            if (dataGridView1.Rows[rowIndex].Cells[4].Value != DBNull.Value)
            {
                byte[] photo_array = (byte[])dataGridView1.Rows[rowIndex].Cells[4].Value;
                MemoryStream ms = new MemoryStream(photo_array);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }   
        }
    }
}
