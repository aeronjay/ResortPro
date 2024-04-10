using System;
using System.IO;


namespace ResortPro
{
    internal static class dbOp
    {
        public static string ConnectionString
        {
            get
            {
                string databasePath = @"..\..\db\ResortProDB.mdb";

                string startupPath = AppDomain.CurrentDomain.BaseDirectory;
                string fullPath = Path.GetFullPath(Path.Combine(startupPath, databasePath));

                string connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={fullPath};Jet OLEDB:Database Password=LesterLoveEulen2024;";

                return connectionString;
            }
        }
        
    }
}
