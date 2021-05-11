using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class FurnitureSubCategory
    {
        [Key]
        public int FurnitureSubCategoryID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Furniture Sub Category Name")]
        public string FurnitureSubCategoryName { get; set; }

        [Required]
        public int FurnitureCategoryID { get; set; }

        [ForeignKey("FurnitureCategoryID")]
        [InverseProperty("FurnitureSubCategories")]
        public virtual FurnitureCategory FurnitureCategory { get; set; }

        public virtual ICollection<FurnitureInfo> FurnitureInfos { get; set; }
    }
}
