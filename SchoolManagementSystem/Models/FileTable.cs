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
    
    public partial class FileTable
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public Nullable<int> UserID { get; set; }
        public string UploadedOn { get; set; }
    
        public virtual UserCreationTable UserCreationTable { get; set; }
    }
}
