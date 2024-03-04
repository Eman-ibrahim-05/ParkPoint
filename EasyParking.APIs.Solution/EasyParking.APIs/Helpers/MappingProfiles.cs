using AutoMapper;
using EasyParking.APIs.Dtos;
using EasyParking.Core.Entities;

namespace EasyParking.APIs.Helpers
{
	public class MappingProfiles:Profile
	{
        public MappingProfiles()
		{
			CreateMap<Pakya, PakyaToReturnDto>()
					 .ForMember(PG => PG.Garage, O => O.MapFrom(P => P.Garage.Name));
			CreateMap<Garage, GarageToReturnDto>();
        }
    }
}
