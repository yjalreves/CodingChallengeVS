using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodingChallenge.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "INT")]
        [Required]
        public int Credits { get; set; }

    }
}