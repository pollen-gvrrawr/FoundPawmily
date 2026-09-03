using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace FoundPawmily.Models
{
    public class tblVolunteersModel
    {
        public int volunteerID { get; set; }
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string emailAdd { get; set; }
        public string phoneNum { get; set; }
        public DateTime birthDate { get; set; }
        public string houseNum { get; set; }
        public string street { get; set; }
        public string brgy { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public int zip { get; set; }
        public string shelter { get; set; }
        public DateTime volunteerDate { get; set; }
        public string timeSlot { get; set; }
        public int isArchived { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}