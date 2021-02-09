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

        public DataTable getOpenTicketsTable(string table)
        {

            try
            {

                ConnectToDatabase();
                DataTable dt = new DataTable();

                string strCommand = "SELECT * FROM " + table + " WHERE Status=@Status";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Status", "Open");

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(dt);
                Disconnect();
                return dt;

            }

            catch (SQLiteException e)
            {

                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);

                return null;
            }

        }

        public DataTable getClosedTicketsTable(string table)
        {

            try
            {
                ConnectToDatabase();

                DataTable dt = new DataTable();

                string strCommand = "SELECT * FROM " + table + " WHERE Status=@Status";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Status", "Closed");

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

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

        public int ticketTableUpdate(string iD, string table, string modified, string request, string finished, string category, string status, string comments, string closedBy)
        {

            try
            {
                ConnectToDatabase();
                string strCommand = "Update " + table + " Set Modified=@Modified, Request=@Request, Finished=@Finished, Category=@Category, Status=@Status, Comments=@Comments, ClosedBy=@ClosedBy  WHERE ID=" + iD;
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@ID", iD);
                cmdUpdate.Parameters.AddWithValue("@Modified", modified);
                cmdUpdate.Parameters.AddWithValue("@Finished", finished);
                cmdUpdate.Parameters.AddWithValue("@Request", request);
                cmdUpdate.Parameters.AddWithValue("@Category", category);
                cmdUpdate.Parameters.AddWithValue("@Status", status);
                cmdUpdate.Parameters.AddWithValue("@Comments", comments);
                cmdUpdate.Parameters.AddWithValue("@ClosedBy", closedBy);
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
