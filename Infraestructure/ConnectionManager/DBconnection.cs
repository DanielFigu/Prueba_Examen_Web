using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class DBconnection
    {
        private OleDbConnection _connection;
        private string _stringConnection;

        public DBconnection(string DataSourse, string DataBase, string Provider)
        {
            _stringConnection = $"Provider={Provider}; Data Sourse={DataSourse}; Initial Catalog={DataBase}; Integrated Security = SSPI; TrustManagerContext Server Certificate=false";
        
        }

        public void CreateConnection() 
        {
            _connection = new OleDbConnection(_stringConnection) ;
        }

        public OleDbConnection Open() 
        {
            if (_connection == null) return null ;

            if (_connection.State == ConnectionState.Open) return _connection ;
            else
            {
                _connection.Open();
                return _connection ;
            }
        
        }

        public void Close() 
        {
            _connection.Close();
        }



    }
}
