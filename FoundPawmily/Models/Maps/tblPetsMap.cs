using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models.Maps
{
    public class tblPetsMap : EntityTypeConfiguration<tblPetsModel>
    {
        public tblPetsMap()
        {
            HasKey(i => i.petID);
            ToTable("tbl_pets");
        }
    }
}