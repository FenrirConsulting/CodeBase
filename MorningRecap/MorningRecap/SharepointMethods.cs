using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.SharePoint.Client;
using System.Security;
using System.Net;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.Online.SharePoint.TenantManagement;
using System.Data.SqlServerCe;
using SP = Microsoft.SharePoint.Client;

namespace MorningRecap
{
    class SharepointMethods
    {

        const string sharepointUrl = "https://aetnao365.sharepoint.com/sites/VeroITCodebase";

        public static void CreateList(string user, string pass, string title)
        {


            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }



            using (var context = new ClientContext(sharepointUrl))
            {

                context.Credentials = new SharePointOnlineCredentials(username, securePassword);
                Web web = context.Web;

                ListCreationInformation listCreationInfo = new ListCreationInformation();
                listCreationInfo.Title = title;
                listCreationInfo.TemplateType = (int)ListTemplateType.GenericList;
                List oList = web.Lists.Add(listCreationInfo);

                context.ExecuteQuery();


            }

        }

        public static void CreateFields(string user, string pass, string title) 
        
        {

            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

           
            using (var context = new ClientContext(sharepointUrl)){


                context.Credentials = new SharePointOnlineCredentials(username, securePassword);
                Web web = context.Web;
                List list = web.Lists.GetByTitle(title);
                string idColumn = "<Field DisplayName='ID' Type='Text' />";
                string nameColumn = "<Field DisplayName='Name' Type='Text' />";
                string valuyColumn = "<Field DisplayName='Value' Type='Text' />";
                list.Fields.AddFieldAsXml(idColumn, true, AddFieldOptions.DefaultValue);
                list.Fields.AddFieldAsXml(nameColumn, true, AddFieldOptions.DefaultValue);
                list.Fields.AddFieldAsXml(valuyColumn, true, AddFieldOptions.DefaultValue);
                context.ExecuteQuery(); 
            
            }

        }


        public static void databaseCreateList(string user, string pass, string title, DataTable dt) {

            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

             

            using (var context = new ClientContext(sharepointUrl))
            {

                context.Credentials = new SharePointOnlineCredentials(username, securePassword);
                Web web = context.Web;
                context.Load(web);
                context.ExecuteQuery();
                


                List newList = web.Lists.GetByTitle(title);
                foreach (DataRow dr in dt.Rows) {

                    ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
                    ListItem newItem = newList.AddItem(itemCreateInfo);
                    newItem["Title"] = dr["ID"];
                    newItem["ID0"] = dr["ID"];
                    newItem["Name"] = dr["Name"];
                    newItem["Value"] = dr["Value"];
                    newItem.Update();
                    context.Load(newItem);
                    context.ExecuteQuery();
                
                }


                context.Load(newList);

            }
        
        }


        public static bool credentialCheck(string user, string pass)
        {

            bool check = false;

            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            using (var context = new ClientContext(sharepointUrl))
            {

                try
                {
                    context.Credentials = new SharePointOnlineCredentials(username, securePassword);
                    Web web = context.Web;
                    context.Load(web);
                    context.ExecuteQuery();
                    check = true;
                }
                catch (System.Net.WebException ex)
                {
                    if (ex.Message == "The remote server returned an error: (404) Not Found.")
                    {
                        check = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Login, Please Re-Enter Sharepoint Credentials");
                }
            }


            return check;

        }


        public static void updateList(string user, string pass, string title, DataTable dt)
        {

            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }



            using (var context = new ClientContext(sharepointUrl))
            {

                context.Credentials = new SharePointOnlineCredentials(username, securePassword);
                Web web = context.Web;
                context.Load(web);
                context.ExecuteQuery();

                List list = context.Web.Lists.GetByTitle(title);
                CamlQuery camlQuery = new CamlQuery();
                camlQuery.ViewXml = "<View><RowLimit>100</RowLimit></View>";
        
                
                ListItemCollection items = list.GetItems(camlQuery);
                context.Load(items);    
                context.ExecuteQuery();



                foreach (ListItem item in items)
                {


                    foreach (DataRow dr in dt.Rows) { 
                    
                        if(item["ID"] == dr["ID"]){
                        
                            item["Name"] = dr["Name"];
                            item["Value"] = dr["Value"];
                            item.Update();
                            context.Load(item);

                        }
                    
                    }

                }

                context.ExecuteQuery();

            }

        }


        public static void getInternalNames(string user, string pass) {

            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }




            using (var context = new ClientContext(sharepointUrl))
            {

                context.Credentials = new SharePointOnlineCredentials(username, securePassword);

            }
        
        }

        

        public static void DeleteList(string user, string pass, string title) {

            string username = user;
            string password = pass;

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            using (var context = new ClientContext(sharepointUrl))
            {

                DBConnection.MessageStop();
                context.Credentials = new SharePointOnlineCredentials(username, securePassword);
                Web web = context.Web;

                List oList = web.Lists.GetByTitle(title);

                oList.DeleteObject();

                context.ExecuteQuery();


            }
        
        }


    }
}
