using myfollow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace myfollow.DAL
{
    public class myfollowcontext : DbContext
    {
        public myfollowcontext():base("myfollowcontext")
        { }
        public DbSet<user> Users { get; set; }
        public DbSet<enduser> Endusers { get; set; }
        public DbSet<productowner> Productowners { get; set; }
        public DbSet<address> addresss
        {
            get;
            set;
        }
        public DbSet<update> updates { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        } 
    }
}