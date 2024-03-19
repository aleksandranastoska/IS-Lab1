using System;
using System.ComponentModel.DataAnnotations;

namespace Labs.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Price { get; set; }
        public Guid? UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid? TheatreShowId { get; set; }
        public virtual TheatreShow TheatreShow { get; set; }
    }
}
