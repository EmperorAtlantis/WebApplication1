using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chloe.Annotations;
using Newtonsoft.Json;

namespace WebApplication1.Models.DataModel2.Entitys
{
    
    public class Users
    {
        
        public long Id { get; set; }

        
        public string UserName { get; set; }

        
        public string Passworld { get; set; }
        

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}