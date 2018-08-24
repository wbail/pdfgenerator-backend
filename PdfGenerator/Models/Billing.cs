using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PdfGenerator.Models
{
    public class Billing
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        [MinLength(3)]
        public string Description { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        public DateTime CreatedAt { get; set; }

        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        public DateTime? DeletedAt { get; set; }
    }
}