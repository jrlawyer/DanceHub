using System;
using System.ComponentModel.DataAnnotations;

namespace DanceHub.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Studio { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [Required]
        public Type Type { get; set; }
    }
}