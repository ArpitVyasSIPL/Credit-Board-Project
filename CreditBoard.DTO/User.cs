using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreditBoard.DTO
{
    public class User : Entity<int>
    {
        public int pkUserId { get; set; }
        [Required]
      
        public int fkProfileId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        [Required]
        [MaxLength(80)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Language { get; set; }
        [Required]    
        public string IsEnabled { get; set; }
        [Required]
        public string IsDeleted { get; set; }

        [ForeignKey("pkProfileId")]
        public virtual Profile Profile { get; set; }
    }
}
