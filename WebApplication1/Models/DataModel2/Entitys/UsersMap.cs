using Chloe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModel2.Entitys
{
    public class UsersMap : EntityTypeBuilder<Users>
    {
        public UsersMap()
        {
            MapTo("Users");
            Property(u => u.Id).IsAutoIncrement().IsPrimaryKey();
            Property(u => u.UserName).HasSize(20);
            Property(u => u.Passworld).HasSize(50);
        }
    }
}