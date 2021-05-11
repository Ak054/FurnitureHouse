using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class Favourite
    {
        [Key]
        public int FavouriteID { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Required]
        public int FurnitureInfoID { get; set; }

        [ForeignKey("FurnitureInfoID")]
        [InverseProperty("Favourites")]
        public virtual FurnitureInfo FurnitureInfo { get; set; }

    }
}
