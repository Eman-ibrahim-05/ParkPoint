using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyParking.Core.Entities
{
	public class Garage : BaseEntity
	{

		
		public string Country { get; set; }
		public string City { get; set; }
		public string Town { get; set; }
		public string Street { get; set; }

		public decimal HourPrice { get; set; }
		
	}
}
