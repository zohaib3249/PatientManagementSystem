using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Screen
{
    public partial class ActivationWin : Form
    {

        string hwd;
        string Hwdkey;
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand Querycommand = new SQLiteCommand("", connection);
        public ActivationWin(string _hwd,string _Hwdkry)
        {
            InitializeComponent();
            hwd = _hwd;
            Hwdkey = _Hwdkry;
            hwdID.Text = hwd;
            
           
        }
        
        

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void SQLOpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        public static void SQLCloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(hwdID.Text!="" && key.Text!="")

              {
                if(key.Text== Hwdkey)
                {
                    try
                    {
                        SQLOpenConnection();
                        Querycommand.CommandText = "insert into  user (hwdID,key) values('" + hwd + "','" + key.Text+"')";
                        int i = Querycommand.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Your PC Registerd");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error During Insertion", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Key", "Key Error");
                }
                

            }
            else
            {
                MessageBox.Show("Please Enter Key", "error");
            }


        }

        private void ActivationWin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {
            SQLCloseConnection();
            Application.Exit();
        }
    }
}
