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
    
    public partial class AcedamicYearTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AcedamicYearTable()
        {
            this.MarksTables = new HashSet<MarksTable>();
        }
    
        public int AcedamicYearID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public Nullable<int> AcedamicYear { get; set; }
    
        public virtual SchoolTable SchoolTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarksTable> MarksTables { get; set; }
    }
}
