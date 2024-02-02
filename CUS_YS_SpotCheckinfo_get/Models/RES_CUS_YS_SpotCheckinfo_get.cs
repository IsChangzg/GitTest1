using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sMES_Base;
using CUS_YS_SpotCheckinfo_get.ORM;

namespace CUS_YS_SpotCheckinfo_get.Models
{
    /// <summary>
	/// 服務[CUS_product_info_get] Response Content
    /// <auth>wujn</auth><time>2021/11/24 18:41:11</time>
    /// <description></description>
    /// <list>
    ///     <modify>
    ///         <auth></auth><mantis></mantis><time></time>
    ///         <description></description>
    ///     </modify>
    /// </list>
    /// </summary>
    public class RES_CUS_YS_SpotCheckinfo_get : BaseResponseContent
    {
        public List<ORM_YS_SpotCheckinfo> details;
    }
}
