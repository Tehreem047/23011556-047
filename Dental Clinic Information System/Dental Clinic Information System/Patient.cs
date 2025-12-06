using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Dental_Clinic_Information_System
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            LoadPatients();
        }
        private int selectedPatientId = 0;
        private void LoadPatients()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "SELECT * FROM Patients";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt; // display data
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nam.Text.Trim();
            string gender = gend.Text.Trim();
            string age = ag.Text.Trim();
            string contact = cont.Text.Trim();
            string address = add.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(age) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "INSERT INTO Patients (name, gender, age, number, address) " +
                                   "VALUES (@name, @gender, @age, @number, @address)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@number", contact);
                        cmd.Parameters.AddWithValue("@address", address);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Patient added successfully!");
                            ClearForm();

                            LoadPatients();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            nam.Clear();
            gend.Clear();
            ag.Clear();
            cont.Clear();
            add.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // prevent clicking header row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                nam.Text = row.Cells["name"].Value.ToString();
                gend.Text = row.Cells["gender"].Value.ToString();
                ag.Text = row.Cells["age"].Value.ToString();
                cont.Text = row.Cells["number"].Value.ToString();
                add.Text = row.Cells["address"].Value.ToString();
                selectedPatientId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == 0)
            {
                MessageBox.Show("Select a patient first.");
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Patients SET name=@name, gender=@gender, age=@age, number=@number, address=@address WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", nam.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", gend.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", ag.Text.Trim());
                    cmd.Parameters.AddWithValue("@number", cont.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", add.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedPatientId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Patient updated successfully!");
                        LoadPatients(); // Refresh DataGridView
                        ClearForm();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == 0)
            {
                MessageBox.Show("Select a patient first.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Patients WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedPatientId);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Patient deleted successfully!");
                            LoadPatients();
                            ClearForm();
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = sear.Text.Trim();
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Patients WHERE name LIKE '%' + @search + '%' OR number LIKE '%' + @search + '%'";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@search", search);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            navig nav = new navig();
            nav.Show();
            this.Hide();
        }
    }
}
        
    

