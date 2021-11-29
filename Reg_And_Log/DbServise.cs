using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_And_Log
{
    class DbServise
    {
        private static string dbName = "Database.db";
        private static string folder = Directory.GetCurrentDirectory();
        public static string dbPath = System.IO.Path.Combine(folder, dbName);

        public static void Add(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbPath))
            {
                connection.CreateTable<User>();
                connection.Insert(user);
            }
        }
        public static User SearchUser(string login,string passwd)
        {
            User user = new User();
            using (SQLiteConnection connection = new SQLiteConnection(dbPath))
            {
                connection.CreateTable<User>();
                user = connection.Table<User>().Where(i => i.Login == login && i.Passwd == passwd).FirstOrDefault();
            }
            return user;
        }

    }
}
