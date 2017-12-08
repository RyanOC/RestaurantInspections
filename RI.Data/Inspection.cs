//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inspection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspection()
        {
            this.InspectionViolation = new HashSet<InspectionViolation>();
        }
    
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int InspectionNumber { get; set; }
        public int VisitNumber { get; set; }
        public string InspectionType { get; set; }
        public string InspectionDisposition { get; set; }
        public System.DateTime InspectionDate { get; set; }
        public int CriticalViolationCountLegacy { get; set; }
        public int NonCriticalViolationCountLegacy { get; set; }
        public int TotalViolations { get; set; }
        public int HighPriorityViolationCount { get; set; }
        public int IntermediatePriorityViolationCount { get; set; }
        public int BasicPriorityViolationCount { get; set; }
        public string InspectionVisitId { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionViolation> InspectionViolation { get; set; }
    }
}
