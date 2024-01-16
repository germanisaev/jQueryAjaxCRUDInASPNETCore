using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryAjaxCRUDInASPNETCore.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "This field is required.")]
        public string AccountNumber { get; set; }
        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string BeneficiaryName { get; set; }
        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string BankName { get; set; }
        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This field is required.")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}
