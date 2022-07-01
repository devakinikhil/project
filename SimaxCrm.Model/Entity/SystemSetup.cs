using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimaxCrm.Model.Entity
{
    [Table("SystemSetup")]
    public class SystemSetup
    {
        [Key]
        public int Id { get; set; }

        public int Tid { get; set; }

        [Required(ErrorMessage = "Enter Company Name")]
        [MaxLength(200)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [MaxLength(200)]
        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        [MaxLength(200)]
        [Display(Name = "Contact Number")]
        public string CompanyContact { get; set; }

        [MaxLength(200)]
        [Display(Name = "GST/VAT Number")]
        public string CompanyGstNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Tax Percent")]
        public decimal TaxPercent { get; set; }

        [Required(ErrorMessage = "Enter Currency")]
        [MaxLength(50)]
        [Display(Name = "Currency Name")]
        public string Currency { get; set; }

        [Required(ErrorMessage = "Enter Currency Symbol")]
        [MaxLength(50)]
        [Display(Name = "Currency Symbol")]
        public string CurrencySymbol { get; set; }

        [MaxLength(200)]
        [Display(Name = "Browse Company Logo")]
        public string CompanyLogo { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //TableProperties












    }
}
