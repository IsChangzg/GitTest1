using sMES_Base.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sMES_Base;
using CUS_YS_SpotCheckinfo_get.Models;

namespace CUS_YS_SpotCheckinfo_get
{
    /// <summary>
	/// 服務[CUS_product_info_get]
    /// <auth>wujn</auth><time>2021/11/24 18:41:11</time>
    /// <description>称重标准维护</description>
    /// <list>
    ///     <modify>
    ///         <auth></auth><mantis></mantis><time></time>
    ///         <description></description>
    ///     </modify>
    /// </list>
    /// </summary>
    public class CUS_YS_SpotCheckinfo_get : BaseService
    {
        public CUS_YS_SpotCheckinfo_get(ServiceInfo _ServiceInfo) : base(_ServiceInfo)
        {
        }

        public override ServiceResponse ExecuteImplement(ServiceRequest ServiceRequest, ServiceResponse ServiceResponse)
        {
            REQ_CUS_YS_SpotCheckinfo_get _content = ServiceRequest.GetContent<REQ_CUS_YS_SpotCheckinfo_get>();
            //取出Utilitiy
            CUS_YS_SpotCheckinfo_get_utility utility = GetUtilities<CUS_YS_SpotCheckinfo_get_utility>();

            ServiceResponse.Content = new RES_CUS_YS_SpotCheckinfo_get();
            ServiceResponse.Content.details = utility.YS_SpotCheckinfo_get(_content);
            return ServiceResponse;
        }
    }
}
