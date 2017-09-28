using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UsersProfile.Models
{
    public class UserContext :DbContext
    {
        public UserContext() : base("name=UsersString")
        {

        }
        public DbSet<UserInfo1> UserInfoes { get; set; }
        public DbSet<Country1> Countries { get; set; }
        public DbSet<State1> States { get; set; }

        public System.Data.Entity.DbSet<UsersProfile.Models.UserViewModel> UserViewModels { get; set; }
    }
}