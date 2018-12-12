using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModel3.Dao
{
    public class UsersDao : IDao
    {
        
        public string ConStr => ConfigurationManager.ConnectionStrings.ToString();

    }
}