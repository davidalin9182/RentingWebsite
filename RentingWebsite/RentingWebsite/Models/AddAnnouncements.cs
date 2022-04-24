using System.ComponentModel.DataAnnotations;

namespace RentingWebsite.Models
{
    public class AddAnnouncements
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
        public string Readmore { get; set; }

        
    }
}
