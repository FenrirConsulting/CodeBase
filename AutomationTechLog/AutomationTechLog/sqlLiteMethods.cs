/*
    Written by Christopher Olson 
        For CVS Health, Vero Beach DC | 11/30/2020
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutomationTechLog
{
    public class sqlLiteMethods
    {

        private SQLiteConnection conn;

        public sqlLiteMethods()
        {
            //constructor
        }

        ~sqlLiteMethods()
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
                conn = new SQLiteConnection(@"Data Source=|DataDirectory|\LocalDatabase.db;");
                conn.Open();
                return "Connected";
            }

            catch (SQLiteException e)
            {
                conn = null;
                return e.Message;
            }
        }

        public DataTable getTable(string table)
        {

            try
            {
                ConnectToDatabase();

                string strCommand = "SELECT * FROM [" + table + "]";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Disconnect();

                return dt;

            }

            catch (SQLiteException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return null;

            }

        }

        public DataTable getOverviewTable(string table)
        {

            try
            {
                ConnectToDatabase();

                string strCommand = "SELECT TECHLOG.*, sum(TECHLOG_USER.tlu_time) as TTime, count(TECHLOG_USER.tlu_name) as CountField " +
                                    "FROM TECHLOG LEFT JOIN TECHLOG_USER "+
                                    "ON TECHLOG_USER.tl_ref = TECHLOG.tl_ref "+
                                    "GROUP BY TECHLOG.tl_ref";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Disconnect();

                return dt;

            }

            catch (SQLiteException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return null;

            }

        }

        public DataTable getTechUserTable(string table)
        {

            try
            {

                ConnectToDatabase();
                string strCommand = "SELECT * FROM " + table + " WHERE Tech=@Tech";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Tech", "Yes");
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                Disconnect();
                return dt;

            }

            catch (SQLiteException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return null;
            }

        }

        
        public DataTable getSelectedRecord(string table, string referenceID) {

            ConnectToDatabase();

            string strCommand = "SELECT * FROM " + table + " WHERE tl_ref=@ID" ;
            SQLiteCommand cmd = new SQLiteCommand(strCommand);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", referenceID);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Disconnect();
            return dt;
        }

        public int ticketAddRecord(int ticket, string requestor, string email, string category, string created, string modified, string finished, string status, string comments, string request, string closedBy)
        {
            try
            {

                ConnectToDatabase();
                string strCommand = "INSERT INTO Tickets (TicketID,Requestor,Email,Category,Created,Modified,Finished,Status,Comments,Request,ClosedBy) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", ticket);
                cmdUpdate.Parameters.AddWithValue("@val2", requestor);
                cmdUpdate.Parameters.AddWithValue("@val3", email);
                cmdUpdate.Parameters.AddWithValue("@val4", category);
                cmdUpdate.Parameters.AddWithValue("@val5", created);
                cmdUpdate.Parameters.AddWithValue("@val6", modified);
                cmdUpdate.Parameters.AddWithValue("@val7", finished);
                cmdUpdate.Parameters.AddWithValue("@val8", status);
                cmdUpdate.Parameters.AddWithValue("@val9", comments);
                cmdUpdate.Parameters.AddWithValue("@val10", request);
                cmdUpdate.Parameters.AddWithValue("@val11", closedBy);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }
        }


        public int techlogRecordUpdate(int tl_ref, string tl_state, string tl_wotype, string tl_woasset, string tl_wocomplaint, string tl_worootcause, string tl_wocorrection, 
                                        string tl_genuser, string tl_gendate, string tl_moduser, string tl_moddate)
        {

            try
            {


                ConnectToDatabase();
                string strCommand = "Update TECHLOG Set tl_ref=@tl_ref, tl_state=@tl_state, tl_wotype=@tl_wotype, tl_woasset=@tl_woasset, tl_wocomplaint=@tl_wocomplaint, " +
                                    "tl_worootcause=@tl_worootcause, tl_wocorrection=@tl_wocorrection, tl_genuser=@tl_genuser, tl_gendate=@tl_gendate, tl_moduser=@tl_moduser, " +
                                    "tl_moddate=@tl_moddate  WHERE tl_ref=@tl_ref";
                
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tl_ref", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@tl_state", tl_state);
                cmdUpdate.Parameters.AddWithValue("@tl_wotype", tl_wotype);
                cmdUpdate.Parameters.AddWithValue("@tl_woasset", tl_woasset);
                cmdUpdate.Parameters.AddWithValue("@tl_wocomplaint", tl_wocomplaint);
                cmdUpdate.Parameters.AddWithValue("@tl_worootcause", tl_worootcause);
                cmdUpdate.Parameters.AddWithValue("@tl_wocorrection", tl_wocorrection);
                cmdUpdate.Parameters.AddWithValue("@tl_genuser", tl_genuser);
                cmdUpdate.Parameters.AddWithValue("@tl_gendate", tl_gendate);
                cmdUpdate.Parameters.AddWithValue("@tl_moduser", tl_moduser);
                cmdUpdate.Parameters.AddWithValue("@tl_moddate", tl_moddate);

                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }

        }

        public int techlogUserRecordUpdate(int tlu_ref, int tl_ref, string tlu_name, string tlu_time, string tlu_shift, string tlu_date)
        {

            try
            {


                ConnectToDatabase();
                string strCommand = "Update TECHLOG_USER Set tlu_ref=@tlu_ref, tl_ref=@tl_ref, tlu_name=@tlu_name, tlu_time=@tlu_time, tlu_shift=@tlu_shift, tlu_date=@tlu_date WHERE tlu_ref=@tlu_ref";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlu_ref", tlu_ref);
                cmdUpdate.Parameters.AddWithValue("@tl_ref", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@tlu_name", tlu_name);
                cmdUpdate.Parameters.AddWithValue("@tlu_time", tlu_time);
                cmdUpdate.Parameters.AddWithValue("@tlu_shift", tlu_shift);
                cmdUpdate.Parameters.AddWithValue("@tlu_date", tlu_date);

                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }

        }

        public int addTechlogUserRecord(int tl_ref, string tlu_shift, string tlu_time, string tlu_date, string tlu_name)
        {

            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_USER (tl_ref, tlu_name, tlu_time, tlu_shift, tlu_date) VALUES (@val1,@val2,@val3,@val4,@val5)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tlu_name);
                cmdUpdate.Parameters.AddWithValue("@val3", tlu_time);
                cmdUpdate.Parameters.AddWithValue("@val4", tlu_shift);
                cmdUpdate.Parameters.AddWithValue("@val5", tlu_date);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }

        }


        public int userAddRecord(string table, string name, string email, string tech, string employeeID, string employeePassword)
        {

            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO Users (Name,Email,Tech,EmployeeID,Password) VALUES (@val1,@val2,@val3,@val4,@val5)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", name);
                cmdUpdate.Parameters.AddWithValue("@val2", email);
                cmdUpdate.Parameters.AddWithValue("@val3", tech);
                cmdUpdate.Parameters.AddWithValue("@val4", employeeID);
                cmdUpdate.Parameters.AddWithValue("@val5", employeePassword);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }

        }

        public int userTableUpdate(string iD, string table, string name, string email, string tech, string employeeID, string employeePassword)
        {

            try
            {
                ConnectToDatabase();
                string strCommand = "Update " + table + " Set Name=@Name, Email=@Email, Tech=@Tech, EmployeeID=@EmployeeID, Password=@Password  WHERE ID=" + iD;
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@ID", iD);
                cmdUpdate.Parameters.AddWithValue("@Name", name);
                cmdUpdate.Parameters.AddWithValue("@Email", email);
                cmdUpdate.Parameters.AddWithValue("@Tech", tech);
                cmdUpdate.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmdUpdate.Parameters.AddWithValue("@Password", employeePassword);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }

        }

        public int userPasswordUpdate(string iD, string table, string employeeID, string employeePassword)
        {

            try
            {
                ConnectToDatabase();
                string strCommand = "Update " + table + " Set EmployeeID=@EmployeeID, Password=@Password  WHERE ID=" + iD;
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@ID", iD);
                cmdUpdate.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmdUpdate.Parameters.AddWithValue("@Password", employeePassword);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }

        }

        public int deleteRecord(string table, string Id)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "DELETE FROM " + table + " WHERE ID=@Id";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@Id", Id);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }
        }

        public List<String> buildColumnList(List<String> list, string table, string col)
        {

            ConnectToDatabase();

            string query = "SELECT " + col + " FROM " + table;
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = query;


            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }

            Disconnect();
            return list;
        }

    }
}
