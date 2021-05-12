using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCAuthentication.DAL
{
    public class AUTContext:DbContext
    {
        public AUTContext() : base("AUTVeritabani")
        {

        }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //tabloların sonuna gelen s takısını silmek için
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}