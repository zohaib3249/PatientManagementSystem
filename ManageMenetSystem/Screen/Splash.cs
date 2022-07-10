using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using System.Management;
using ManageMenetSystem;

namespace PointOfSale.Screen
{
    public partial class Splash : Form
    {
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd =new SQLiteCommand("", connection);
        private static SQLiteDataReader reader;
        public static  bool Chk { get; set; }
        readonly string hwd;
        readonly string Hwdkey;
        int count = 60;
        public Splash()
        {
            Chk = false;
            InitializeComponent();
            hwd = GetProcessorId();
            //key = Convert.ToBase64String(Encoding.UTF8.GetBytes(hwd));
            Hwdkey = EncodeHwd(hwd);
            InitSetup();
            timer1.Start();
            
            Setup();


        }

        [Obsolete]
        private void Setup()
        {
            if (CheckActivation(hwd, Hwdkey))
            {

                MainWIndow mwin = new MainWIndow();
                mwin.Show();
                this.Close();
                Chk = true;

                return;

            }
            else
            {
                count = 100;
                new Screen.ActivationWin(hwd, Hwdkey).ShowDialog();
                Setup();

            }
        }
        private bool CheckActivation(string hwd, string key)
        {
            SQLOpenConnection();
            cmd.CommandText = "select * from user where hwdID='" + hwd + "' and key='" + key + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    if (reader.GetValue(2).ToString() == key && reader.GetValue(1).ToString()==hwd)
                    {
                        Chk = true;
                        reader.Close();
                        SQLCloseConnection();
                        return true;

                    }
                    else
                    {
                        reader.Close();
                        SQLCloseConnection();
                        return false;
                    }
                }
                reader.Close();
                SQLCloseConnection();
                return false;
            }
            else
            {
                reader.Close();
                SQLCloseConnection();
                return false;
            }

            //Querycommand.ExecuteNonQuery();

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
        public static string EncodeHwd(string serverName)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(serverName + "POSByZohaib"));
        }
        public static String GetProcessorId()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();

                break;
            }
            //System.Guid guid = System.Guid.NewGuid();
            return Id;

        }
        private void InitSetup()
        {
            
            OpenConnection();
            if (!System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Sqlite.db"))
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
        private void OpenConnection()
        {
            if(connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        private void CloseConnection()
        {
            if(connection.State== ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public int sec = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            progressbar.Left += 10;
            
            if (progressbar.Left + progressbar.Width > bunifuPanel1.Width + 70)
            {
                progressbar.Left = 0;
            }
            if (Chk==true && sec>= count)
            {
                this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
             
        }
    }

}
