using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClamDataLibrary.Models
{
    public class ClamUserSystemTicket
    {
        [Key]
        [Required]
        public Guid SystemTicketId { get; set; }

        [Display(Name = "Ticket Number")]
        public int TicketNumber { get; set; }

        [Required]
        [MaxLength(30)]
        [DataType(DataType.Text)]
        [Display(Name = "Ticket Title")]
        public string TicketTitle { get; set; }

        [Required]
        [MaxLength(300)]
        [DataType(DataType.Text)]
        [Display(Name = "Ticket Message")]
        public string TicketMessage { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Added")]
        public DateTime DateCreated { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public Guid UserId { get; set; }
        public virtual ClamUserAccountRegister User { get; set; }

    }
}
