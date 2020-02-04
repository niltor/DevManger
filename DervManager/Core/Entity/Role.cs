using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entity
{
    public class Role : BaseDB
    {
        public ICollection<User> Users { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
