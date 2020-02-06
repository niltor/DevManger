using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Entity
{
    public class AppUser : IdentityUser
    {
        public Organization Organization { get; set; }
        public ICollection<ProjectUsers> ProjectUsers { get; set; }
        public ICollection<DailyWork> DailyWorks { get; set; }

        [MaxLength(100)]
        public string Realname { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        [MaxLength(100)]
        public string Position { get; set; }
    }
}
