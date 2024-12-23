using System.ComponentModel.DataAnnotations;

namespace VacationPage.Models.Classes { 
    public class Blog { 
        [Key]
        public int Id { get; set; } 
        public string? Title { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string? BlogImage { get; set; }
    }
}
