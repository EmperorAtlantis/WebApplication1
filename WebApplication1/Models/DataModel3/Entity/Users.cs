using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication1.Models.DataModel3.Dao
{
    public class Users
    {
        
        public long Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}