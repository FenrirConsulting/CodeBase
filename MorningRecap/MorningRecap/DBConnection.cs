using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;


namespace MorningRecap
{
    public class DBConnection
    {

        private SqlCeConnection conn;

        public DBConnection()
        {
            //constructor
        }


        ~DBConnection()
        {
            //destructor
            conn = null;
        }


        public void Disconnect()
        {
            conn.Close();
        }


        public string ConnectToDatabase()
        {
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\localDatabase.sdf");
                conn.Open();
                return "Connected";
            }

            catch (SqlCeException e)
            {
                conn = null;
                return e.Message;
            }
        }

        public static void MessageStop() {

            MessageBox.Show("Stop Here");
        }


        public static void messagePassalong(string[] message) {
 
            string toDisplay = string.Join(Environment.NewLine, message);
            MessageBox.Show(toDisplay);
        }


        public DataTable getTable(string table) {

            try
            {

                string strCommand = "SELECT * FROM [" + table + "]";

                DataTable dt = new DataTable();

                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);

                da.Fill(dt);

                return dt;

            }

            catch (SqlCeException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);

                return null;

            }
        
        }

        public DataTable getRxTable() {

            try
            {

                string strCommand = "SELECT * FROM RxTable";

                DataTable dt = new DataTable();

                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);

                da.Fill(dt);

                return dt;

            }

            catch (SqlCeException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);

                return null;

            }

        }

        public DataTable getDPSTable()
        {

            try
            {

                string strCommand = "SELECT * FROM DPSTable";

                DataTable dt = new DataTable();

                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);

                da.Fill(dt);

                return dt;

            }

            catch (SqlCeException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);

                return null;

            }

        }

        public int tableValueUpdate(string ID, string value, string table) {

            try
            {
                string strCommand = "Update " + table + " Set Value=@Value WHERE ID=" + ID ;
                SqlCeCommand cmdUpdate = new SqlCeCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@ID", ID);
                cmdUpdate.Parameters.AddWithValue("@Value", value);
                return cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return -1;
            }

        }

        public int tableUpdate(string ID, string name, string value, string table)
        {

            try
            {
                string strCommand = "Update " + table + " Set Value=@Value WHERE ID=" + ID;
                SqlCeCommand cmdUpdate = new SqlCeCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@ID", ID);
                cmdUpdate.Parameters.AddWithValue("@Name", name);
                cmdUpdate.Parameters.AddWithValue("@Value", value);
                return cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return -1;
            }

        }



        public List<String> buildValueList (List<String> list, string table){

            string query = "SELECT Value FROM " + table;
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            
                using (SqlCeDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        list.Add(reader.GetString(0));
                    }
                }
            


            return list;
        }

        public List<String> buildNameList(List<String> list, string table)
        {

            string query = "SELECT Name FROM " + table;
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            using (SqlCeDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }



            return list;
        }             

    }
}
