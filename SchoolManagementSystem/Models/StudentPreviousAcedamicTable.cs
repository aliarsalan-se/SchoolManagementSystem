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
    
    public partial class StudentPreviousAcedamicTable
    {
        public int SPATID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public string PrveiousSchoolName { get; set; }
        public Nullable<int> Percentage { get; set; }
    
        public virtual StudentTable StudentTable { get; set; }
    }
}