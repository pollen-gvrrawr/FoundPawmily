using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models
{
    public class tblPetsModel
    {
        public int petID { get; set; }
        public string name { get; set; }
        public string petType { get; set; }
        public DateTime birthDate { get; set; }
        public string gender { get; set; }
        public string breed { get; set; }
        public string size { get; set; }
        public string location { get; set; }
        public string shortDesc { get; set; }
        public int isSpayedNeutered { get; set; }
        public int isVaccinated { get; set; }
        public int isDewormed { get; set; }
        public string imagePath { get; set; }
        public int isArchived { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}