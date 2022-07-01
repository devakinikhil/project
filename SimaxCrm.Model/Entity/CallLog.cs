using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimaxCrm.Model.Entity
{
    [Table("CallLog")]
    public class CallLog
    {
        [Key]
        public int Id { get; set; }

        public int Tid { get; set; }

        public int LeadId { get; set; }

        public string UserId { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Remarks { get; set; }

        [Required]
        public string Message { get; set; }

        [Display(Name = "Remind At")]
        public DateTime? AlertDate { get; set; }

        public DateTime CreatedDate { get; set; }

        //TableProperties

        public virtual Lead Lead { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int? InvoiceId { get; set; }
    }
}
