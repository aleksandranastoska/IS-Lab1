using System.ComponentModel.DataAnnotations;

namespace Labs.Models
{
    public class TheatreShow
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? ShowDate { get; set; }
        public String? Description{ get; set; }
        public string? Place { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }   
        
    }
}
