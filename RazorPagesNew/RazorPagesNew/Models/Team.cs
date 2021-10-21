using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesNew.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public string Sport { get; set; }
        public decimal Worth { get; set; }
    }
}
