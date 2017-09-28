using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UsersProfile.Models
{
    public class State1
    {
        [Key]
        public string StateID { get; set; }
        public string Name { get; set; }
        public string CountryID { get; set; }
    }
}