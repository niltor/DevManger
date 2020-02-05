using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
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
        /// <summary>
        /// 职位
        /// </summary>
        //[MaxLength(100)]
        //public string Position { get; set; }

        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string SimpleHash(string password)
        {
            using (var md5 = MD5.Create())
            {
                var data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
