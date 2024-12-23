using System.ComponentModel.DataAnnotations;

namespace VacationPage.Models.Classes {
    public class HomePage { 
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}