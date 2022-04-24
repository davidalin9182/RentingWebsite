using System.ComponentModel.DataAnnotations;

namespace RentingWebsite.Models
{
    public class Credits
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
        
        
    }
}
