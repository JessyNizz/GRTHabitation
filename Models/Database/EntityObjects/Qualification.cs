using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models.Database.EntityObjects
{
    
    [Table ("Qualification")]
    public class Qualification
    {
     
        public int Id { get; set; }
        public int HousingId { get; set; }
        public bool HaveMoldTraces { get; set; }
        public int StairSafety { get; set; }
        public int PeronSafety { get; set; }
        public int LightningSafety { get; set; }
        public int DetectorSafety { get; set; }
        public int Cleanliness { get; set; }
        public int WindowsQuality { get; set; }
        public int DoorsQuality { get; set; }
        public int FittingsQuality { get; set; }
        public int ToiletQuality { get; set; }
        public int BathShowerQuality { get; set; }
        public int GeneralMaintenance { get; set; }
        public bool PestProblem { get; set; }
        public int FinalScore { get; set; }
    }
}