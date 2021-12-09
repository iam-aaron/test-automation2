using BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal;
using ExcelDataReader;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using System.Collections;

namespace BSuiteE2ERegressionTest
{
    //Commonly used functions
    public sealed partial class StepDefinitions
    {
        /// <summary>
        /// Load Test Data
        /// </summary>
        public static string LoadTestData()
        {
            gblLog += "\n" + "Performing Test Data Preparation.";
            var testDataPrepLog = string.Empty;
            int index = 0;
            var roles = new List<(string roleName, int roleId)>()
            {
                ("System Admin",9),
                ("Field Technician",4),
                ("Agent Technician",6),
                ("Logistics Admin",47),
                ("Workshop Technician (NEW)",71),
                ("Logistics Technician",36),
                ("State Supply Chain Manager",79),
                ("Service Delivery Manager",64),
                ("Call Desk Manager",1),
                ("Logistics Storeman",24),
            };

            //Create multiple Users with the desired user roles
            foreach(var role in roles)
            {
                if (!gblUsers.ContainsKey(role.roleName))
                {
                    gblUsers.Add(role.roleName, new List<Dictionary<string, object>>());
                }

                for (index = gblTestUserStartIndex; index < gblTestUserEndIndex; index++)
                {
                    var user = CreateUser(userIndex: index, userRoleId: role.roleId);
                    gblUsers[role.roleName].Add(user);
                }
            }
            return testDataPrepLog;
        }

