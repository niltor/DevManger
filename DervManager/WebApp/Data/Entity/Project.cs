using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Entity
{
    /// <summary>
    /// 项目
    /// </summary>
    public class Project : BaseDB
    {
        public ICollection<ProjectUsers> ProjectUsers { get; set; }
        public ICollection<DailyWork> DailyWorks { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
