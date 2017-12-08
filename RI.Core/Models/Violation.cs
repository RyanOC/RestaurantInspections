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
    public class Violation
    {
        [Required]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(200)]
        public String Desc { get; set; }

        [Required]
        public Int32 SourceIndex { get; set; }

        [Required]
        public Boolean IsRiskFactor { get; set; }

        [Required]
        public Boolean IsPrimaryConcern { get; set; }
    }
}