using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity
{
    /// <summary>
    /// 项目用户关联
    /// </summary>
    public class ProjectUsers : BaseDB
    {
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
