using sMES_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sMES_Base.service;
using CUS_YS_SpotCheckinfo_get.Models;
using CUS_YS_SpotCheckinfo_get.ORM;
using sMES_Base.Models;
using sMES_Base.Methods.Providers;

namespace CUS_YS_SpotCheckinfo_get
{
    /// <summary>
	/// 元件[CUS_product_info_get]
    /// <auth>wujn</auth><time>2021/11/24 18:41:11</time>
    /// <description></description>
    /// <list>
    ///     <modify>
    ///         <auth></auth><mantis></mantis><time></time>
    ///         <description></description>
    ///     </modify>
    /// </list>
    /// </summary>
    public class CUS_YS_SpotCheckinfo_get_utility : BaseUtility
    {
        public CUS_YS_SpotCheckinfo_get_utility(ref BaseService CurrentService) : base(ref CurrentService)
        {
        }

        public List<ORM_YS_SpotCheckinfo> YS_SpotCheckinfo_get(REQ_CUS_YS_SpotCheckinfo_get content)
        {
            String _condition_sql = " ";
            Dictionary<String, Object> _parameters = new Dictionary<string, object>();
            StringBuilder sbSQL = new StringBuilder();
            List<ORM_YS_SpotCheckinfo> _Info = new List<ORM_YS_SpotCheckinfo>();
            sbSQL.Clear();
            sbSQL.Append(" SELECT C.C_PicName,A.QCLISTSERIAL,A.EQUIPMENTNO,EQ.EQUIPMENTNAME,LI.QCLISTNAME,C.QCITEM,B.InspectionMethod,B.InspectionStandards, ");
            sbSQL.Append(" case when C.QCRESULT = '1' then 'NG'	when C.QCRESULT = '0' then 'OK'	end as QCRESULT,C.INPUTVALUE,USR.USERNAME,A.CREATEDATE ");
            sbSQL.Append(" FROM TblWIPEQPQCListLog A WITH(nolock) LEFT JOIN TBLUSRUSERBASIS USR WITH(nolock) ON USR.USERNO = A.CREATOR ");
            sbSQL.Append(" LEFT JOIN TBLEQPEQUIPMENTBASIS EQ WITH(nolock) ON EQ.EQUIPMENTNO = A.EQUIPMENTNO ");
            sbSQL.Append(" LEFT JOIN TBLEQPQCLISTBASIS LI WITH(nolock) ON LI.QCLISTNO = A.QCLISTNO ");
            sbSQL.Append(" LEFT JOIN tblWIPEQPQCListDetail C WITH(nolock) ON A.QCLISTSERIAL = C.QCLISTSERIAL ");
            sbSQL.Append(" left join tblEQPQCLISTDETAIL B WITH(nolock) on C.QCITEM = B.QCITEM  ");
            sbSQL.Append(" WHERE A.QCLISTNO LIKE 'YS%' ");


            if (content.query_condition != null && content.query_condition.Count > 0)
            {
                CDO_ReportConditionResult _result = ReportProvider.GenerateCondtion(content.query_condition, (column_name, query_mode, group_conditions) => {
                    String _condition_str = String.Empty;
                    return _condition_str;
                });
                _condition_sql = _result.sql;
                _parameters = _result.parameters;
            }
            string HouZhui = ".png";
            List<ORM_YS_SpotCheckinfo> _lists = CurrentService.GetDao().Query<ORM_YS_SpotCheckinfo>(sbSQL.ToString() + _condition_sql, _parameters).OrderByDescending(_=>_.CREATEDATE).ToList();
            foreach (ORM_YS_SpotCheckinfo item in _lists) {
                if (!string.IsNullOrEmpty(item.C_PicName))

                    item.C_PicName = FileAccessProvider.GetServerFilePath(FileType.Others, "InspectPic/" + item.C_PicName+ HouZhui);
            }
            return _lists;
        }
    }
}
