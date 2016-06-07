using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CreditBoard.DTO
{
   public class Profile : Entity<int>
    {
        public int pkProfileId { get; set; }      
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }       
        [Required]
        public string IsEnabled { get; set; }
        [Required]
        public string IsDeleted { get; set; }
        public List<User> Users { get; set; }
    }
}
