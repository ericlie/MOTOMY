//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotoMy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Role
    {
        public int UserRoleId { get; set; }
        public string UserRoleCode { get; set; }
        public string UserRoleName { get; set; }
        public Nullable<int> CreationDate { get; set; }
        public Nullable<short> CreationTime { get; set; }
        public string CreationUser { get; set; }
        public Nullable<int> ModifyDate { get; set; }
        public Nullable<short> ModifyTime { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<int> DeleteDate { get; set; }
        public Nullable<short> DeleteTime { get; set; }
        public string DeleteUser { get; set; }
        public Nullable<short> RecordStatus { get; set; }
    }
}
