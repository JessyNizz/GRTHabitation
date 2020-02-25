using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models.Database.EntityObjects
{
    
    [Table("Applicant")]
    public class Applicant
    {

        public int Id { get; set; }
        public string HousingTypeSought { get; set; }
        public double FamilyIncome { get; set; }
        public bool HaveAnimals { get; set; }
        public bool HaveLease { get; set; }
    }
}