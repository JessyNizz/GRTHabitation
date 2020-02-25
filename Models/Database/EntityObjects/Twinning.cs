using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models.Database.EntityObjects
{
    
    [Table ("Twinning")]
    public class Twinning
    {
        
        public int IdApplicant { get; set; }
        public int IdHousing { get; set; }
    }
}