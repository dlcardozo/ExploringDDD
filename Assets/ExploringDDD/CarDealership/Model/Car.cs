namespace ExploringDDD.CarDealership.Model
{
    public struct Car
    {
        public CarId CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Money Cost { get; set; }
    }
}