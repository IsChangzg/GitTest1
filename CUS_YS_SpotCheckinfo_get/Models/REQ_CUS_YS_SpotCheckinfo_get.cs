using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sMES_Base;
using sMES_Base.Methods;

namespace CUS_YS_SpotCheckinfo_get.Models
{
    /// <summary>
	/// 服務[CUS_product_info_get] Request Conent
    /// <auth>wujn</auth><time>2021/11/24 18:41:11</time>
    /// <description></description>
    /// <list>
    ///     <modify>
    ///         <auth></auth><mantis></mantis><time></time>
    ///         <description></description>
    ///     </modify>
    /// </list>
    /// </summary>
    public class REQ_CUS_YS_SpotCheckinfo_get : BaseRequestContent
    {
        /// <summary>
        /// 查詢條件
        /// </summary>
        public List<CDO_ReportCondition> query_condition { set; get; }
    }
}
