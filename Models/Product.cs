using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSDeShopOnWeb.Models
{
    public class Product : BaseEntity
    {

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PictureUri { get; private set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        public Product (string name, string description, string pictureUri, decimal price)
        {
            Name = name;
            Description = description;
            PictureUri = pictureUri;
            Price = price;
        }
    }
}
