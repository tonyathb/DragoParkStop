using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingStop.Data
{
    public class ParkingPlace
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }

       // [NotMapped]
      //  public Invalid IsInvalid { get; set; }

        public int CategoryId { get; set; }
        public Category Categorys { get; set; }


       // [Column(TypeName = "decimal(10,2")]
        public decimal Price { get; set; }
        public int Size { get; set; }

      //  [NotMapped]
       // public Statuss Status { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public DateTime RegisterOn { get; set; }

    }
}
