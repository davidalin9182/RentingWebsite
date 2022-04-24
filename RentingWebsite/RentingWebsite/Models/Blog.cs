using System.ComponentModel.DataAnnotations;

namespace RentingWebsite.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
        
        
    }
}
