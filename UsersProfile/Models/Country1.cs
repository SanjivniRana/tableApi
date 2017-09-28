using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UsersProfile.Models
{
    public class Country1
    {
        [Key]
        public string CountryID { get; set; }
        public string Name { get; set; }
    }
}