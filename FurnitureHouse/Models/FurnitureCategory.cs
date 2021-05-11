using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class FurnitureCategory
    {
        [Key]
        public int FurnitureCategoryID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Furniture Category Name")]
        public string FurnitureCategoryName { get; set; }

        public virtual ICollection<FurnitureSubCategory> FurnitureSubCategories { get; set; }
    }
}
