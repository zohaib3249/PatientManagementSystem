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
    public partial class PatientHistory : MetroForm
    {
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private static DataTable dt, DataSave;
        private static SQLiteDataAdapter adpt;
        private static string id;

        [Obsolete]
        public PatientHistory(string ids)
        {
            id = ids;
            InitializeComponent();
            get_patients();
        }
        private void get_patients()
        {
            try
            {

                OpenConnection();
                
                adpt = new SQLiteDataAdapter("select * from CheckUp where patientID="+id, connection);
                dt = new DataTable();

                adpt.Fill(dt);
               

                DataSave = new DataTable();

                adpt.Fill(DataSave);
                

                

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
    }
}
