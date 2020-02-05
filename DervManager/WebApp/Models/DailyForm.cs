using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class DailyForm
    {
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
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
