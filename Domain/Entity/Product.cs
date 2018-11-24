using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Product : BaseEntity
    {


        [StringLength(256)]
        public string UrlName { get; set; }
        [Required]
        [StringLength(256)]
        public string Title { get; set; }
        public string Sku { get; set; }
        public DateTime? PublicationDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int View { get; set; }
        [StringLength(256)]
        public string Keyword { get; set; }
        public DateTime? ExpotationDate { get; set; }
        public string Description { get; set; }
        [StringLength(2048)]
        public string ShortDescription { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Depth { get; set; }

        #region Relation
        [ForeignKey("Category")]
        public Guid? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid? SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }
        public Guid? ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public Guid? StatusId { get; set; }
        //public virtual ProductStatus ProductStatus { get; set; }

        //public ICollection<ProductImage> ProductImage { get; set; }
       // public ICollection<ProductPrice> ProductPrice { get; set; }
        public Guid? SiteId { get; set; }
        #endregion
    }
}
