//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DesignationTable
    {
        public int DesignationID { get; set; }
        public Nullable<int> UserTypeID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public string DesignationName { get; set; }
    
        public virtual SchoolTable SchoolTable { get; set; }
        public virtual UserTypeTable UserTypeTable { get; set; }
    }
}
