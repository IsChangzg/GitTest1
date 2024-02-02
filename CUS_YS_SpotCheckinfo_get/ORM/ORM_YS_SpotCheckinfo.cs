using sMES_Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUS_YS_SpotCheckinfo_get.ORM
{
    //當有設定此功能時就能使用ORM 的insert / update / delete
    //[ORM(Name = "TABLE_NAME")]
    public class ORM_YS_SpotCheckinfo : BaseORM
    {
        /// <summary>图片</summary>
        [ORMAttribute(Name = "C_PicName")]
        public string C_PicName { get; set; }

        /// <summary>QCLISTSERIAL</summary>
        [ORMAttribute(Name = "QCLISTSERIAL")]
        public string QCLISTSERIAL { get; set; }

        /// <summary>设备编号</summary>
        [ORMAttribute(Name = "EQUIPMENTNO")]
        public string EQUIPMENTNO { get; set; }

        /// <summary>设备名称</summary>
        [ORMAttribute(Name = "EQUIPMENTNAME")]
        public string EQUIPMENTNAME { get; set; }

        /// <summary>点检名称</summary>
        [ORMAttribute(Name = "QCLISTNAME")]
        public string QCLISTNAME { get; set; } = "0";

        /// <summary>点检项目</summary>
        [ORMAttribute(Name = "QCITEM")]
        public string QCITEM { get; set; }

        /// <summary>检查方法</summary>
        [ORMAttribute(Name = "InspectionMethod")]
        public string InspectionMethod { get; set; }

        /// <summary>安全注意事项</summary>
        [ORMAttribute(Name = "InspectionStandards")]
        public string InspectionStandards { get; set; }

        /// <summary>点检结果</summary>
        [ORMAttribute(Name = "QCRESULT")]
        public string QCRESULT { get; set; }

        /// <summary>输入值</summary>
        [ORMAttribute(Name = "INPUTVALUE")]
        public string INPUTVALUE { get; set; }

        /// <summary>点检人员</summary>
        [ORMAttribute(Name = "USERNAME")]
        public string USERNAME { get; set; }

        /// <summary>点检时间</summary>
        [ORMAttribute(Name = "CREATEDATE")]
        public string CREATEDATE { get; set; }

        //备注
        [ORMAttribute(Name = "C_Remark")]
        public string C_Remark { get; set; }
    }
}
