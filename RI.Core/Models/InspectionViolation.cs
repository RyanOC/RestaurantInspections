using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RI.Core.Models
{
    [ExcludeFromCodeCoverage]
    public class InspectionViolation
    {
        [Required]
        public Int32 Id { get; set; }

        [Required]
        public Int32 InspectionId { get; set; }

        [Required]
        public Int32 ViolationId { get; set; }
    }
}