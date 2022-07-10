using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManageMenetSystem.Screen
{
    public partial class CheckUp : MetroForm
    {
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private static DataTable dt, DataSave;
        private static SQLiteDataAdapter adpt;
        private string patientID = "-1";
        Dictionary<string,string> data =
                      new Dictionary<string, string>();

        [Obsolete]
        public CheckUp()
        {

            InitializeComponent();
            get_patients();
        }
        private void get_patients()
        {
            try
            {

                OpenConnection();

                adpt = new SQLiteDataAdapter("select * from patients order by id desc", connection);
                dt = new DataTable();

                adpt.Fill(dt);


                DataSave = new DataTable();

                adpt.Fill(DataSave);
                data.Clear();
                patients.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    patients.Items.Add(row["name"]+"_"+row["id"].ToString());

                    data.Add(row["name"] + "_" + row["id"].ToString(), row["id"].ToString());

                }

                CloseConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        

        

       

        

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            if (note.Text != "" && bunifuTextBox1.Text != "" && status.Text != "")
            {

                OpenConnection();
                if (note.Text == "")
                {
                    note.Text = "NA";
                }
                try
                {
                    if (data.ContainsKey(patients.Text))
                    {
                        patientID = data[patients.Text];
                        string q = "insert into CheckUp(patientID,price,PaymentStatus,Description)  values(" + patientID + ",'" + bunifuTextBox1.Text + "','" + status.Text + "','" + note.Text + "')";


                        cmd.CommandText = q;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Patients added in Database");

                            this.TopMost = true;
                            get_history();
                        }
                        catch (Exception ax)
                        {
                            MessageBox.Show(ax.ToString());
                        }


                        
                    }
                    else
                    {
                        MessageBox.Show("Patient Not exist in Database");
                        this.TopMost = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error During Fatching Patient from Database");
                    this.TopMost = true;
                }
                //string q= "insert into Patients(Name,City,phone,note)  values(33,ccc,ccc,ccc)";

            }
            else
            {
                MessageBox.Show("Name,City and Phone Number are required!");
                this.TopMost = true;

            }
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {
            QAddPatients ad = new QAddPatients();
            ad.BringToFront();

            ad.TopLevel = true;
            this.TopMost = false;
            ad.TopMost = true;
            ad.ShowDialog();
            ad.Close();
            this.TopMost = true;

            get_patients();
        }

       
        private void get_history()
        {
            if (data.ContainsKey(patients.Text))
            {
                string id = data[patients.Text];
                try
                {

                    OpenConnection();

                    adpt = new SQLiteDataAdapter("select * from CheckUpView where PatientID=" + id, connection);
                    dt = new DataTable();

                    adpt.Fill(dt);
                    dt.Columns.Remove("PatientID");
                    dt.Columns.Remove("name");
                    dt.Columns.Remove("Phone Number");
                    dt.Columns.Remove("ChechUp_ID");

                    patient_history.DataSource = dt;





                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (patients.Text == "")
                {
                    MessageBox.Show("Select Patient first");

                }
                else
                {
                    MessageBox.Show("Patient Not found in Databse");

                }


            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled == char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void patients_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            get_history();
        }

        private void bunifuButton23_Click_1(object sender, EventArgs e)
        {
            patients.Text = "";

            note.Text = "";
            price.Text = "";
        }

       
        
    }
}
