using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models.Database.EntityObjects
{
    
    [Table ("User")]
    public class User
    {
        
        public int Id { get; set; }
        public int FolderNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Password { get; set; }
    }
}