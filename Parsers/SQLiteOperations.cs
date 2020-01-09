using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;


namespace Parsers
{
   
    class SQLiteOperations
    {
        public static List<string> FetchMainDatabaseTable()
        {
            var tables = default(List<string>);
            try
            {
                var dbPath = GetDatabasePath();
                var connection = new SQLiteAsyncConnection(dbPath).GetConnection();
                tables = connection.Table<SqliteMaster>().Select(p=> p.Name).ToList();      
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return tables;
        }

        public static string GetDatabasePath()
        {
            var filePath = @"C:\Users\Onchari\source\repos\DetegoAppParsers\Parsers\Data\live#3ajohn.peter.mcms\main.db";
            if (File.Exists(filePath))
            {
                var fileName = Path.GetFileName(filePath);
                return filePath;
            }
            return null;
        }



        public static void FetchRecords()
        {

        }
    }
   
}




//using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
//{
//    using (SQLiteDataReader rdr = cmd.ExecuteReader())
//    {
//        dt.Load(rdr);
//        foreach (DataRow row in dt.Rows)
//        {
//            tables.Add(row.ItemArray[0].ToString());
//        }
//    }
//}
