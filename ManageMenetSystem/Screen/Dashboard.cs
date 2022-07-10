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
    public partial class Dashboard : MetroForm
    {
            
        private static readonly SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static readonly SQLiteCommand cmd = new SQLiteCommand("", connection);
        private static DataTable dt, DataSave;
        private static SQLiteDataAdapter adpt;
        private static SQLiteDataReader reader;
        public Dashboard()
        {
            InitializeComponent();
            getDashboardData();
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
        private void getDashboardData()
        {
            OpenConnection();
            string getPricetoday = @"select ifnull(sum(price),0) from  CheckUp where date(Date)=CURRENT_DATE";
            string getcheckupToday = @"select ifnull(count(id),0) from  CheckUp where date(Date)=CURRENT_DATE";
            string getPriceoverall = @"select ifnull(sum(price),0) from  CheckUp";
            string getcheckupoverall = @"select ifnull(count(id),0) from  CheckUp";
            cmd.CommandText = getcheckupToday;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    todaycheckups.Text=reader.GetValue(0).ToString();
                }
            }
            else
            {
                todaycheckups.Text = "No Checkups Exist in database";
            }
            reader.Close();
            cmd.CommandText = getPricetoday;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    todayincome.Text = "$"+reader.GetValue(0).ToString();
                }
            }
            else
            {
                todaycheckups.Text = "0";
            }
            reader.Close();

            cmd.CommandText = getcheckupoverall;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    overallcheckups.Text =  reader.GetValue(0).ToString();
                }
            }
            else
            {
                todaycheckups.Text = "0";
            }
            reader.Close();

            cmd.CommandText = getPriceoverall;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    overallincome.Text = "$"+reader.GetValue(0).ToString();
                }
            }
            else
            {
                todaycheckups.Text = "$0";
            }
            reader.Close();
            CloseConnection();
        }

    }
}
