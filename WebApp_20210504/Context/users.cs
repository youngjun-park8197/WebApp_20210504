using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp_20210504.Models;

namespace WebApp_20210504.Context
{
    public class userinfo : DbContext
    {
        public userinfo() : base(@"Data Source=192.168.0.80;User ID=kosta3;Password=kosta")
        { }

        public DbSet<user> users { get; set; }
    }
}