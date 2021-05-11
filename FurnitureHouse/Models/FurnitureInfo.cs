using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class FurnitureInfo
    {
        [Key]
        public int FurnitureInfoID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Furniture Name")]
        public string FurnitureName { get; set; }

        [Required]
        [Display(Name = "Offer Price")]
        public float OfferPrice { get; set; }

        [Required]
        [Display(Name = "Furniture Price")]
        public float Price { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [Required]
        public int FurnitureSubCategoryID { get; set; }

        [Required]
        public int BrandID { get; set; }

        [ForeignKey("FurnitureSubCategoryID")]
        [InverseProperty("FurnitureInfos")]
        public virtual FurnitureSubCategory FurnitureSubCategory { get; set; }

        [ForeignKey("BrandID")]
        [InverseProperty("BrandFurnitureInfos")]
        public virtual Brand Brand { get; set; }

        [NotMapped]
        public FileUpload File { get; set; }

        public virtual ICollection<Favourite> Favourites { get; set; }
    }
}
