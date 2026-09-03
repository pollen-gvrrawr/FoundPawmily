using FoundPawmily.Models.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models.Context
{
    public class FoundPawmilyContext : DbContext
    {
        static FoundPawmilyContext()
        {
            Database.SetInitializer<FoundPawmilyContext>(null);
        }

        public FoundPawmilyContext() : base("Name=foundpawmily_db")
        {
        }

        public virtual DbSet<tblAdoptionsModel> tbl_adoptions { get; set; }
        public virtual DbSet<tblLogsModel> tbl_logs { get; set; }
        public virtual DbSet<tblPetsModel> tbl_pets { get; set; }
        public virtual DbSet<tblUsersModel> tbl_users { get; set; }
        public virtual DbSet<tblVolunteersModel> tbl_volunteers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new tblAdoptionsMap());
            modelBuilder.Configurations.Add(new tblLogsMap());
            modelBuilder.Configurations.Add(new tblPetsMap());
            modelBuilder.Configurations.Add(new tblUsersMap());
            modelBuilder.Configurations.Add(new tblVolunteersMap());
        }
    }
}