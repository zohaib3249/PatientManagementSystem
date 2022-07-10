using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace ManageMenetSystem.Screen
{
     
    public partial class QAddPatients : MetroForm
    {
        double width = SystemParameters.PrimaryScreenWidth;
        double height = SystemParameters.PrimaryScreenHeight;
        private static readonly SQLiteConnection connection = new SQLiteConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        public QAddPatients()
        {
            
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if(name.Text!="" && city.Text!="" && phone.Text!="")
            {
                
                OpenConnection();
                if (note.Text=="")
                {
                    note.Text = "NA";
                }
                //string q= "insert into Patients(Name,City,phone,note)  values(33,ccc,ccc,ccc)";
                string q= "insert into Patients(Name,City,phone,note)  values('" + name.Text + "','" + city.Text + "','" + phone.Text + "','" + note.Text + "')";
                
               
                cmd.CommandText = q;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch {

                }

               
                MessageBox.Show("Patients added in Database");
                this.Close();
            }
            else
            {
                MessageBox.Show("Name,City and Phone Number are required!");
                

            }
           
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
