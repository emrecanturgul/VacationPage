using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationPage.Models.Classes {
    public class Comments {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        
        public DateTime CommentDate { get; set; }
    }
}
