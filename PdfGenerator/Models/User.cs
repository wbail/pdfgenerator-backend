using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PdfGenerator.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }

        public DateTime CreatedAt { get; set; }

        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        public DateTime? DeletedAt { get; set; }
    }
}
