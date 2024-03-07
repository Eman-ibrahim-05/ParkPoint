using EasyParking.Core.Entities;
using EasyParking.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElSayes.APIs.Controllers
{
	
	public class UpdateGarageController : ApiBaseController
	{
		private readonly IGenericRepository<Garage> garageRepo;
        public UpdateGarageController(IGenericRepository<Garage> garageRepo)
        {
			this.garageRepo = garageRepo;
		}
        [HttpPost]
		public async Task<ActionResult<Garage>> UpdateGarage(Garage garage, int id = 2)
		{

		}
	}
}
