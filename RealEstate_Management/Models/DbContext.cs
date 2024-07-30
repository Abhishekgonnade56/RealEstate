using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealEstate_Management.Models
{
    public class Contextdb : DbContext

    {
        public DbSet<Signup> Signups { get; set; }
        public Contextdb() : base("name=DBrealestateEntities")
        {
        }
        public DbSet<BannerMaster> Banners { get; set; }
        public DbSet<PerfectPropertyMaster> PerfectProperties { get; set; }
        public DbSet<PropertyAgentMaster> PropertyAgents { get; set; }
        public DbSet<PropertyClientMaster> PropertyClients { get; set; }
        public DbSet<PropertyTypeMaster> PropertyTypes { get; set; }
        public DbSet<PropertyListingMaster> PropertyLists { get; set; }
    }
}