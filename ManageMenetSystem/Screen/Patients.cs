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
    public partial class Patients : MetroForm
        
    {
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private static DataTable dt, DataSave;
        private static SQLiteDataAdapter adpt;
        public DataGridViewRow SendRow;
        [Obsolete]
        public Patients()
        {
            InitializeComponent();

            get_patient();

        }

        private void get_patient()
        {
            try
            {

                OpenConnection();
                adpt = new SQLiteDataAdapter("select * from patients", connection);
                dt = new DataTable();
                DataSave = new DataTable();
                adpt.Fill(dt);
                adpt.Fill(DataSave);

                list.DataSource = dt;

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

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendRow = list.Rows[e.RowIndex];
            UpdateAddPatients ad = new UpdateAddPatients(SendRow);
           
                        
            ad.BringToFront();

            ad.TopLevel = true;
            this.TopMost = false;
            ad.TopMost = true;
            ad.ShowDialog();
            ad.Close();
            this.TopMost = true;
            get_patient();


        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (SearchBySup.Text == string.Empty)
            {

                list.DataSource = DataSave;
            }
            if (SearchBySup.Text != "")
            {
                BindingSource Bs = new BindingSource() { };
                Bs.DataSource = dt;
                Bs.Filter = "name like '%" + SearchBySup.Text + "%'";

                list.DataSource = Bs;
            }
        }

        
    }
}
