using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entity
{
    /// <summary>
    /// 日报
    /// </summary>
    public class DailyWork : BaseDB
    {
        public User User { get; set; }
        public Project Project { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        [MaxLength(4000)]
        public string Content { get; set; }
        /// <summary>
        /// 问题及风险
        /// </summary>
        [MaxLength(2000)]
        public string Risk { get; set; }
        /// <summary>
        /// 完成度
        /// </summary>
        public int Complete { get; set; }

    }
}
