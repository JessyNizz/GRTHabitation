using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models.Database.EntityObjects
{
    
    [Table("Image")]
    public class Image
    {
        
        public int Id { get; set; }
        public int QualificationId { get; set; }
        public string Note { get; set; }
        public string Path { get; set; }
    }
}