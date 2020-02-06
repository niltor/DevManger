using System;

namespace WebApp.Entity
{
    /// <summary>
    /// 基础数据库
    /// </summary>
    public class BaseDB
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set; } = DateTime.Now;
    }
}
