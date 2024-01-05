# C#連接postgreSQL模組化

* * *
#### 連接所需驗證:
Host=Hostname;  Localhost / 主機名稱  
Username=postgres;  預設postgres / 層級人員  
Password=PasswordName;  密碼  
Database=DatabaseName;  資料庫名稱  

#### 連線:
ConnNpgModel.ConnectToDB

#### 關閉連線:
ConnNpgModel.CloseConnection

* * *

#### CODE:
```
﻿using Npgsql;
using System.Data;

namespace test.Models
{
    public class ConnNpgModel
    {
        string cs = "Host=Hostname;Username=postgres;Password=PasswordName;Database=DatabaseName";
        NpgsqlConnection con;

        public ConnNpgModel()
        {
            con = new NpgsqlConnection(cs);
        }

        public void ConnectToDB()
        {
            try
            {
                con.Open();
                Console.WriteLine("Connected to PostgreSQL database!");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
```
