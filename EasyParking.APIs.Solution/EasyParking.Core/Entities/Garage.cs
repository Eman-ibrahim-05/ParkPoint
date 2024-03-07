using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyParking.Core.Entities
{
	public class Garage : BaseEntity
	{

		
		public string LocationUrl { get; set; }

		public decimal HourPrice { get; set; }
		
	}
}
