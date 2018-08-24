using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PdfGenerator.Models
{
    public class BillingUser
    {
        public int Id { get; set; }

        public DateTime DueDate { get; set; }

        public byte Status { get; set; }
        //{ Pending = 0, Completed = 1, Canceled = 2, Prossesing = 3, Failed = 4, Created = 5, Denied = 6, Expired = 7}

        public int UserId { get; set; }
        public User User { get; set; }

        public int BillingId { get; set; }
        public Billing Billing { get; set; }

        public DateTime CreatedAt { get; set; }

        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        public DateTime? DeletedAt { get; set; }
    }
}
