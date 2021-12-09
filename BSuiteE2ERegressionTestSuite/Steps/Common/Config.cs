using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BSuiteE2ERegressionTest
{
    /// <summary>
    /// Defines the configuration of a test environment (say TST/SIT/UAT).
    /// This class is instantiated by the class Environment
    /// The test environment configuration is recorded in Config.json
    /// </summary>
    public class Config
    {
        public string TestEnvName = string.Empty;
        public bool IsSelected = false;
        public string BSuiteURL = string.Empty;
        public string BSuiteHydraDbServer = string.Empty;
        public string BSuiteHydraDbName = string.Empty;
        public string BSuiteHydraDbPort = string.Empty;
        public string BSuiteHydraDbSshHostName = string.Empty;
        public string BSuiteHydraDbSshUserName = string.Empty;
        public string BSuiteHydraDbUserId = string.Empty;
        public string BSuiteHydraDbPassword = string.Empty;
        public Dictionary<string, (string UserName, string UserPassword)> Users = new Dictionary<string, (string UserName, string UserPassword)>();

        public void LoadConfig()
        {
            Newtonsoft.Json.Linq.JObject selectedEnvironment = null;
            using (StreamReader configFile = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\Drivers\TestDataConfig.json"))
            {
                string jsonfile = configFile.ReadToEnd();
                var environments = (Newtonsoft.Json.Linq.JArray)Newtonsoft.Json.Linq.JObject.Parse(jsonfile)["Environments"];
                var users = (Newtonsoft.Json.Linq.JArray)Newtonsoft.Json.Linq.JObject.Parse(jsonfile)["Users"];
                foreach (Newtonsoft.Json.Linq.JObject env in environments.Children<Newtonsoft.Json.Linq.JObject>())
                {
                    foreach (Newtonsoft.Json.Linq.JProperty envProperty in env.Properties())
                    {
                        if (envProperty.Name.Equals("IsSelected") && envProperty.Value.ToString().Equals("Yes", System.StringComparison.InvariantCultureIgnoreCase))
                        {
                            selectedEnvironment = env;
                            break;
                        }
                    }
                    if (selectedEnvironment != null) break;
                }

                if (selectedEnvironment != null)
                {
                    foreach (Newtonsoft.Json.Linq.JProperty envProperty in selectedEnvironment.Properties())
                    {
                        switch (envProperty.Name)
                        {
                            case "TestEnvName":
                                this.TestEnvName = envProperty.Value.ToString();
                                break;
                            case "BSuiteURL":
                                this.BSuiteURL = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbServer":
                                this.BSuiteHydraDbServer = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbName":
                                this.BSuiteHydraDbName = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbPort":
                                this.BSuiteHydraDbPort = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbSshHostName":
                                this.BSuiteHydraDbSshHostName = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbSshUserName":
                                this.BSuiteHydraDbSshUserName = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbUserId":
                                this.BSuiteHydraDbUserId = envProperty.Value.ToString();
                                break;
                            case "BSuiteHydraDbPassword":
                                this.BSuiteHydraDbPassword = envProperty.Value.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }

                //foreach (Newtonsoft.Json.Linq.JObject user in users.Children<Newtonsoft.Json.Linq.JObject>())
                //{
                //    var role = "";
                //    var userName = "";
                //    var userPassword = "";
                //    foreach (Newtonsoft.Json.Linq.JProperty userProperty in user.Properties())
                //    {
                //        switch (userProperty.Name)
                //        {
                //            case "Role":
                //                role = userProperty.Value.ToString();
                //                break;
                //            case "UserName":
                //                userName = userProperty.Value.ToString();
                //                break;
                //            case "Password":
                //                userPassword = userProperty.Value.ToString();
                //                break;
                //            default:
                //                break;
                //        }
                //    }
                //    Users.Add(role, new ValueTuple<string, string>(userName, userPassword));
                //}
            }
        }      
    }
}
