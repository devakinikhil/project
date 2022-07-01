using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimaxCrm.Model.Entity
{
    [Table("LeadSource")]
    public class LeadSource
    {
        [Key]
        public int Id { get; set; }

        public int Tid { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [MaxLength(200)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //TableProperties

        public virtual List<Lead> Lead { get; set; }
        public virtual List<LeadAutoAssignSourceMapping> LeadAutoAssignSourceMapping { get; set; }
        public virtual List<LeadAutoAssignLog> LeadAutoAssignLog { get; set; }

    }
}
