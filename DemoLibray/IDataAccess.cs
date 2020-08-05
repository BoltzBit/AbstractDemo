using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibray
{
    public interface IDataAccess
    {
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveData(string sql);
    }
}
