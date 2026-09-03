using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models.Maps
{
    public class tblLogsMap : EntityTypeConfiguration<tblLogsModel>
    {
        public tblLogsMap()
        {
            HasKey(i => i.logID);
            ToTable("tbl_logs");
        }
    }
}