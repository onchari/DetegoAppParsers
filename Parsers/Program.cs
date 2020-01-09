using System;

namespace Parsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = SQLiteOperations.FetchMainDatabaseTable();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
            
        }


       
        }
    
}

//https://stackoverflow.com/questions/20256043/is-there-easy-method-to-read-all-tables-from-sqlite-database-to-dataset-object