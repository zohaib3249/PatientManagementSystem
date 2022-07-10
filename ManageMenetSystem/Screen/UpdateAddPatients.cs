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
     
    public partial class UpdateAddPatients : MetroForm
    {
        double width = SystemParameters.PrimaryScreenWidth;
        double height = SystemParameters.PrimaryScreenHeight;
        private static readonly SQLiteConnection connection = new SQLiteConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private string id;
        public UpdateAddPatients(DataGridViewRow row)
        {
            id = row.Cells[0].Value.ToString();
            InitializeComponent();
            name.Text= row.Cells[1].Value.ToString();
            city.Text= row.Cells[2].Value.ToString();
            phone.Text= row.Cells[3].Value.ToString();
            note.Text= row.Cells[4].Value.ToString();

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
                string q= "update  Patients set name='" + name.Text + "',city='" + city.Text + "',phone='" + phone.Text + "',note='" + note.Text + "' where id="+id+"";
                
               
                cmd.CommandText = q;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patients updated in Database");
                    this.Close();
                }
                catch (Exception ax){
                    MessageBox.Show(ax.ToString());
                }

               
              
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
