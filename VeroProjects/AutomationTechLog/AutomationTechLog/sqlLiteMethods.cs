﻿/*
    Written by Christopher Olson
        For CVS Health, Vero Beach DC | 11/30/2020
*/

using System;
using System.Collections.Generic;
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

        public int addLocationsRecord(int tlloc_ref, string tlloc_locid, string tlloc_desc, string tlloc_asgcount)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_LOCATIONS (tlloc_ref, tlloc_locid, tlloc_desc, tlloc_asgcount) VALUES (@val1,@val2,@val3,@val4)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tlloc_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tlloc_locid);
                cmdUpdate.Parameters.AddWithValue("@val3", tlloc_desc);
                cmdUpdate.Parameters.AddWithValue("@val4", tlloc_asgcount);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Location added succesfully.");
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

        public int addTechlogPartsInventoryRecord(int tlinv_ref, string tlinv_partnumber, string tlloc_locid, int tlinv_qty, string tlinv_desc)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_PARTSINVENTORY (tlinv_ref, tlinv_partnumber, tlloc_locid, tlinv_qty, tlinv_desc) VALUES (@val1,@val2,@val3,@val4,@val5)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tlinv_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tlinv_partnumber);
                cmdUpdate.Parameters.AddWithValue("@val3", tlloc_locid);
                cmdUpdate.Parameters.AddWithValue("@val4", tlinv_qty);
                cmdUpdate.Parameters.AddWithValue("@val5", tlinv_desc);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Part added succesfully.");
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

        public int addTechlogPartsRecord(int tlp_ref, int tl_ref, int tlp_qnty, string tlp_partnumber, string tlp_location, string tlp_description)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_PARTS (tlp_ref, tl_ref, tlp_qnty, tlp_partnumber, tlp_location, tlp_description) VALUES (@val1,@val2,@val3,@val4,@val5,@val6)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tlp_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@val3", tlp_qnty);
                cmdUpdate.Parameters.AddWithValue("@val4", tlp_partnumber);
                cmdUpdate.Parameters.AddWithValue("@val5", tlp_location);
                cmdUpdate.Parameters.AddWithValue("@val6", tlp_description);
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

        public int addTechlogRecord(int tl_ref, string tl_state, string tl_wotype, string tl_woasset, string tl_wocomplaint,
                                                string tl_worootcause, string tl_wocorrection, string tl_genuser, string tl_gendate, string tl_moduser, string tl_moddate)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG (tl_ref, tl_state, tl_wotype, tl_woasset, tl_wocomplaint, tl_worootcause, tl_wocorrection, tl_genuser, tl_gendate, tl_moduser, tl_moddate) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11)";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tl_state);
                cmdUpdate.Parameters.AddWithValue("@val3", tl_wotype);
                cmdUpdate.Parameters.AddWithValue("@val4", tl_woasset);
                cmdUpdate.Parameters.AddWithValue("@val5", tl_wocomplaint);
                cmdUpdate.Parameters.AddWithValue("@val6", tl_worootcause);
                cmdUpdate.Parameters.AddWithValue("@val7", tl_wocorrection);
                cmdUpdate.Parameters.AddWithValue("@val8", tl_genuser);
                cmdUpdate.Parameters.AddWithValue("@val9", tl_gendate);
                cmdUpdate.Parameters.AddWithValue("@val10", tl_moduser);
                cmdUpdate.Parameters.AddWithValue("@val11", tl_moddate);
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

        public int addTechlogTechRecord(string tlt_name, string tlt_shift, string tlt_islead, string tlt_isadmin, string tlt_ispartslead, string tlt_isactive, string tlt_pword, string tlt_auname, string tlt_badgeid)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_TECHS (tlt_name, tlt_shift, tlt_islead, tlt_isadmin, tlt_ispartslead, tlt_isactive, tlt_pword, tlt_auname, tlt_badgeid) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tlt_name);
                cmdUpdate.Parameters.AddWithValue("@val2", tlt_shift);
                cmdUpdate.Parameters.AddWithValue("@val3", tlt_islead);
                cmdUpdate.Parameters.AddWithValue("@val4", tlt_isadmin);
                cmdUpdate.Parameters.AddWithValue("@val5", tlt_ispartslead);
                cmdUpdate.Parameters.AddWithValue("@val6", tlt_isactive);
                cmdUpdate.Parameters.AddWithValue("@val7", tlt_pword);
                cmdUpdate.Parameters.AddWithValue("@val8", tlt_auname); 
                cmdUpdate.Parameters.AddWithValue("@val9", tlt_badgeid);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("User added succesfully.");
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

        public int addTechlogCheckoutRecord(int tlc_ref, string tlt_name, string tlt_auname, string tlinv_partnumber, string tlinv_desc, int tlc_qty, string tlc_date)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_CHECKOUT (tlc_ref, tlt_name, tlt_auname, tlinv_partnumber, tlinv_desc, tlc_qty, tlc_date) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tlc_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tlt_name);
                cmdUpdate.Parameters.AddWithValue("@val3", tlt_auname);
                cmdUpdate.Parameters.AddWithValue("@val4", tlinv_partnumber);
                cmdUpdate.Parameters.AddWithValue("@val5", tlinv_desc);
                cmdUpdate.Parameters.AddWithValue("@val6", tlc_qty);
                cmdUpdate.Parameters.AddWithValue("@val7", tlc_date);
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

        public int addTechlogUserRecord(int tlu_ref, int tl_ref, string tlu_shift, string tlu_time, string tlu_date, string tlu_name)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "INSERT INTO TECHLOG_USER (tlu_ref, tl_ref, tlu_name, tlu_time, tlu_shift, tlu_date) VALUES (@val1,@val2,@val3,@val4,@val5,@val6)";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@val1", tlu_ref);
                cmdUpdate.Parameters.AddWithValue("@val2", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@val3", tlu_name);
                cmdUpdate.Parameters.AddWithValue("@val4", tlu_time);
                cmdUpdate.Parameters.AddWithValue("@val5", tlu_shift);
                cmdUpdate.Parameters.AddWithValue("@val6", tlu_date);
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

        public int confirmPartsQuantity(string tlinv_partnumber, int passedQuantity)
        {
            ConnectToDatabase();
            string passQty = passedQuantity.ToString();

            try
            {
                string strCommand = "Update TECHLOG_PARTSINVENTORY Set tlinv_qty=tlinv_qty - @var2 WHERE tlinv_partnumber=@tlinv_partnumber";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlinv_partnumber", tlinv_partnumber);
                cmdUpdate.Parameters.AddWithValue("@var2", passedQuantity);
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

        public int confirmPartsRecord(int tl_ref, string tl_partsconfirmed)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "Update TECHLOG Set tl_partsconfirmed=@tl_partsconfirmed WHERE tl_ref=@tl_ref";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tl_partsconfirmed", tl_partsconfirmed);
                cmdUpdate.Parameters.AddWithValue("@tl_ref", tl_ref);
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

        public int deleteMatchingRecords(string table, string col, string value)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "DELETE FROM " + table + " WHERE " + col + "=@Val";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@Val", value);
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

        public int deleteRecord(string table, string col, int value)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "DELETE FROM " + table + " WHERE " + col + "=@" + col;
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@" + col, value);
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

        public int deleteUserRecord(string table, string col, string value)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "DELETE FROM " + table + " WHERE " + col + "=@" + col;
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@" + col, value);
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

        public void Disconnect()
        {
            conn.Close();
        }
        public DataTable getFilteredPartsGrid(string matchValue)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "SELECT * FROM TECHLOG_PARTSINVENTORY WHERE tlloc_locid=@matchValue";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@matchValue", matchValue);
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

        public DataTable getMatchingRecords(string table, string col, string value)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "SELECT * FROM " + table + " WHERE " + col + "=@Val";
                SQLiteCommand cmd = new SQLiteCommand(strCommand);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Val", value);
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

                string strCommand = "SELECT TECHLOG.*, TECHLOG_USER.tlu_time, sum(TECHLOG_USER.tlu_time) as TTime, count(TECHLOG_USER.tlu_name) as CountField, count(TECHLOG_PARTS.tlp_ref) as PartCount " +
                                    "FROM TECHLOG " +
                                    "LEFT JOIN TECHLOG_USER ON TECHLOG_USER.tl_ref = TECHLOG.tl_ref " +
                                    "LEFT JOIN TECHLOG_PARTS ON TECHLOG_PARTS.tl_ref = TECHLOG.tl_ref " +
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


        public DataTable getPartsReportTable()
        {
            try
            {
                ConnectToDatabase();

                string strCommand = "SELECT TECHLOG.tl_genuser, TECHLOG.tl_gendate, TECHLOG_PARTS.tlp_partnumber, TECHLOG_PARTS.tlp_description, TECHLOG_PARTS.tlp_qnty " +
                                    "FROM TECHLOG " +
                                    "LEFT JOIN TECHLOG_PARTS ON TECHLOG_PARTS.tl_ref = TECHLOG.tl_ref " +
                                    "WHERE TECHLOG_PARTS.tlp_partnumber IS NOT NULL " +
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

        public DataTable getSelectedRecord(string table, string referenceID)
        {
            ConnectToDatabase();

            string strCommand = "SELECT * FROM " + table + " WHERE tl_ref=@ID";
            SQLiteCommand cmd = new SQLiteCommand(strCommand);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", referenceID);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Disconnect();
            return dt;
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
        public int locationRecordUpdate(string tlloc_desc, string tlloc_locid)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "Update TECHLOG_LOCATIONS Set  tlloc_locid=@tlloc_locid, tlloc_desc=@tlloc_desc WHERE tlloc_locid=@tlloc_locid";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlloc_locid", tlloc_locid);
                cmdUpdate.Parameters.AddWithValue("@tlloc_desc", tlloc_desc);

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

        public int primaryKeyHighestValue(string table, string passedKey)
        {
            ConnectToDatabase();
            string strCommand = "Select Max(" + passedKey + ") From " + table;
            SQLiteCommand cmdUpdate = new SQLiteCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = strCommand;
            object val = cmdUpdate.ExecuteScalar();
            int value = int.Parse(val.ToString());
            Disconnect();
            return value;
        }

        public int resetPassword(string tlt_pword, string tlt_auname)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "Update TECHLOG_TECHS Set tlt_pword=@tlt_pword, tlt_auname=@tlt_auname WHERE tlt_auname=@tlt_auname";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlt_pword", tlt_pword);
                cmdUpdate.Parameters.AddWithValue("@tlt_auname", tlt_auname);
                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Password changed succesfully.");
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

        public int techlogModDateUpdate(int tl_ref, string tl_moduser, string tl_moddate)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "Update TECHLOG Set tl_ref=@tl_ref, tl_moduser=@tl_moduser, tl_moddate=@tl_moddate WHERE tl_ref=@tl_ref";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tl_ref", tl_ref);
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

        public int techlogPartsInventoryRecordUpdate(int tlinv_ref, string tlinv_partnumber, string tlloc_locid, int tlinv_qty, string tlinv_desc)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "Update TECHLOG_PARTSINVENTORY Set tlinv_partnumber=@tlinv_partnumber, tlloc_locid=@tlloc_locid, tlinv_qty=@tlinv_qty, tlinv_desc=@tlinv_desc WHERE tlinv_ref=@tlinv_ref";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlinv_ref", tlinv_ref);
                cmdUpdate.Parameters.AddWithValue("@tlinv_partnumber", tlinv_partnumber);
                cmdUpdate.Parameters.AddWithValue("@tlloc_locid", tlloc_locid);
                cmdUpdate.Parameters.AddWithValue("@tlinv_qty", tlinv_qty);
                cmdUpdate.Parameters.AddWithValue("@tlinv_desc", tlinv_desc);

                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Part Updated.");
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

        public int techlogPartsRecordUpdate(int tlp_ref, int tl_ref, int tlp_qnty, string tlp_partnumber, string tlp_location, string tlp_description)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "Update TECHLOG_PARTS Set tlp_ref=@tlp_ref, tl_ref=@tl_ref, tlp_qnty=@tlp_qnty, tlp_partnumber=@tlp_partnumber, tlp_location=@tlp_location, tlp_description=@tlp_description WHERE tlp_ref=@tlp_ref";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlp_ref", tlp_ref);
                cmdUpdate.Parameters.AddWithValue("@tl_ref", tl_ref);
                cmdUpdate.Parameters.AddWithValue("@tlp_qnty", tlp_qnty);
                cmdUpdate.Parameters.AddWithValue("@tlp_partnumber", tlp_partnumber);
                cmdUpdate.Parameters.AddWithValue("@tlp_location", tlp_location);
                cmdUpdate.Parameters.AddWithValue("@tlp_description", tlp_description);

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

        public int techlogTechsRecordUpdate(string tlt_name, string tlt_shift, string tlt_islead, string tlt_isadmin, string tlt_ispartslead, string tlt_isactive, string tlt_auname, string tlt_badgeid)
        {
            try
            {
                ConnectToDatabase();
                string strCommand = "Update TECHLOG_TECHS Set tlt_name=@tlt_name, tlt_shift=@tlt_shift, tlt_islead=@tlt_islead, tlt_isadmin=@tlt_isadmin, tlt_ispartslead=@tlt_ispartslead, " +
                                                              "tlt_isactive=@tlt_isactive, tlt_auname=@tlt_auname, tlt_badgeid=@tlt_badgeid WHERE tlt_auname=@tlt_auname";

                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@tlt_name", tlt_name);
                cmdUpdate.Parameters.AddWithValue("@tlt_shift", tlt_shift);
                cmdUpdate.Parameters.AddWithValue("@tlt_islead", tlt_islead);
                cmdUpdate.Parameters.AddWithValue("@tlt_isadmin", tlt_isadmin);
                cmdUpdate.Parameters.AddWithValue("@tlt_ispartslead", tlt_ispartslead);
                cmdUpdate.Parameters.AddWithValue("@tlt_isactive", tlt_isactive);
                cmdUpdate.Parameters.AddWithValue("@tlt_auname", tlt_auname);
                cmdUpdate.Parameters.AddWithValue("@tlt_badgeid", tlt_badgeid);

                int returnValue = -1;
                returnValue = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("User Updated.");
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

        public int updateLocationCount(string updateValue, string matchingValue)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "Update TECHLOG_LOCATIONS Set tlloc_asgcount=@updateValue WHERE tlloc_locid=@matchingValue";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@updateValue", updateValue);
                cmdUpdate.Parameters.AddWithValue("@matchingValue", matchingValue);
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

        public int updateMatchingLocationRecords(string table, string updateValue, string matchingValue)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "Update TECHLOG_PARTSINVENTORY Set tlloc_locid=@updateValue WHERE tlloc_locid=@matchingValue";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@updateValue", updateValue);
                cmdUpdate.Parameters.AddWithValue("@matchingValue", matchingValue);
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

        public int updateMatchingPartsRecords(string updateValue, string matchingValue)
        {
            ConnectToDatabase();

            try
            {
                string strCommand = "Update TECHLOG_PARTSINVENTORY Set tlloc_locid=@updateValue WHERE tlinv_partnumber=@matchingValue";
                SQLiteCommand cmdUpdate = new SQLiteCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;
                cmdUpdate.Parameters.AddWithValue("@updateValue", updateValue);
                cmdUpdate.Parameters.AddWithValue("@matchingValue", matchingValue);
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
    }
}