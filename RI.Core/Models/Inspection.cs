using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RI.Core.Models
{
    [ExcludeFromCodeCoverage]
    public class Inspection
    {
        [Required]
        public Int32 Id { get; set; }

        [Required]
        public Int32 RestaurantId { get; set; }

        [Required]
        public Int32 InspectionNumber { get; set; }

        [Required]
        public Int32 VisitNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public String InspectionType { get; set; }

        [Required]
        [MaxLength(100)]
        public String InspectionDisposition { get; set; }

        [Required]
        public String InspectionDate { get; set; }

        [Required]
        [MaxLength(10)]
        public Int32 CriticalViolationCountLegacy { get; set; }

        [Required]
        [MaxLength(10)]
        public Int32 NonCriticalViolationCountLegacy { get; set; }

        [Required]
        [MaxLength(10)]
        public Int32 TotalViolations { get; set; }

        [Required]
        [MaxLength(10)]
        public Int32 HighPriorityViolationCount { get; set; }

        [Required]
        [MaxLength(10)]
        public Int32 IntermediatePriorityViolationCount { get; set; }

        [Required]
        [MaxLength(10)]
        public Int32 BasicPriorityViolationCount { get; set; }

        [Required]
        [MaxLength(10)]
        public String InspectionVisitId { get; set; }
    }
}