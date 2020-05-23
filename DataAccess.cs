using System;
using System.Collections.Generic;
using System.Text;
using SQLite; 
using Xamarin.Forms;  

namespace radioland4
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            // create the table(s)  
            //dbConn.CreateTable<Radio>();
        }
        public List<Radio>GetAllRadios()
        {
            return dbConn.Query<Radio>("Select * From [Radio]");
        }

        public List<Radio> GetPhillyRadios()
        {
            return dbConn.Query<Radio>("Select * From [Radio] WHERE Market='PHL'");
        }

        public List<Radio> GetBalRadios()
        {
            return dbConn.Query<Radio>("Select * From [Radio] WHERE Market='BAL'");
        }

        public List<Radio> GetNYCRadios()
        {
            return dbConn.Query<Radio>("Select * From [Radio] WHERE Market='NYC'");
        }
        public int SaveRadio(Radio aRadio)
        {
            return dbConn.Insert(aRadio);
        }
        public int DeleteRadio(Radio aRadio)
        {
            return dbConn.Delete(aRadio);
        }
        public int EditRadio(Radio aRadio)
        {
            return dbConn.Update(aRadio);
        }
    }
}
