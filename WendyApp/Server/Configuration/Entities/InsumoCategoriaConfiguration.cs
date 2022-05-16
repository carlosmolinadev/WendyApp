using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class InsumoCategoriaConfiguration : IEntityTypeConfiguration<InsumoCategoria>
    {

        public void Configure(EntityTypeBuilder<InsumoCategoria> builder)
        {
            builder.HasData(
				new InsumoCategoria
				{
					Id = 1,
					InsumoId = 1,
					CategoriaId = 1
				},
				new InsumoCategoria
				{
					Id = 2,
					InsumoId = 2,
					CategoriaId = 1
				}, new InsumoCategoria
				{
					Id = 3,
					InsumoId = 3,
					CategoriaId = 1
				},
				new InsumoCategoria
				{
					Id = 4,
					InsumoId = 4,
					CategoriaId = 1
				},
				new InsumoCategoria
				{
					Id = 5,
					InsumoId = 5,
					CategoriaId = 1
				},
				new InsumoCategoria
				{
					Id = 6,
					InsumoId = 6,
					CategoriaId = 1
				},
				new InsumoCategoria
				{
					Id = 7,
					InsumoId = 7,
					CategoriaId = 2
				},
				new InsumoCategoria
				{
					Id = 8,
					InsumoId = 8,
					CategoriaId = 2
				},
				new InsumoCategoria
				{
					Id = 9,
					InsumoId = 9,
					CategoriaId = 3
				},
				new InsumoCategoria
				{
					Id = 10,
					InsumoId = 10,
					CategoriaId = 4
				},
				new InsumoCategoria
				{
					Id = 11,
					InsumoId = 11,
					CategoriaId = 4
				},
				new InsumoCategoria
				{
					Id = 12,
					InsumoId = 12,
					CategoriaId = 5
				},
				new InsumoCategoria
				{
					Id = 13,
					InsumoId = 13,
					CategoriaId = 5
				},
				new InsumoCategoria
				{
					Id = 14,
					InsumoId = 14,
					CategoriaId = 5
				},
				new InsumoCategoria
				{
					Id = 15,
					InsumoId = 15,
					CategoriaId = 5
				},
				new InsumoCategoria
				{
					Id = 16,
					InsumoId = 16,
					CategoriaId = 5
				},
				new InsumoCategoria
				{
					Id = 17,
					InsumoId = 17,
					CategoriaId = 6
				},
				new InsumoCategoria
				{
					Id = 18,
					InsumoId = 18,
					CategoriaId = 6
				},
				new InsumoCategoria
				{
					Id = 19,
					InsumoId = 19,
					CategoriaId = 6
				},
				new InsumoCategoria
				{
					Id = 20,
					InsumoId = 20,
					CategoriaId = 7
				},
				new InsumoCategoria
				{
					Id = 21,
					InsumoId = 21,
					CategoriaId = 7
				},
				new InsumoCategoria
				{
					Id = 22,
					InsumoId = 22,
					CategoriaId = 14
				},
				new InsumoCategoria
				{
					Id = 23,
					InsumoId = 23,
					CategoriaId = 7
				},
				new InsumoCategoria
				{
					Id = 24,
					InsumoId = 24,
					CategoriaId = 8
				},
				new InsumoCategoria
				{
					Id = 25,
					InsumoId = 25,
					CategoriaId = 8
				},
				new InsumoCategoria
				{
					Id = 26,
					InsumoId = 26,
					CategoriaId = 8
				},
				new InsumoCategoria
				{
					Id = 27,
					InsumoId = 27,
					CategoriaId = 9
				},
				new InsumoCategoria
				{
					Id = 28,
					InsumoId = 28,
					CategoriaId = 9
				},
				new InsumoCategoria
				{
					Id = 29,
					InsumoId = 29,
					CategoriaId = 9
				},
				new InsumoCategoria
				{
					Id = 30,
					InsumoId = 30,
					CategoriaId = 10
				},
				new InsumoCategoria
				{
					Id = 31,
					InsumoId = 31,
					CategoriaId = 10
				},
				new InsumoCategoria
				{
					Id = 32,
					InsumoId = 32,
					CategoriaId = 11
				},
				new InsumoCategoria
				{
					Id = 33,
					InsumoId = 33,
					CategoriaId = 11
				},
				new InsumoCategoria
				{
					Id = 34,
					InsumoId = 34,
					CategoriaId = 11
				},
				new InsumoCategoria
				{
					Id = 35,
					InsumoId = 35,
					CategoriaId = 12
				},
				new InsumoCategoria
				{
					Id = 36,
					InsumoId = 36,
					CategoriaId = 12
				},
				new InsumoCategoria
				{
					Id = 37,
					InsumoId = 37,
					CategoriaId = 12
				},
				new InsumoCategoria
				{
					Id = 38,
					InsumoId = 38,
					CategoriaId = 12
				},
				new InsumoCategoria
				{
					Id = 39,
					InsumoId = 39,
					CategoriaId = 12
				},
				new InsumoCategoria
				{
					Id = 40,
					InsumoId = 40,
					CategoriaId = 13
				},
				new InsumoCategoria
				{
					Id = 41,
					InsumoId = 41,
					CategoriaId = 13
				},
				new InsumoCategoria
				{
					Id = 42,
					InsumoId = 42,
					CategoriaId = 13
				},
				new InsumoCategoria
				{
					Id = 43,
					InsumoId = 43,
					CategoriaId = 13
				},
				new InsumoCategoria
				{
					Id = 44,
					InsumoId = 44,
					CategoriaId = 13
				},
				new InsumoCategoria
				{
					Id = 45,
					InsumoId = 45,
					CategoriaId = 14
				}
			);
        }
    }
}
