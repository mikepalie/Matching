using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
       

        public int Age { get; set; }

        public string Salary { get; set; }

        public string Sex { get; set; }
        public List<AppUser> MyFriends { get; set; }
        public List<AppUser> UsersWhoLikeMe { get; set; }

    }
}
