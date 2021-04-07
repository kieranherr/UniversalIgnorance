using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalIgnorance.Models
{
    public class ImageLocations
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageLocation { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products product { get; set; }
    }
}
