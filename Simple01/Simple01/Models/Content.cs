using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple01.Models
{
    public class Content
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Contents { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 添加日期
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyTime { get; set; }

    }
}
