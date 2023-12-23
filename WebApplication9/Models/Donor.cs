using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class Donor
    {
        public int DonorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName  => $"{FirstName} {LastName}";
        public string BloodGroup { get; set; }
    }
}