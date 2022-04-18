using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Arta.Data.Models
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
    }
}
