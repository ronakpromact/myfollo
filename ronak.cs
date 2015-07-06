using myfollow.Models;
using System.Data.Entity;
using System.Data.Entity.Modelconfiguration.Convention;


namespace myfollow.DAL
{


public class ronak : DBcontext
{
	public Class ronak() : base("ronak")
	{}
    public DBset<user> users{get;set;}
    public DBset<enduser> endusers{get;set;}
    public DBset<productowner> productowners{get;set;}
    public DBset<address> address{get;set;}
    
	 protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
     
        }
}
}
