using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UsersProfile.Models
{
    public class UserInfo1
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"^[a-zA-Z]+", ErrorMessage = "Please Use letters only")]
        public string Name { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd / MMM / yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
    }
}