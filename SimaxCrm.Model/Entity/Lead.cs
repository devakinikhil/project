using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimaxCrm.Model.Entity
{
    [Table("Lead")]
    public class Lead
    {
        [Key]
        [Display(Name = "Lead Id")]
        public int Id { get; set; }

        public int Tid { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [MaxLength(200)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        [MaxLength(20)]
        [Display(Name = "Phone Name")]
        public string PhoneNumber { get; set; }

        [MaxLength(200)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(200)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [MaxLength(200)]
        [Display(Name = "City")]
        public string City { get; set; }

        [MaxLength(200)]
        [Display(Name = "State")]
        public string State { get; set; }

        [MaxLength(200)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [MaxLength(20)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Lead Source")]
        public int LeadSourceId { get; set; }

        [Required]
        [Display(Name = "Language")]
        public int LeadLanguageId { get; set; }

        [Display(Name = "Name")]
        public DateTime? LastContact { get; set; }

        [Required]
        [Display(Name = "Assigned To")]
        public string UserId { get; set; }

        [Display(Name = "Status")]
        public string LeadStatus { get; set; }

        public DateTime AssignedDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Follow Up")]
        public DateTime? AlertDate { get; set; }

        public virtual LeadLanguage LeadLanguage { get; set; }
        public virtual LeadSource LeadSource { get; set; }
        public virtual List<LeadTagMapping> LeadTagMapping { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual List<CallLog> CallLog { get; set; }
        public virtual List<UserLog> UserLog { get; set; }
        public virtual List<LeadAutoAssignLog> LeadAutoAssignLog { get; set; }
        public virtual List<Invoice> Invoice { get; set; }


        [NotMapped]
        [Display(Name = "Lead Tags")]
        public string LeadTags { get; set; }

        [NotMapped]
        [Display(Name = "Total Time")]
        public string AssignedDuration
        {
            get
            {
                return DateAndTimeDiff((DateTime)this.AssignedDate, DateTime.Now);
            }
        }


        private static string DateAndTimeDiff(DateTime dateTime1, DateTime dateTime2)
        {
            TimeSpan span = (dateTime2 - dateTime1);
            if (span.Days > 0)
                return string.Format("{0}d, {1}h, {2}m", span.Days, span.Hours, span.Minutes);
            else if (span.Hours > 0)
                return string.Format("{0}h, {1}m", span.Hours, span.Minutes);
            else
                return string.Format("{0}m", span.Minutes);
        }
    }


}
