using System.ComponentModel.DataAnnotations;

namespace RentingWebsite.Models
{
    public class Announcements
    {
        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }
        
        
    }
}
