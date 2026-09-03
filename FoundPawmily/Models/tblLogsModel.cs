using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models
{
    public class tblLogsModel
    {
        public int logID { get; set; }
        public string action { get; set; }
        public DateTime accessDateTime { get; set; }
        public int userID { get; set; }
    }
}