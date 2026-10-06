using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace E2
{
    public class DatabaseConnection
    {
        private static readonly string defaultConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TaskDB.mdf;Integrated Security=True;Connect Timeout=30;";

        static DatabaseConnection()
        {
            string dataDir = AppDomain.CurrentDomain.GetData("DataDirectory") as string;
            if (string.IsNullOrEmpty(dataDir) || !File.Exists(Path.Combine(dataDir, "TaskDB.mdf")))
            {
                string assemblyDir = string.Empty;
                try
                {
                    assemblyDir = Path.GetDirectoryName(typeof(DatabaseConnection).Assembly.Location);
                }
                catch
                {
                }

                if (!string.IsNullOrEmpty(assemblyDir) && File.Exists(Path.Combine(assemblyDir, "TaskDB.mdf")))
                {
                    AppDomain.CurrentDomain.SetData("DataDirectory", assemblyDir);
                }
                else if (!string.IsNullOrEmpty(assemblyDir) && File.Exists(Path.Combine(assemblyDir, @"..\..\TaskDB.mdf")))
                {
                    AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(Path.Combine(assemblyDir, @"..\..")));
                }
                else
                {
                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                    if (File.Exists(Path.Combine(baseDir, "TaskDB.mdf")))
                    {
                        AppDomain.CurrentDomain.SetData("DataDirectory", baseDir);
                    }
                    else
                    {
                        string projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\.."));
                        if (File.Exists(Path.Combine(projectDir, "TaskDB.mdf")))
                        {
                            AppDomain.CurrentDomain.SetData("DataDirectory", projectDir);
                        }
                        else
                        {
                            AppDomain.CurrentDomain.SetData("DataDirectory", baseDir);
                        }
                    }
                }
            }
        }

        public static string ConnectionString
        {
            get
            {
                try
                {
                    if (ConfigurationManager.ConnectionStrings["TaskDB"] != null)
                    {
                        return ConfigurationManager.ConnectionStrings["TaskDB"].ConnectionString;
                    }
                    if (ConfigurationManager.ConnectionStrings["TaskDBConnection"] != null)
                    {
                        return ConfigurationManager.ConnectionStrings["TaskDBConnection"].ConnectionString;
                    }
                }
                catch
                {
                }
                return defaultConnectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static SqlConnection ObtenerConexion()
        {
            return GetConnection();
        }

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            return connection;
        }

        public static SqlConnection AbrirConexion()
        {
            return OpenConnection();
        }

        public SqlConnection Conectar()
        {
            return GetConnection();
        }
    }
}
