using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersProfile.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public UserInfo1 UserInfo { get; set; }
        public IEnumerable<State1> States { get; set; }
        public IEnumerable<Country1> Countries { get; set; }
    }
}