using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Arta.Data.Models
{
    public class Main
    {
        [Key]
        public int MainId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
    }
}
