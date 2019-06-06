using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodingChallenge.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        public string Fullname
        {
            get => $"{FirstName} {LastName}";
        }

    }
}