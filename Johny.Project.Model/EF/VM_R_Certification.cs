//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Johny.Project.Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class VM_R_Certification
    {
        public int ID { get; set; }
        public Nullable<int> ResourceID { get; set; }
        public string TypeCode { get; set; }
        public string SerialNum { get; set; }
        public string Name { get; set; }
        public string CeritificationUnit { get; set; }
        public Nullable<System.DateTime> CeritificationDate { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public string NextValidationContent { get; set; }
        public string ValidationUnit { get; set; }
        public Nullable<System.DateTime> ValidationDate { get; set; }
        public Nullable<System.DateTime> NextValidationDate { get; set; }
        public string Remark { get; set; }
        public Nullable<int> AttachmentID { get; set; }
        public Nullable<int> Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
    }
}
