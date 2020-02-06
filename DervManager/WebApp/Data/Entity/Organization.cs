using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Entity
{
    /// <summary>
    /// 组织结构 
    /// </summary>
    public class Organization : BaseDB
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public Organization Parent { get; set; }
        public List<Organization> Children { get; set; }
    }
}
