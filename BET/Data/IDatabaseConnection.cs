using System;
using SQLite;
using SQLitePCL;

namespace BET.Data
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
