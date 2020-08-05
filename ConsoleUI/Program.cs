using DemoLibray;
using System.Collections.Generic;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> connection = new List<DataAccess>
            {
                new SqliteDataAccess(),
                new SqlDataAccess(),
            };

            foreach (var db in connection)
            {
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine(db.LoadConnectionString("demo"));
            }

            Console.ReadLine();
        }
    }
}
