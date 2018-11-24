using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Supplier : BaseEntity
    {
        [Required]
        [MaxLength(250)]
        [Column(Order = 1)]

        public string Name { get; set; }

        [Column(Order = 2)] [MaxLength(50)] public string CodeName { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(Order = 3)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(Order = 4)]
        public string Phone { get; set; }

        [MaxLength(50)] [Column(Order = 5)] public string Fax { get; set; }

        public Guid? SiteId { get; set; }





    }
}
