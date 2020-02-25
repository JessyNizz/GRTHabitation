using System.ComponentModel.DataAnnotations.Schema;

namespace GRTHabitation.Models.Database.EntityObjects
{
    
    [Table("Housing")]
    public class Housing
    {
        
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int ContactId { get; set; }
        public string Address { get; set; }
        public string Sector { get; set; }
        public string SchoolArea { get; set; }
        public int RoomCount { get; set; }
        public int ParkingCount { get; set; }
        public string Level { get; set; }
        public bool AllowAnimals { get; set; }
        public bool Heated { get; set; }
        public bool Enlightened { get; set; }
        public bool SemiFurnished { get; set; }
        public bool FirstRentFree { get; set; }
        public bool RentCost { get; set; }
        public double EnergyCost { get; set; }
        public string Note { get; set; }
        public string ElectronicSignature { get; set; }
    }
}