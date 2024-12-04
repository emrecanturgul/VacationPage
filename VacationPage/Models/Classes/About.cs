using System.ComponentModel.DataAnnotations;

namespace VacationPage.Models.Classes {
    public class About { 
        [Key]
        public int Id { get; set; }

        public string PhotoUrl { get; set; } = string.Empty;
    
        public string Description { get; set; } = string.Empty;
    }
} 
