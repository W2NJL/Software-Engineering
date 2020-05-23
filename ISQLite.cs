using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace radioland4
{

    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
