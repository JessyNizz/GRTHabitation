using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models
{
    [Table ("Member")]
    public class Member
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}