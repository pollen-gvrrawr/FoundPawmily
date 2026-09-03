using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models.Maps
{
    public class tblAdoptionsMap : EntityTypeConfiguration<tblAdoptionsModel>
    {
        public tblAdoptionsMap()
        {
            HasKey(i => i.adoptionID);
            ToTable("tbl_adoptions");
        }
    }
}