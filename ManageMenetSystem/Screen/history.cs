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
    public partial class history : MetroForm
    {
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private static DataTable dt, DataSave;
        private static SQLiteDataAdapter adpt;
        public history()
        {
            InitializeComponent();
            OpenConnection();

            adpt = new SQLiteDataAdapter("select * from CheckUpView order by ChechUp_ID desc", connection);
            dt = new DataTable();
            DataSave = new DataTable();

            adpt.Fill(dt);
            adpt.Fill(DataSave);
           

            checkups.DataSource = dt;





            CloseConnection();
        }
        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (SearchBySup.Text == string.Empty)
            {

                checkups.DataSource = DataSave;
            }
            if (SearchBySup.Text != "")
            {
                BindingSource Bs = new BindingSource() { };
                Bs.DataSource = dt;
                Bs.Filter = "name like '%" + SearchBySup.Text + "%' or City like '%" + SearchBySup.Text + "%'";

                checkups.DataSource = Bs;
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
