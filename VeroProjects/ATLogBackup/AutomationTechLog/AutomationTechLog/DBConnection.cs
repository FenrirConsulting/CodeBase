﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace ITTicketSystem
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

        public DataTable getTable(string table)
        {

            try
            {
                ConnectToDatabase();

                string strCommand = "SELECT * FROM [" + table + "]";
                SqlCeCommand cmd = new SqlCeCommand(strCommand);
                cmd.Connection = conn;
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Disconnect();

                return dt;

            }

            catch (SqlCeException e)
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
                SqlCeCommand cmd = new SqlCeCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Tech", "Yes");
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                Disconnect();
                return dt;

            }

            catch (SqlCeException e)
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
                SqlCeCommand cmd = new SqlCeCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Status", "Open");

                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

                da.Fill(dt);
                Disconnect();
                return dt;

            }

            catch (SqlCeException e)
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
                SqlCeCommand cmd = new SqlCeCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Status", "Closed");

                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

                da.Fill(dt);

                Disconnect();

                return dt;

            }

            catch (SqlCeException e)
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
                SqlCeCommand cmdUpdate = new SqlCeCommand();
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
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                Disconnect();
                return -1;
            }
        }

        public int ticketTableUpdate(string iD, string table, string modified, string finished, string category, string status, string comments, string closedBy)
        {

            try
            {
                ConnectToDatabase();
                string strCommand = "Update " + table + " Set Modified=@Modified, Finished=@Finished, Category=@Category, Status=@Status, Comments=@Comments, ClosedBy=@ClosedBy  WHERE ID=" + iD;
                SqlCeCommand cmdUpdate = new SqlCeCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@ID", iD);
                cmdUpdate.Parameters.AddWithValue("@Modified", modified);
                cmdUpdate.Parameters.AddWithValue("@Finished", finished);
                cmdUpdate.Parameters.AddWithValue("@Category", category);
                cmdUpdate.Parameters.AddWithValue("@Status", status);
                cmdUpdate.Parameters.AddWithValue("@Comments", comments);
                cmdUpdate.Parameters.AddWithValue("@ClosedBy", closedBy);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SqlCeException e)
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
                SqlCeCommand cmdUpdate = new SqlCeCommand();
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
            catch (SqlCeException e)
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
                SqlCeCommand cmdUpdate = new SqlCeCommand();
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
            catch (SqlCeException e)
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
                SqlCeCommand cmdUpdate = new SqlCeCommand();
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
            catch (SqlCeException e)
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
                SqlCeCommand cmdUpdate = new SqlCeCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@Id", Id);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                Disconnect();
                return returnValue;
            }
            catch (SqlCeException e)
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

            Disconnect();
            return list;
        }

    }
}