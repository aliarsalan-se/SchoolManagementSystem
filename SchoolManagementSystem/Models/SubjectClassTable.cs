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
    
    public partial class SubjectClassTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectClassTable()
        {
            this.MarksTables = new HashSet<MarksTable>();
        }
    
        public int SubjectCreationID { get; set; }
        public Nullable<int> ClassDivissionID { get; set; }
        public Nullable<int> SubjectID { get; set; }
    
        public virtual ClassDivisionTable ClassDivisionTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarksTable> MarksTables { get; set; }
        public virtual SubjectTable SubjectTable { get; set; }
    }
}