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
    public class Restaurant
    {
        [Required]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(5)]
        public String District { get; set; }

        [Required]
        [MaxLength(5)]
        public String CountyNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public String CountyName { get; set; }

        [Required]
        [MaxLength(200)]
        public String LicenceNumber { get; set; }

        [Required]
        [MaxLength(200)]
        public String BusinessName { get; set; }

        [Required]
        [MaxLength(200)]
        public String Address { get; set; }

        [Required]
        [MaxLength(50)]
        public String City { get; set; }

        [Required]
        [MaxLength(10)]
        public String Zip { get; set; }

        [MaxLength(20)]
        public Decimal Lat { get; set; }

        [MaxLength(20)]
        public Decimal Lon { get; set; }
    }
}