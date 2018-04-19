using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 记账V._10
{
    public class Person
    {
        /// <summary>
        /// 操作编号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 所做的事情
        /// </summary>
        public string Dothings { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime GetDateTime { get; set; }
        /// <summary>
        /// 所花费的钱
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
    }
}
