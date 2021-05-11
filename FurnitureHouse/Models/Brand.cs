using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Traits")]
        public string Traits { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Material")]
        public string Material { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [NotMapped]
        public FileUpload File { get; set; }

        public virtual ICollection<FurnitureInfo> BrandFurnitureInfos { get; set; }
    }
}
