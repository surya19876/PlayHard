
namespace Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public decimal AddressCoordinateX { get; set; }
        public decimal AddressCoordinateY { get; set; }
        public bool IsActive { get; set; }
        
    }
}
