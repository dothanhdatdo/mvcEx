using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Manufacturer : BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string CodeName { get; set; }
        public string Description { get; set; }
        [MaxLength(250)]
        public string Website { get; set; }
        [Column("LogoPath")]
        public string Logo { get; set; }
        public Guid? SiteId { get; set; }






    }
}
