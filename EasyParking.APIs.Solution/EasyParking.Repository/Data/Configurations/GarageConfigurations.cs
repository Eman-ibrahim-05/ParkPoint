using EasyParking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyParking.Repository.Data.Configurations
{
	public class GarageConfigurations : IEntityTypeConfiguration<Garage>
	{
		public void Configure(EntityTypeBuilder<Garage> builder)
		{
			builder.Property(G => G.Name).IsRequired().HasMaxLength(60);
			builder.Property(G => G.Country).IsRequired().HasMaxLength(50);
			builder.Property(G => G.City).IsRequired().HasMaxLength(40);
			builder.Property(G => G.Town).IsRequired().HasMaxLength(30);
			builder.Property(G => G.Street).IsRequired().HasMaxLength(20);
			builder.Property(G => G.PictureUrl).IsRequired();
			builder.Property(G => G.HourPrice).IsRequired().HasColumnType("decimal(18,2)");
		}
	}
}
