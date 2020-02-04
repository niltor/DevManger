using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entity
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : BaseDB
    {
        public Role Role { get; set; }
        public Organization Organization { get; set; }
        public ICollection<ProjectUsers> ProjectUsers { get; set; }
        public ICollection<DailyWork> DailyWorks { get; set; }
        [MaxLength(100)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Realname { get; set; }
    }
}
