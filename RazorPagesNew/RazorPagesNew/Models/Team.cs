using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesNew.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public string Sport { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Worth { get; set; }
    }
}
