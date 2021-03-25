using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopDataLibrary.Models
{
    public class Product
    {
        [Key]
        /// <summary>
        /// Unique identifier
        /// </summary>
        public Guid Id { get; set; }
        [Required]
        [MaxLength(127)]
        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Briefly describe of the product
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// String path to image of the product
        /// </summary>
        public string ImageSource { get; set; }
        [Required]
        /// <summary>
        /// Price of the product
        /// </summary>
        public Single Price { get; set; }

        public Product() {
            Id = Guid.NewGuid();
        }
    }
}
