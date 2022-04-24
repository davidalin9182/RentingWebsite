using System.ComponentModel.DataAnnotations;

namespace RentingWebsite.Models
{
   
    
        public class Home
        {
            [Key]
            public int Id { get; set; }
            public string NewGames { get; set; }


        }
    
}
