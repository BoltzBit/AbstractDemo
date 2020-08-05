using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibray
{
    public class SqlDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output =  base.LoadConnectionString(name);

            output += "(from SQL Server)";

            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}
