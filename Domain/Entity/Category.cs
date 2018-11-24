using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [StringLength(2048)]
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? SiteId { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}
