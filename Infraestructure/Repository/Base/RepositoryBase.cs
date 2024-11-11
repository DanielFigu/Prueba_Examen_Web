using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Base
{
    public abstract class RepositoryBase
    {
        public OleDbConnection _connection;


        protected RepositoryBase() 
        {
            DBconnection connection = new DBconnection("(local)", "Northwind", "MSOLEDBSQL.1");
            _connection = connection.Open();
        
        }

        public abstract string ProcessRequest();
    }


}
