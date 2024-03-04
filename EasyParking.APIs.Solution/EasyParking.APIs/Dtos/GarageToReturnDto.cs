namespace EasyParking.APIs.Dtos
{
	public class GarageToReturnDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string PictureUrl { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string Town { get; set; }
		public string Street { get; set; }

		public decimal HourPrice { get; set; }

	}
}
