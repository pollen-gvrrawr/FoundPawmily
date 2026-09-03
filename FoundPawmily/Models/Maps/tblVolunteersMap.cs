using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models.Maps
{
    public class tblVolunteersMap : EntityTypeConfiguration<tblVolunteersModel>
    {
        public tblVolunteersMap()
        {
            HasKey(i => i.volunteerID);
            ToTable("tbl_volunteers");
        }
    }
}