        /// <summary>
        /// Get latest personId from BSuite Hydra MySQL DB
        /// </summary>
        /// <returns></returns>
        private static string GetLatestPersonId()
        {
            var newPersonId = string.Empty;
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, "set @latestPersonId := \"\";"},
                { 2, @"select @latestPersonId:= id from hydra.person order by Id DESC Limit 1;"},
                { 3, @"set @newPersonId = CAST(@latestPersonId AS unsigned) + 1;"},
                { 4, @"SELECT @newPersonId;"},
            };
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                newPersonId = sqlResult["@newPersonId"].ToString();
            }
            return newPersonId;
        }

        /// <summary>
        /// Get latest UserAccountId from BSuite Hydra MySQL DB
        /// </summary>
        /// <returns></returns>
        private static string GetLatestUserAccountId()
        {
            var newUserAccountId = string.Empty;
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, "set @latestUserAccountId := \"\";"},
                { 2, @"select @latestUserAccountId:= id from hydra.useraccount order by Id DESC Limit 1;"},
                { 3, @"set @newUserAccountId = CAST(@latestUserAccountId AS unsigned) + 1;"},
                { 4, @"SELECT @newUserAccountId;"},
            };
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                newUserAccountId = sqlResult["@newUserAccountId"].ToString();
            }
            return newUserAccountId;
        }

        /// <summary>
        /// Check if User already exists in BSuite Hydra MySQL DB
        /// </summary>
        /// <returns></returns>
        private static bool IsUserExists(string userId)
        {
            bool isUserExists = false;
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, $@"select * from hydra.person where firstName='{userId}' and lastName='bsuiteregression';"},
            };
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                isUserExists = true;
            }
            gblLog += $@"\nUser {userId} {((sqlResult.Count > 0) ? "exists" : "does not exist")} in BSuite.";
            return isUserExists;
        }

        /// <summary>
        /// Check if User is Active
        /// </summary>
        /// <returns></returns>
        private static bool IsUserActive(string userId)
        {
            bool isUserActive = false;
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, $@"select active from hydra.person where firstName='{userId}' and lastName='bsuiteregression';"},
            };
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                isUserActive = (bool)sqlResult["active"];
            }
            gblLog += $@"\nUser {userId} is {(isUserActive ? "Active" : "not Active")} in BSuite.";
            return isUserActive;
        }

        /// <summary>
        /// Check if User is OnLine
        /// </summary>
        /// <returns></returns>
        private static bool IsUserOnLine(Dictionary<string, object> userDetails)
        {
            bool isUserOnline = false;
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, $@"SELECT isOnline FROM useraccount WHERE personId = (SELECT id from person where firstName='{userDetails["firstName"]}' and lastName='{userDetails["lastName"]}');"},
            };
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                isUserOnline = (bool)sqlResult["isOnline"];
            }
            gblLog += $@"\nUser {userDetails["firstName"]} is {(isUserOnline ? "Online" : "not Online")} in BSuite.";
            return isUserOnline;
        }

        /// <summary>
        /// Find the index number of the test user with the highest index for a role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        private static int FindHighestIndexOfExistingTestUsersForRole(string role)
        {
            var highestIndexOfExistingTestUsersForRole = 0;
            var userRole = role.ToLower().Replace("+", "").Replace(" ", "").Replace("(", "").Replace(")", "");
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, $@"select firstName from person where firstName like '%test{userRole}%' and lastName='bsuiteregression' order by id desc limit 1;"},
            };
            var firstName = string.Empty;
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                firstName = (string)sqlResult["firstName"];
                highestIndexOfExistingTestUsersForRole = int.Parse(firstName.Substring(firstName.Length-3, 3));
                gblLog += $@"\nUser {sqlResult["firstName"]} is the user with the highest userindex for role {role} in BSuite.";
            }            
            return highestIndexOfExistingTestUsersForRole;
        }

        /// <summary>
        /// Check if User has completed PreStart Checklist
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
        private static bool HasUserCompletedPrestartChecklist(string role, Dictionary<string, object> userDetails)
        {
            bool hasUserCompletedPrestartChecklist = false;
            var sqlCmds = new SortedList()
            {
                { 0, @"use hydra;"},
                { 1, $@"SELECT survey_id FROM surveycomplete where createdById = (select id from useraccount where personId=(select id from person where firstName='{userDetails["firstName"]}' and lastName='{userDetails["lastName"]}')) ORDER By survey_id LIMIT 1;"},
            };
            var sqlResult = ExecuteCmdsOnHydraMySQLDB(sqlCmds);
            if (sqlResult.Count > 0)
            {
                if((role.Equals("Logistics Admin") && (UInt32)sqlResult["survey_id"] == 3) ||
                    (role.Equals("Field Technician") && (UInt32)sqlResult["survey_id"] == 1) ||
                    (role.Equals("Workshop Admin (NEW)") && (UInt32)sqlResult["survey_id"] == 3) ||
                    (role.Equals("Logistics Technician") && (UInt32)sqlResult["survey_id"] == 3) ||
                    (role.Equals("Workshop Technician") && (UInt32)sqlResult["survey_id"] == 3))
                {
                    hasUserCompletedPrestartChecklist = true;
                }
            }
            gblLog += $@"\nUser {userDetails["firstName"]} {(hasUserCompletedPrestartChecklist ? "has" : "has not")} completed PreStart Checklist for the day.";
            return hasUserCompletedPrestartChecklist;
        }

        /// <summary>
        /// Create a test user
        /// </summary>
        /// <param name="userIndex"></param>
        /// <param name="userRoleId"></param>
        /// <returns></returns>
        private static Dictionary<string, object> CreateUser(int userIndex, int userRoleId)
        {
            var userDetails = new Dictionary<string, object>();
            //Check if test user already exists in BSuite
            var userRole = gblRoles[userRoleId].ToLower().Replace("+", "").Replace(" ", "").Replace("(", "").Replace(")", "");
            var userId = $"test{userRole}{userIndex}";
            if (!IsUserExists(userId))
            {
                //If User does not already exist, create a new User with desired role
                var newPersonId = GetLatestPersonId();
                var newUserAccountId = GetLatestUserAccountId();
                var sqlCmds1 = new SortedList()
                {
                    { 0, @"use hydra;"},
                    { 1, $@"insert into address (`addressName`,`addressCode`,`addressContactName`,`line1`,`line2`,`suburb`,`postcode`,`timezone`,`stateId`,`countryId`,`addressType`,`addressGroupId`,`poBox`,`phone`,`fax`,`email`,`externalWorkType`,`latitude`,`longitude`,`zoneId`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{userId}','','','180','Ann St.','Brisbane','4000','Australia/Brisbane','5','2','','1','','','','','','0.000000','0.000000','8418','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 2, $@"insert into person (`firstName`,`lastName`,`phoneNumber`,`mobile`,`fax`,`email`,`title`,`position`,`employeeId`,`addressId`,`companyId`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{userId}','BSuiteRegression','','','','{userId}.BSuiteRegression@tabcorp.com.au','','','','286200','4','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 3, $@"insert into useraccount (`personId`,`techNotifyMethodId`,`bsuiteMobile`,`isOnline`,`userAccountStatusId`,`lastStatusChangeTime`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{newPersonId}','3','','0','2','0001-01-01 00:00:00','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 4, $@"update useraccount set `personId`='{newPersonId}', `techNotifyMethodId`='3', `bsuiteMobile`='', `isOnline`='0', `userAccountStatusId`='2', `lastStatusChangeTime`='0001-01-01 00:00:00', `active`='1', `created`=current_timestamp(), `createdById`='702', `updated`=current_timestamp(), `updatedById`='702' where id='{newUserAccountId}';"},
                    { 5, $@"insert into credential (`authDomainId`,`userAccountId`,`ident`,`password`,`expiry`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('1','{newUserAccountId}','{userId}','487b32506e6a0ad636fbd38f551b9a4aba903130','9999-12-01 23:59:59','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 6, $@"update useraccount set `personId`='{newPersonId}', `techNotifyMethodId`='3', `bsuiteMobile`='', `isOnline`='0', `userAccountStatusId`='2', `lastStatusChangeTime`='0001-01-01 00:00:00', `active`='1', `created`=current_timestamp(), `createdById`='702', `updated`=current_timestamp(), `updatedById`='702' where id='{newUserAccountId}';"},
                    { 7, $@"insert into useraccount_role (userAccountId, roleId, createdById) values ('{newUserAccountId}', '{userRoleId}', '702');"},
                    { 8, $@"insert into userpreference (`userAccountId`,`lu_PreferenceGroupId`,`param`,`value`,`lu_UserPreferenceId`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{newUserAccountId}','1','','132418','70','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 9, $@"insert into userpreference (`userAccountId`,`lu_PreferenceGroupId`,`param`,`value`,`lu_UserPreferenceId`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{newUserAccountId}','1','','{userRoleId}','54','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 10, $@"insert into userpreference (`userAccountId`,`lu_PreferenceGroupId`,`param`,`value`,`lu_UserPreferenceId`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{newUserAccountId}','1','','132418','55','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    { 11, $@"insert into useraccountfilter (`userAccountId`,`roleId`,`filterId`,`filterValue`,`active`,`created`,`createdById`,`updated`,`updatedById`) values ('{newUserAccountId}','{userRoleId}','18','64,895228','1',current_timestamp(),'702',current_timestamp(),'702');"},
                    {12, $@"select * from person where firstName='{userId}' and lastName='bsuiteregression';" }
                };
                userDetails = ExecuteCmdsOnHydraMySQLDB(sqlCmds1);
                gblLog += $@"\r\nNew User#{userIndex} with role {userRole} created in BSuite.";
                gblLog += $@"\r\nUser Id: {userDetails["id"].ToString()}";
            }
            else
            {
                //If User already exists, get user details
                var sqlCmds2 = new SortedList()
                {
                    { 0, @"use hydra;"},
                    {12, $@"select * from person where firstName='{userId}' and lastName='bsuiteregression';" }
                };
                userDetails = ExecuteCmdsOnHydraMySQLDB(sqlCmds2);
                gblLog += $@"\r\nUser#{userIndex} with role {userRole} already exists in BSuite.";
                gblLog += $@"\r\nUser Id: {userDetails["id"].ToString()}";
            }
            return userDetails;
        }

        /// <summary>
        /// Execute MySQL commands on BSuite Hydra MySQL DB
        /// </summary>
        /// <param name="sqlCmds"></param>
        /// <returns></returns>
        private static Dictionary<string, object> ExecuteCmdsOnHydraMySQLDB(SortedList sqlCmds)
        {
            Dictionary<string, object> queryResults = new Dictionary<string, object>();

            string SshHostName = gblConfig.BSuiteHydraDbSshHostName;
            string SshUserName = gblConfig.BSuiteHydraDbSshUserName;
            string SshKeyFile = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\id_rsa_bsuite.pem";
            string Server = gblConfig.BSuiteHydraDbServer;
            uint Port = uint.Parse(gblConfig.BSuiteHydraDbPort);
            string UserID = gblConfig.BSuiteHydraDbUserId;
            string Password = gblConfig.BSuiteHydraDbPassword;
            string DataBase = gblConfig.BSuiteHydraDbName;

            Renci.SshNet.ConnectionInfo cnnInfo;
            using (var stream = new FileStream(SshKeyFile, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                var file = new Renci.SshNet.PrivateKeyFile(stream);
                var authMethod = new Renci.SshNet.PrivateKeyAuthenticationMethod(SshUserName, file);
                cnnInfo = new Renci.SshNet.ConnectionInfo(SshHostName, 22, SshUserName, authMethod);
            }

            using (var client = new Renci.SshNet.SshClient(cnnInfo))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var forwardedPort = new ForwardedPortLocal("127.0.0.1", Server, Port);
                    client.AddForwardedPort(forwardedPort);
                    forwardedPort.Start();

                    string connStr = $"Server = {forwardedPort.BoundHost};Port = {forwardedPort.BoundPort};Database = {DataBase};Uid = {UserID};Pwd = {Password}; Allow User Variables=True;";

                    using (MySqlConnection cnn = new MySqlConnection(connStr))
                    {
                        cnn.Open();
                        for (int i = 0; i < sqlCmds.Count; i++)
                        {
                            var sqlCmd = (string)sqlCmds.GetByIndex(i);
                            MySqlCommand cmd = new MySqlCommand(sqlCmd, cnn);
                            try
                            {
                                MySqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    for (var fieldCounter = 0; fieldCounter < reader.FieldCount; fieldCounter++)
                                    {
                                        //Add the last sqlcmd result to the queryresults collection.
                                        if (i == (sqlCmds.Count - 1))
                                        {
                                            queryResults.Add(reader.GetName(fieldCounter),
                                                reader.GetValue(fieldCounter));
                                        }
                                    }
                                }
                                reader.Close();
                            }
                            catch (Exception e1)
                            {
                                gblLog += "\n" + $"Failed to create Test Users in BSuite. " +
                                    $"Exception: {e1.StackTrace}";
                            }
                            System.Threading.Thread.Sleep(250); //Delay between subsequent SQL commands
                        }
                        cnn.Close();
                    }
                    client.Disconnect();
                }
            }
            return queryResults;
        }

        /// <summary>
        /// Select a User
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static Dictionary<string, object> SelectUser(string role, bool isLoggingInFor1stTime)
        {
            Dictionary<string, object> selectedUser = new Dictionary<string, object>();
            foreach(var user in gblUsers[role])
            {
                var userId = (string)user["firstName"];
                //If User is Active
                if (IsUserActive(userId))
                {
                    //If User is not online 
                    if (!IsUserOnLine(user))
                    {
                        var sasUserCompletedPrestartChecklist = HasUserCompletedPrestartChecklist(role, user);
                        //If User is logging in for the first time in the day and has not yet submitted pre-start checklist for that day
                        if (isLoggingInFor1stTime && !sasUserCompletedPrestartChecklist)
                        {
                            selectedUser = user;
                            break;
                        }
                        else if (!isLoggingInFor1stTime)
                        {
                            selectedUser = user;
                            break;
                        }
                    }
                }
            }

            //If none of the existing test users meet the test criteria,
            //then create new user.
            var lastUserIndex = FindHighestIndexOfExistingTestUsersForRole(role);
            if (selectedUser.Count==0)
            {
                selectedUser = CreateUser(userIndex: (lastUserIndex+1), userRoleId: GetKeyByValue(gblRoles, role));
                gblUsers[role].Add(selectedUser);
            }
            gblCurrentUser.UserName = (string)selectedUser["firstName"];
            gblCurrentUser.Password = "bsuite";
            gblCurrentUser.Role = role;
            return selectedUser;
        }

        /// <summary>
        /// Get Key by Value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="W"></typeparam>
        /// <param name="dict"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static T GetKeyByValue<T, W>(Dictionary<T, W> dict, W val)
        {
            T key = default;
            foreach (KeyValuePair<T, W> pair in dict)
            {
                if (EqualityComparer<W>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }
    }
}
