using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using ManageMenetSystem.Screen;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

using System.Management;

namespace ManageMenetSystem


{
    public partial class MainWIndow :MetroForm
    {
        static double width = SystemParameters.PrimaryScreenWidth;
        static double height = SystemParameters.PrimaryScreenHeight;
        public static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        public static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private new Form ActiveForm;
        
        private static DataTable dt, dataSave;
        private static SQLiteDataAdapter adpt;

        [Obsolete]
        public MainWIndow()
        {
            this.Height = (int)(height * 2);
            this.Width = (int)(width * 2);
            InitializeComponent();
            InitSetup();
            get_recentData();





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
        private void InitSetup()
        {

            OpenConnection();
            if (!System.IO.File.Exists(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Sqlite.db"))
            {



                System.Data.SQLite.SQLiteConnection.CreateFile("Sqlite.db");


            }

            try
            {
                //datetime default current_timestamp\







                OpenConnection();
                string Patients = @"CREATE TABLE IF NOT EXISTS Patients (ID   INTEGER NOT NULL UNIQUE,Name  TEXT,city  TEXT,phone   TEXT,Note TEXT,date DATETIME DEFAULT (DATETIME(CURRENT_TIMESTAMP, 'LOCALTIME')),PRIMARY KEY(ID AUTOINCREMENT)); ";
                string setting = @"CREATE TABLE IF NOT EXISTS setting (ID   INTEGER NOT NULL UNIQUE,Name  TEXT,theam  TEXT,hwd TEXT,key TEXT,PRIMARY KEY(ID AUTOINCREMENT)); ";

                string CheckUp = @"CREATE TABLE IF NOT EXISTS CheckUp (ID   INTEGER NOT NULL UNIQUE,patientID INTEGER,price INTEGER,PaymentStatus TEXT,Description TEXT,date DATETIME DEFAULT (DATETIME(CURRENT_TIMESTAMP, 'LOCALTIME')),PRIMARY KEY(ID AUTOINCREMENT),foreign key(patientID) REFERENCES Patients(ID)); ";
                string CheckUpView = @"CREATE  VIEW CheckUpView as select c.id as ChechUp_ID,p.id as PatientID,p.name as Name,p.phone as 'Phone Number',c.price,c.PaymentStatus,p.city as City,c.Description as Description,c.date as Date from Patients as p,CheckUp as c  where c.patientID=p.id";
                string userTable = @"CREATE TABLE IF NOT EXISTS user (id INTEGER NOT NULL UNIQUE,hwdID TEXT,key TEXT,date Date DEFAULT CURRENT_DATE,PRIMARY KEY(id  AUTOINCREMENT))";



                cmd.CommandText = Patients;
                cmd.ExecuteNonQuery();
                cmd.CommandText = CheckUp;
                cmd.ExecuteNonQuery();
                cmd.CommandText = setting;
                cmd.ExecuteNonQuery();
                cmd.CommandText = userTable;
                cmd.ExecuteNonQuery();


                try
                {
                    cmd.CommandText = CheckUpView;
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    //
                    //MessageBox.Show(ex.Message);
                }


            }
            catch
            {
                //
                //MessageBox.Show(ex.Message);
            }



            CloseConnection();



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenChildFrame(new Screen.AddPatients());
            
        }

        private void metroPanel5_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildFrame(new Screen.AddPatients());
           
        }

        [Obsolete]
        private void pictureBox4_Click(object sender, EventArgs e)

        {
            OpenChildFrame(new Screen.Patients());
           
        }

        [Obsolete]
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildFrame(new Screen.CheckUp());
            

        }
        private void get_recentData()
        {
            OpenConnection();
           
            //string setting = @"select * from setting where id=1";
            string CheckUpView = @"select * from  CheckUpView where date(Date)=CURRENT_DATE";

            adpt = new SQLiteDataAdapter(CheckUpView, connection);
            dt = new DataTable();
            dataSave= new DataTable();
            
            adpt.Fill(dt);
            adpt.Fill(dataSave);
            dt.Columns.Remove("PatientID");
            dataSave.Columns.Remove("PatientID");

            recentData.DataSource = dt;
            /*
             
             reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    settings.name = reader.GetValue(1).ToString();
                    settings.theam = reader.GetValue(2).ToString();
                    settings.hwd = reader.GetValue(3).ToString();
                    settings.key = reader.GetValue(4).ToString();
                    //PhoneNo.Text = reader.GetValue(2).ToString();
                }
            }
            else
            {
                settings.name = "Managemenet System";
                settings.theam = "Light";
                settings.hwd = "";
                settings.key = "";
            }
            reader.Close();
 
             
             
             */
            CloseConnection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenChildFrame(new Screen.history());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to close Management system", "Close Software", MessageBoxButtons.YesNo,
       MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();

            }
            
        }

        private void OpenChildFrame(Form ChidFram)
        {

            if (ActiveForm != null)
            {
                ActiveForm.Close();

            }
            this.TopMost = false;
            ActiveForm = ChidFram;
            ChidFram.TopMost = true;
            ChidFram.BringToFront();
            ActiveForm = ChidFram;
            ChidFram.TopLevel = true;
            ChidFram.ShowDialog();
            this.TopMost = true;
            get_recentData();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildFrame(new Screen.Dashboard());
        }

        private void SearchBySup_TextChanged(object sender, EventArgs e)
        {
            if (SearchBySup.Text == string.Empty)
            {

                recentData.DataSource = dataSave;
            }
            if (SearchBySup.Text != "")
            {
                BindingSource Bs = new BindingSource() { };
                Bs.DataSource = dt;
                Bs.Filter = "name like '%" + SearchBySup.Text + "%'";

                recentData.DataSource = Bs;
            }
        }
    }

}
