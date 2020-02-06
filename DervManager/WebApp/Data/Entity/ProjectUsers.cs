using System;

namespace WebApp.Entity
{
    /// <summary>
    /// 项目用户关联
    /// </summary>
    public class ProjectUsers : BaseDB
    {
        public AppUser User { get; set; }
        public Project Project { get; set; }
    }
}
