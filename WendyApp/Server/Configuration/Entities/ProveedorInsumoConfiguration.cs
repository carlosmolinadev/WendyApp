using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Server.Interfaces.IServices;
using WendyApp.Server.Services;
using WendyApp.Shared.Domain;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace WendyApp.Server.Configuration.Entities
{
    public class ProveedorInsumoConfiguration : IEntityTypeConfiguration<ProveedorInsumo>
    {
        public void Configure(EntityTypeBuilder<ProveedorInsumo> builder)
        {
            builder.HasData(
                               new ProveedorInsumo
                               {
                                   Id = 1,
                                   ProveedorId = 1,
                                   InsumoId = 1,
                                   Precio = (decimal)0.30
                               },
               new ProveedorInsumo
               {
                   Id = 2,
                   ProveedorId = 1,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 3,
                   ProveedorId = 1,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 4,
                   ProveedorId = 1,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 5,
                   ProveedorId = 1,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 6,
                   ProveedorId = 1,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 7,
                   ProveedorId = 1,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 8,
                   ProveedorId = 1,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 9,
                   ProveedorId = 1,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 10,
                   ProveedorId = 1,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 11,
                   ProveedorId = 1,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 12,
                   ProveedorId = 1,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 13,
                   ProveedorId = 1,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 14,
                   ProveedorId = 1,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 15,
                   ProveedorId = 1,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 16,
                   ProveedorId = 1,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 17,
                   ProveedorId = 1,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 18,
                   ProveedorId = 1,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 19,
                   ProveedorId = 1,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 20,
                   ProveedorId = 1,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 21,
                   ProveedorId = 1,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 22,
                   ProveedorId = 1,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 23,
                   ProveedorId = 1,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 24,
                   ProveedorId = 1,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 25,
                   ProveedorId = 1,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 26,
                   ProveedorId = 1,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 27,
                   ProveedorId = 1,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 28,
                   ProveedorId = 1,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 29,
                   ProveedorId = 1,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 30,
                   ProveedorId = 1,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 31,
                   ProveedorId = 1,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 32,
                   ProveedorId = 1,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 33,
                   ProveedorId = 1,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 34,
                   ProveedorId = 1,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 35,
                   ProveedorId = 1,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 36,
                   ProveedorId = 1,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 37,
                   ProveedorId = 1,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 38,
                   ProveedorId = 1,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 39,
                   ProveedorId = 1,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 40,
                   ProveedorId = 1,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 41,
                   ProveedorId = 1,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 42,
                   ProveedorId = 1,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 43,
                   ProveedorId = 1,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 44,
                   ProveedorId = 1,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 45,
                   ProveedorId = 1,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 46,
                   ProveedorId = 2,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 47,
                   ProveedorId = 2,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 48,
                   ProveedorId = 2,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 49,
                   ProveedorId = 2,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 50,
                   ProveedorId = 2,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 51,
                   ProveedorId = 2,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 52,
                   ProveedorId = 2,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 53,
                   ProveedorId = 2,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 54,
                   ProveedorId = 2,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 55,
                   ProveedorId = 2,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 56,
                   ProveedorId = 2,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 57,
                   ProveedorId = 2,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 58,
                   ProveedorId = 2,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 59,
                   ProveedorId = 2,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 60,
                   ProveedorId = 2,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 61,
                   ProveedorId = 2,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 62,
                   ProveedorId = 2,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 63,
                   ProveedorId = 2,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 64,
                   ProveedorId = 2,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 65,
                   ProveedorId = 2,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 66,
                   ProveedorId = 2,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 67,
                   ProveedorId = 2,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 68,
                   ProveedorId = 2,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 69,
                   ProveedorId = 2,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 70,
                   ProveedorId = 2,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 71,
                   ProveedorId = 2,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 72,
                   ProveedorId = 2,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 73,
                   ProveedorId = 2,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 74,
                   ProveedorId = 2,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 75,
                   ProveedorId = 2,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 76,
                   ProveedorId = 2,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 77,
                   ProveedorId = 2,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 78,
                   ProveedorId = 2,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 79,
                   ProveedorId = 2,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 80,
                   ProveedorId = 2,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 81,
                   ProveedorId = 2,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 82,
                   ProveedorId = 2,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 83,
                   ProveedorId = 2,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 84,
                   ProveedorId = 2,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 85,
                   ProveedorId = 2,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 86,
                   ProveedorId = 2,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 87,
                   ProveedorId = 2,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 88,
                   ProveedorId = 2,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 89,
                   ProveedorId = 2,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 90,
                   ProveedorId = 2,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 91,
                   ProveedorId = 3,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 92,
                   ProveedorId = 3,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 93,
                   ProveedorId = 3,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 94,
                   ProveedorId = 3,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 95,
                   ProveedorId = 3,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 96,
                   ProveedorId = 3,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 97,
                   ProveedorId = 3,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 98,
                   ProveedorId = 3,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 99,
                   ProveedorId = 3,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 100,
                   ProveedorId = 3,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 101,
                   ProveedorId = 3,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 102,
                   ProveedorId = 3,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 103,
                   ProveedorId = 3,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 104,
                   ProveedorId = 3,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 105,
                   ProveedorId = 3,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 106,
                   ProveedorId = 3,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 107,
                   ProveedorId = 3,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 108,
                   ProveedorId = 3,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 109,
                   ProveedorId = 3,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 110,
                   ProveedorId = 3,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 111,
                   ProveedorId = 3,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 112,
                   ProveedorId = 3,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 113,
                   ProveedorId = 3,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 114,
                   ProveedorId = 3,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 115,
                   ProveedorId = 3,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 116,
                   ProveedorId = 3,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 117,
                   ProveedorId = 3,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 118,
                   ProveedorId = 3,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 119,
                   ProveedorId = 3,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 120,
                   ProveedorId = 3,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 121,
                   ProveedorId = 3,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 122,
                   ProveedorId = 3,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 123,
                   ProveedorId = 3,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 124,
                   ProveedorId = 3,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 125,
                   ProveedorId = 3,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 126,
                   ProveedorId = 3,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 127,
                   ProveedorId = 3,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 128,
                   ProveedorId = 3,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 129,
                   ProveedorId = 3,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 130,
                   ProveedorId = 3,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 131,
                   ProveedorId = 3,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 132,
                   ProveedorId = 3,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 133,
                   ProveedorId = 3,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 134,
                   ProveedorId = 3,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 135,
                   ProveedorId = 3,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 136,
                   ProveedorId = 4,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 137,
                   ProveedorId = 4,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 138,
                   ProveedorId = 4,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 139,
                   ProveedorId = 4,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 140,
                   ProveedorId = 4,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 141,
                   ProveedorId = 4,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 142,
                   ProveedorId = 4,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 143,
                   ProveedorId = 4,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 144,
                   ProveedorId = 4,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 145,
                   ProveedorId = 4,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 146,
                   ProveedorId = 4,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 147,
                   ProveedorId = 4,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 148,
                   ProveedorId = 4,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 149,
                   ProveedorId = 4,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 150,
                   ProveedorId = 4,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 151,
                   ProveedorId = 4,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 152,
                   ProveedorId = 4,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 153,
                   ProveedorId = 4,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 154,
                   ProveedorId = 4,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 155,
                   ProveedorId = 4,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 156,
                   ProveedorId = 4,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 157,
                   ProveedorId = 4,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 158,
                   ProveedorId = 4,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 159,
                   ProveedorId = 4,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 160,
                   ProveedorId = 4,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 161,
                   ProveedorId = 4,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 162,
                   ProveedorId = 4,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 163,
                   ProveedorId = 4,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 164,
                   ProveedorId = 4,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 165,
                   ProveedorId = 4,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 166,
                   ProveedorId = 4,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 167,
                   ProveedorId = 4,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 168,
                   ProveedorId = 4,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 169,
                   ProveedorId = 4,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 170,
                   ProveedorId = 4,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 171,
                   ProveedorId = 4,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 172,
                   ProveedorId = 4,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 173,
                   ProveedorId = 4,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 174,
                   ProveedorId = 4,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 175,
                   ProveedorId = 4,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 176,
                   ProveedorId = 4,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 177,
                   ProveedorId = 4,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 178,
                   ProveedorId = 4,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 179,
                   ProveedorId = 4,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 180,
                   ProveedorId = 4,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 181,
                   ProveedorId = 5,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 182,
                   ProveedorId = 5,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 183,
                   ProveedorId = 5,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 184,
                   ProveedorId = 5,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 185,
                   ProveedorId = 5,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 186,
                   ProveedorId = 5,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 187,
                   ProveedorId = 5,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 188,
                   ProveedorId = 5,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 189,
                   ProveedorId = 5,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 190,
                   ProveedorId = 5,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 191,
                   ProveedorId = 5,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 192,
                   ProveedorId = 5,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 193,
                   ProveedorId = 5,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 194,
                   ProveedorId = 5,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 195,
                   ProveedorId = 5,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 196,
                   ProveedorId = 5,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 197,
                   ProveedorId = 5,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 198,
                   ProveedorId = 5,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 199,
                   ProveedorId = 5,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 200,
                   ProveedorId = 5,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 201,
                   ProveedorId = 5,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 202,
                   ProveedorId = 5,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 203,
                   ProveedorId = 5,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 204,
                   ProveedorId = 5,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 205,
                   ProveedorId = 5,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 206,
                   ProveedorId = 5,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 207,
                   ProveedorId = 5,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 208,
                   ProveedorId = 5,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 209,
                   ProveedorId = 5,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 210,
                   ProveedorId = 5,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 211,
                   ProveedorId = 5,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 212,
                   ProveedorId = 5,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 213,
                   ProveedorId = 5,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 214,
                   ProveedorId = 5,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 215,
                   ProveedorId = 5,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 216,
                   ProveedorId = 5,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 217,
                   ProveedorId = 5,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 218,
                   ProveedorId = 5,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 219,
                   ProveedorId = 5,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 220,
                   ProveedorId = 5,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 221,
                   ProveedorId = 5,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 222,
                   ProveedorId = 5,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 223,
                   ProveedorId = 5,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 224,
                   ProveedorId = 5,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 225,
                   ProveedorId = 5,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 226,
                   ProveedorId = 6,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 227,
                   ProveedorId = 6,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 228,
                   ProveedorId = 6,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 229,
                   ProveedorId = 6,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 230,
                   ProveedorId = 6,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 231,
                   ProveedorId = 6,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 232,
                   ProveedorId = 6,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 233,
                   ProveedorId = 6,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 234,
                   ProveedorId = 6,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 235,
                   ProveedorId = 6,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 236,
                   ProveedorId = 6,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 237,
                   ProveedorId = 6,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 238,
                   ProveedorId = 6,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 239,
                   ProveedorId = 6,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 240,
                   ProveedorId = 6,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 241,
                   ProveedorId = 6,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 242,
                   ProveedorId = 6,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 243,
                   ProveedorId = 6,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 244,
                   ProveedorId = 6,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 245,
                   ProveedorId = 6,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 246,
                   ProveedorId = 6,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 247,
                   ProveedorId = 6,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 248,
                   ProveedorId = 6,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 249,
                   ProveedorId = 6,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 250,
                   ProveedorId = 6,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 251,
                   ProveedorId = 6,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 252,
                   ProveedorId = 6,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 253,
                   ProveedorId = 6,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 254,
                   ProveedorId = 6,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 255,
                   ProveedorId = 6,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 256,
                   ProveedorId = 6,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 257,
                   ProveedorId = 6,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 258,
                   ProveedorId = 6,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 259,
                   ProveedorId = 6,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 260,
                   ProveedorId = 6,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 261,
                   ProveedorId = 6,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 262,
                   ProveedorId = 6,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 263,
                   ProveedorId = 6,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 264,
                   ProveedorId = 6,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 265,
                   ProveedorId = 6,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 266,
                   ProveedorId = 6,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 267,
                   ProveedorId = 6,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 268,
                   ProveedorId = 6,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 269,
                   ProveedorId = 6,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 270,
                   ProveedorId = 6,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 271,
                   ProveedorId = 7,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 272,
                   ProveedorId = 7,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 273,
                   ProveedorId = 7,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 274,
                   ProveedorId = 7,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 275,
                   ProveedorId = 7,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 276,
                   ProveedorId = 7,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 277,
                   ProveedorId = 7,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 278,
                   ProveedorId = 7,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 279,
                   ProveedorId = 7,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 280,
                   ProveedorId = 7,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 281,
                   ProveedorId = 7,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 282,
                   ProveedorId = 7,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 283,
                   ProveedorId = 7,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 284,
                   ProveedorId = 7,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 285,
                   ProveedorId = 7,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 286,
                   ProveedorId = 7,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 287,
                   ProveedorId = 7,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 288,
                   ProveedorId = 7,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 289,
                   ProveedorId = 7,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 290,
                   ProveedorId = 7,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 291,
                   ProveedorId = 7,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 292,
                   ProveedorId = 7,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 293,
                   ProveedorId = 7,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 294,
                   ProveedorId = 7,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 295,
                   ProveedorId = 7,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 296,
                   ProveedorId = 7,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 297,
                   ProveedorId = 7,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 298,
                   ProveedorId = 7,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 299,
                   ProveedorId = 7,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 300,
                   ProveedorId = 7,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 301,
                   ProveedorId = 7,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 302,
                   ProveedorId = 7,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 303,
                   ProveedorId = 7,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 304,
                   ProveedorId = 7,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 305,
                   ProveedorId = 7,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 306,
                   ProveedorId = 7,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 307,
                   ProveedorId = 7,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 308,
                   ProveedorId = 7,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 309,
                   ProveedorId = 7,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 310,
                   ProveedorId = 7,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 311,
                   ProveedorId = 7,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 312,
                   ProveedorId = 7,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 313,
                   ProveedorId = 7,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 314,
                   ProveedorId = 7,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 315,
                   ProveedorId = 7,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 316,
                   ProveedorId = 8,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 317,
                   ProveedorId = 8,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 318,
                   ProveedorId = 8,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 319,
                   ProveedorId = 8,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 320,
                   ProveedorId = 8,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 321,
                   ProveedorId = 8,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 322,
                   ProveedorId = 8,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 323,
                   ProveedorId = 8,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 324,
                   ProveedorId = 8,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 325,
                   ProveedorId = 8,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 326,
                   ProveedorId = 8,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 327,
                   ProveedorId = 8,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 328,
                   ProveedorId = 8,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 329,
                   ProveedorId = 8,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 330,
                   ProveedorId = 8,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 331,
                   ProveedorId = 8,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 332,
                   ProveedorId = 8,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 333,
                   ProveedorId = 8,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 334,
                   ProveedorId = 8,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 335,
                   ProveedorId = 8,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 336,
                   ProveedorId = 8,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 337,
                   ProveedorId = 8,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 338,
                   ProveedorId = 8,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 339,
                   ProveedorId = 8,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 340,
                   ProveedorId = 8,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 341,
                   ProveedorId = 8,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 342,
                   ProveedorId = 8,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 343,
                   ProveedorId = 8,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 344,
                   ProveedorId = 8,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 345,
                   ProveedorId = 8,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 346,
                   ProveedorId = 8,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 347,
                   ProveedorId = 8,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 348,
                   ProveedorId = 8,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 349,
                   ProveedorId = 8,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 350,
                   ProveedorId = 8,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 351,
                   ProveedorId = 8,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 352,
                   ProveedorId = 8,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 353,
                   ProveedorId = 8,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 354,
                   ProveedorId = 8,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 355,
                   ProveedorId = 8,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 356,
                   ProveedorId = 8,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 357,
                   ProveedorId = 8,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 358,
                   ProveedorId = 8,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 359,
                   ProveedorId = 8,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 360,
                   ProveedorId = 8,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 361,
                   ProveedorId = 9,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 362,
                   ProveedorId = 9,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 363,
                   ProveedorId = 9,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 364,
                   ProveedorId = 9,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 365,
                   ProveedorId = 9,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 366,
                   ProveedorId = 9,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 367,
                   ProveedorId = 9,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 368,
                   ProveedorId = 9,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 369,
                   ProveedorId = 9,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 370,
                   ProveedorId = 9,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 371,
                   ProveedorId = 9,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 372,
                   ProveedorId = 9,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 373,
                   ProveedorId = 9,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 374,
                   ProveedorId = 9,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 375,
                   ProveedorId = 9,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 376,
                   ProveedorId = 9,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 377,
                   ProveedorId = 9,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 378,
                   ProveedorId = 9,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 379,
                   ProveedorId = 9,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 380,
                   ProveedorId = 9,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 381,
                   ProveedorId = 9,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 382,
                   ProveedorId = 9,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 383,
                   ProveedorId = 9,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 384,
                   ProveedorId = 9,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 385,
                   ProveedorId = 9,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 386,
                   ProveedorId = 9,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 387,
                   ProveedorId = 9,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 388,
                   ProveedorId = 9,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 389,
                   ProveedorId = 9,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 390,
                   ProveedorId = 9,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 391,
                   ProveedorId = 9,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 392,
                   ProveedorId = 9,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 393,
                   ProveedorId = 9,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 394,
                   ProveedorId = 9,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 395,
                   ProveedorId = 9,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 396,
                   ProveedorId = 9,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 397,
                   ProveedorId = 9,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 398,
                   ProveedorId = 9,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 399,
                   ProveedorId = 9,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 400,
                   ProveedorId = 9,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 401,
                   ProveedorId = 9,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 402,
                   ProveedorId = 9,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 403,
                   ProveedorId = 9,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 404,
                   ProveedorId = 9,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 405,
                   ProveedorId = 9,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 406,
                   ProveedorId = 10,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 407,
                   ProveedorId = 10,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 408,
                   ProveedorId = 10,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 409,
                   ProveedorId = 10,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 410,
                   ProveedorId = 10,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 411,
                   ProveedorId = 10,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 412,
                   ProveedorId = 10,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 413,
                   ProveedorId = 10,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 414,
                   ProveedorId = 10,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 415,
                   ProveedorId = 10,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 416,
                   ProveedorId = 10,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 417,
                   ProveedorId = 10,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 418,
                   ProveedorId = 10,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 419,
                   ProveedorId = 10,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 420,
                   ProveedorId = 10,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 421,
                   ProveedorId = 10,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 422,
                   ProveedorId = 10,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 423,
                   ProveedorId = 10,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 424,
                   ProveedorId = 10,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 425,
                   ProveedorId = 10,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 426,
                   ProveedorId = 10,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 427,
                   ProveedorId = 10,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 428,
                   ProveedorId = 10,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 429,
                   ProveedorId = 10,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 430,
                   ProveedorId = 10,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 431,
                   ProveedorId = 10,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 432,
                   ProveedorId = 10,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 433,
                   ProveedorId = 10,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 434,
                   ProveedorId = 10,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 435,
                   ProveedorId = 10,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 436,
                   ProveedorId = 10,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 437,
                   ProveedorId = 10,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 438,
                   ProveedorId = 10,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 439,
                   ProveedorId = 10,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 440,
                   ProveedorId = 10,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 441,
                   ProveedorId = 10,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 442,
                   ProveedorId = 10,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 443,
                   ProveedorId = 10,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 444,
                   ProveedorId = 10,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 445,
                   ProveedorId = 10,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 446,
                   ProveedorId = 10,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 447,
                   ProveedorId = 10,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 448,
                   ProveedorId = 10,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 449,
                   ProveedorId = 10,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 450,
                   ProveedorId = 10,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 451,
                   ProveedorId = 11,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 452,
                   ProveedorId = 11,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 453,
                   ProveedorId = 11,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 454,
                   ProveedorId = 11,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 455,
                   ProveedorId = 11,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 456,
                   ProveedorId = 11,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 457,
                   ProveedorId = 11,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 458,
                   ProveedorId = 11,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 459,
                   ProveedorId = 11,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 460,
                   ProveedorId = 11,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 461,
                   ProveedorId = 11,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 462,
                   ProveedorId = 11,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 463,
                   ProveedorId = 11,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 464,
                   ProveedorId = 11,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 465,
                   ProveedorId = 11,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 466,
                   ProveedorId = 11,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 467,
                   ProveedorId = 11,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 468,
                   ProveedorId = 11,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 469,
                   ProveedorId = 11,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 470,
                   ProveedorId = 11,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 471,
                   ProveedorId = 11,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 472,
                   ProveedorId = 11,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 473,
                   ProveedorId = 11,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 474,
                   ProveedorId = 11,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 475,
                   ProveedorId = 11,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 476,
                   ProveedorId = 11,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 477,
                   ProveedorId = 11,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 478,
                   ProveedorId = 11,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 479,
                   ProveedorId = 11,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 480,
                   ProveedorId = 11,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 481,
                   ProveedorId = 11,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 482,
                   ProveedorId = 11,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 483,
                   ProveedorId = 11,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 484,
                   ProveedorId = 11,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 485,
                   ProveedorId = 11,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 486,
                   ProveedorId = 11,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 487,
                   ProveedorId = 11,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 488,
                   ProveedorId = 11,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 489,
                   ProveedorId = 11,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 490,
                   ProveedorId = 11,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 491,
                   ProveedorId = 11,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 492,
                   ProveedorId = 11,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 493,
                   ProveedorId = 11,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 494,
                   ProveedorId = 11,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 495,
                   ProveedorId = 11,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 496,
                   ProveedorId = 12,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 497,
                   ProveedorId = 12,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 498,
                   ProveedorId = 12,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 499,
                   ProveedorId = 12,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 500,
                   ProveedorId = 12,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 501,
                   ProveedorId = 12,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 502,
                   ProveedorId = 12,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 503,
                   ProveedorId = 12,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 504,
                   ProveedorId = 12,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 505,
                   ProveedorId = 12,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 506,
                   ProveedorId = 12,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 507,
                   ProveedorId = 12,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 508,
                   ProveedorId = 12,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 509,
                   ProveedorId = 12,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 510,
                   ProveedorId = 12,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 511,
                   ProveedorId = 12,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 512,
                   ProveedorId = 12,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 513,
                   ProveedorId = 12,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 514,
                   ProveedorId = 12,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 515,
                   ProveedorId = 12,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 516,
                   ProveedorId = 12,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 517,
                   ProveedorId = 12,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 518,
                   ProveedorId = 12,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 519,
                   ProveedorId = 12,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 520,
                   ProveedorId = 12,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 521,
                   ProveedorId = 12,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 522,
                   ProveedorId = 12,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 523,
                   ProveedorId = 12,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 524,
                   ProveedorId = 12,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 525,
                   ProveedorId = 12,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 526,
                   ProveedorId = 12,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 527,
                   ProveedorId = 12,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 528,
                   ProveedorId = 12,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 529,
                   ProveedorId = 12,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 530,
                   ProveedorId = 12,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 531,
                   ProveedorId = 12,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 532,
                   ProveedorId = 12,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 533,
                   ProveedorId = 12,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 534,
                   ProveedorId = 12,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 535,
                   ProveedorId = 12,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 536,
                   ProveedorId = 12,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 537,
                   ProveedorId = 12,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 538,
                   ProveedorId = 12,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 539,
                   ProveedorId = 12,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 540,
                   ProveedorId = 12,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 541,
                   ProveedorId = 13,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 542,
                   ProveedorId = 13,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 543,
                   ProveedorId = 13,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 544,
                   ProveedorId = 13,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 545,
                   ProveedorId = 13,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 546,
                   ProveedorId = 13,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 547,
                   ProveedorId = 13,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 548,
                   ProveedorId = 13,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 549,
                   ProveedorId = 13,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 550,
                   ProveedorId = 13,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 551,
                   ProveedorId = 13,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 552,
                   ProveedorId = 13,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 553,
                   ProveedorId = 13,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 554,
                   ProveedorId = 13,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 555,
                   ProveedorId = 13,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 556,
                   ProveedorId = 13,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 557,
                   ProveedorId = 13,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 558,
                   ProveedorId = 13,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 559,
                   ProveedorId = 13,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 560,
                   ProveedorId = 13,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 561,
                   ProveedorId = 13,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 562,
                   ProveedorId = 13,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 563,
                   ProveedorId = 13,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 564,
                   ProveedorId = 13,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 565,
                   ProveedorId = 13,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 566,
                   ProveedorId = 13,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 567,
                   ProveedorId = 13,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 568,
                   ProveedorId = 13,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 569,
                   ProveedorId = 13,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 570,
                   ProveedorId = 13,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 571,
                   ProveedorId = 13,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 572,
                   ProveedorId = 13,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 573,
                   ProveedorId = 13,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 574,
                   ProveedorId = 13,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 575,
                   ProveedorId = 13,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 576,
                   ProveedorId = 13,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 577,
                   ProveedorId = 13,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 578,
                   ProveedorId = 13,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 579,
                   ProveedorId = 13,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 580,
                   ProveedorId = 13,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 581,
                   ProveedorId = 13,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 582,
                   ProveedorId = 13,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 583,
                   ProveedorId = 13,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 584,
                   ProveedorId = 13,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 585,
                   ProveedorId = 13,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 586,
                   ProveedorId = 14,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 587,
                   ProveedorId = 14,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 588,
                   ProveedorId = 14,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 589,
                   ProveedorId = 14,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 590,
                   ProveedorId = 14,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 591,
                   ProveedorId = 14,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 592,
                   ProveedorId = 14,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 593,
                   ProveedorId = 14,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 594,
                   ProveedorId = 14,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 595,
                   ProveedorId = 14,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 596,
                   ProveedorId = 14,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 597,
                   ProveedorId = 14,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 598,
                   ProveedorId = 14,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 599,
                   ProveedorId = 14,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 600,
                   ProveedorId = 14,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 601,
                   ProveedorId = 14,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 602,
                   ProveedorId = 14,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 603,
                   ProveedorId = 14,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 604,
                   ProveedorId = 14,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 605,
                   ProveedorId = 14,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 606,
                   ProveedorId = 14,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 607,
                   ProveedorId = 14,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 608,
                   ProveedorId = 14,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 609,
                   ProveedorId = 14,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 610,
                   ProveedorId = 14,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 611,
                   ProveedorId = 14,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 612,
                   ProveedorId = 14,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 613,
                   ProveedorId = 14,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 614,
                   ProveedorId = 14,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 615,
                   ProveedorId = 14,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 616,
                   ProveedorId = 14,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 617,
                   ProveedorId = 14,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 618,
                   ProveedorId = 14,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 619,
                   ProveedorId = 14,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 620,
                   ProveedorId = 14,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 621,
                   ProveedorId = 14,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 622,
                   ProveedorId = 14,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 623,
                   ProveedorId = 14,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 624,
                   ProveedorId = 14,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 625,
                   ProveedorId = 14,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 626,
                   ProveedorId = 14,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 627,
                   ProveedorId = 14,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 628,
                   ProveedorId = 14,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 629,
                   ProveedorId = 14,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 630,
                   ProveedorId = 14,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 631,
                   ProveedorId = 15,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 632,
                   ProveedorId = 15,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 633,
                   ProveedorId = 15,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 634,
                   ProveedorId = 15,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 635,
                   ProveedorId = 15,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 636,
                   ProveedorId = 15,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 637,
                   ProveedorId = 15,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 638,
                   ProveedorId = 15,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 639,
                   ProveedorId = 15,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 640,
                   ProveedorId = 15,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 641,
                   ProveedorId = 15,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 642,
                   ProveedorId = 15,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 643,
                   ProveedorId = 15,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 644,
                   ProveedorId = 15,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 645,
                   ProveedorId = 15,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 646,
                   ProveedorId = 15,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 647,
                   ProveedorId = 15,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 648,
                   ProveedorId = 15,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 649,
                   ProveedorId = 15,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 650,
                   ProveedorId = 15,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 651,
                   ProveedorId = 15,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 652,
                   ProveedorId = 15,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 653,
                   ProveedorId = 15,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 654,
                   ProveedorId = 15,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 655,
                   ProveedorId = 15,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 656,
                   ProveedorId = 15,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 657,
                   ProveedorId = 15,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 658,
                   ProveedorId = 15,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 659,
                   ProveedorId = 15,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 660,
                   ProveedorId = 15,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 661,
                   ProveedorId = 15,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 662,
                   ProveedorId = 15,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 663,
                   ProveedorId = 15,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 664,
                   ProveedorId = 15,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 665,
                   ProveedorId = 15,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 666,
                   ProveedorId = 15,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 667,
                   ProveedorId = 15,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 668,
                   ProveedorId = 15,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 669,
                   ProveedorId = 15,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 670,
                   ProveedorId = 15,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 671,
                   ProveedorId = 15,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 672,
                   ProveedorId = 15,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 673,
                   ProveedorId = 15,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 674,
                   ProveedorId = 15,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 675,
                   ProveedorId = 15,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 676,
                   ProveedorId = 16,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 677,
                   ProveedorId = 16,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 678,
                   ProveedorId = 16,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 679,
                   ProveedorId = 16,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 680,
                   ProveedorId = 16,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 681,
                   ProveedorId = 16,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 682,
                   ProveedorId = 16,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 683,
                   ProveedorId = 16,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 684,
                   ProveedorId = 16,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 685,
                   ProveedorId = 16,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 686,
                   ProveedorId = 16,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 687,
                   ProveedorId = 16,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 688,
                   ProveedorId = 16,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 689,
                   ProveedorId = 16,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 690,
                   ProveedorId = 16,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 691,
                   ProveedorId = 16,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 692,
                   ProveedorId = 16,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 693,
                   ProveedorId = 16,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 694,
                   ProveedorId = 16,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 695,
                   ProveedorId = 16,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 696,
                   ProveedorId = 16,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 697,
                   ProveedorId = 16,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 698,
                   ProveedorId = 16,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 699,
                   ProveedorId = 16,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 700,
                   ProveedorId = 16,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 701,
                   ProveedorId = 16,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 702,
                   ProveedorId = 16,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 703,
                   ProveedorId = 16,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 704,
                   ProveedorId = 16,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 705,
                   ProveedorId = 16,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 706,
                   ProveedorId = 16,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 707,
                   ProveedorId = 16,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 708,
                   ProveedorId = 16,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 709,
                   ProveedorId = 16,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 710,
                   ProveedorId = 16,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 711,
                   ProveedorId = 16,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 712,
                   ProveedorId = 16,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 713,
                   ProveedorId = 16,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 714,
                   ProveedorId = 16,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 715,
                   ProveedorId = 16,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 716,
                   ProveedorId = 16,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 717,
                   ProveedorId = 16,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 718,
                   ProveedorId = 16,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 719,
                   ProveedorId = 16,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 720,
                   ProveedorId = 16,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 721,
                   ProveedorId = 17,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 722,
                   ProveedorId = 17,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 723,
                   ProveedorId = 17,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 724,
                   ProveedorId = 17,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 725,
                   ProveedorId = 17,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 726,
                   ProveedorId = 17,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 727,
                   ProveedorId = 17,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 728,
                   ProveedorId = 17,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 729,
                   ProveedorId = 17,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 730,
                   ProveedorId = 17,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 731,
                   ProveedorId = 17,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 732,
                   ProveedorId = 17,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 733,
                   ProveedorId = 17,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 734,
                   ProveedorId = 17,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 735,
                   ProveedorId = 17,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 736,
                   ProveedorId = 17,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 737,
                   ProveedorId = 17,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 738,
                   ProveedorId = 17,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 739,
                   ProveedorId = 17,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 740,
                   ProveedorId = 17,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 741,
                   ProveedorId = 17,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 742,
                   ProveedorId = 17,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 743,
                   ProveedorId = 17,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 744,
                   ProveedorId = 17,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 745,
                   ProveedorId = 17,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 746,
                   ProveedorId = 17,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 747,
                   ProveedorId = 17,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 748,
                   ProveedorId = 17,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 749,
                   ProveedorId = 17,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 750,
                   ProveedorId = 17,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 751,
                   ProveedorId = 17,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 752,
                   ProveedorId = 17,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 753,
                   ProveedorId = 17,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 754,
                   ProveedorId = 17,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 755,
                   ProveedorId = 17,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 756,
                   ProveedorId = 17,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 757,
                   ProveedorId = 17,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 758,
                   ProveedorId = 17,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 759,
                   ProveedorId = 17,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 760,
                   ProveedorId = 17,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 761,
                   ProveedorId = 17,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 762,
                   ProveedorId = 17,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 763,
                   ProveedorId = 17,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 764,
                   ProveedorId = 17,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 765,
                   ProveedorId = 17,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 766,
                   ProveedorId = 18,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 767,
                   ProveedorId = 18,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 768,
                   ProveedorId = 18,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 769,
                   ProveedorId = 18,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 770,
                   ProveedorId = 18,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 771,
                   ProveedorId = 18,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 772,
                   ProveedorId = 18,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 773,
                   ProveedorId = 18,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 774,
                   ProveedorId = 18,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 775,
                   ProveedorId = 18,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 776,
                   ProveedorId = 18,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 777,
                   ProveedorId = 18,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 778,
                   ProveedorId = 18,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 779,
                   ProveedorId = 18,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 800,
                   ProveedorId = 18,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 801,
                   ProveedorId = 18,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 802,
                   ProveedorId = 18,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 803,
                   ProveedorId = 18,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 804,
                   ProveedorId = 18,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 805,
                   ProveedorId = 18,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 806,
                   ProveedorId = 18,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 807,
                   ProveedorId = 18,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 808,
                   ProveedorId = 18,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 809,
                   ProveedorId = 18,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 810,
                   ProveedorId = 18,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 811,
                   ProveedorId = 18,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 812,
                   ProveedorId = 18,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 813,
                   ProveedorId = 18,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 814,
                   ProveedorId = 18,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 815,
                   ProveedorId = 18,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 816,
                   ProveedorId = 18,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 817,
                   ProveedorId = 18,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 818,
                   ProveedorId = 18,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 819,
                   ProveedorId = 18,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 820,
                   ProveedorId = 18,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 821,
                   ProveedorId = 18,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 822,
                   ProveedorId = 18,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 823,
                   ProveedorId = 18,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 824,
                   ProveedorId = 18,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 825,
                   ProveedorId = 18,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 826,
                   ProveedorId = 18,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 827,
                   ProveedorId = 18,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 828,
                   ProveedorId = 18,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 829,
                   ProveedorId = 18,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 830,
                   ProveedorId = 18,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 831,
                   ProveedorId = 19,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 832,
                   ProveedorId = 19,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 833,
                   ProveedorId = 19,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 834,
                   ProveedorId = 19,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 835,
                   ProveedorId = 19,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 836,
                   ProveedorId = 19,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 837,
                   ProveedorId = 19,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 838,
                   ProveedorId = 19,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 839,
                   ProveedorId = 19,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 840,
                   ProveedorId = 19,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 841,
                   ProveedorId = 19,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 842,
                   ProveedorId = 19,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 843,
                   ProveedorId = 19,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 844,
                   ProveedorId = 19,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 845,
                   ProveedorId = 19,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 846,
                   ProveedorId = 19,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 847,
                   ProveedorId = 19,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 848,
                   ProveedorId = 19,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 849,
                   ProveedorId = 19,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 850,
                   ProveedorId = 19,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 851,
                   ProveedorId = 19,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 852,
                   ProveedorId = 19,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 853,
                   ProveedorId = 19,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 854,
                   ProveedorId = 19,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 855,
                   ProveedorId = 19,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 856,
                   ProveedorId = 19,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 857,
                   ProveedorId = 19,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 858,
                   ProveedorId = 19,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 859,
                   ProveedorId = 19,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 860,
                   ProveedorId = 19,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 861,
                   ProveedorId = 19,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 862,
                   ProveedorId = 19,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 863,
                   ProveedorId = 19,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 864,
                   ProveedorId = 19,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 865,
                   ProveedorId = 19,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 866,
                   ProveedorId = 19,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 867,
                   ProveedorId = 19,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 868,
                   ProveedorId = 19,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 869,
                   ProveedorId = 19,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 870,
                   ProveedorId = 19,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 871,
                   ProveedorId = 19,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 872,
                   ProveedorId = 19,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 873,
                   ProveedorId = 19,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 874,
                   ProveedorId = 19,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 875,
                   ProveedorId = 19,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 876,
                   ProveedorId = 20,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 877,
                   ProveedorId = 20,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 878,
                   ProveedorId = 20,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 879,
                   ProveedorId = 20,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 880,
                   ProveedorId = 20,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 881,
                   ProveedorId = 20,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 882,
                   ProveedorId = 20,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 883,
                   ProveedorId = 20,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 884,
                   ProveedorId = 20,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 885,
                   ProveedorId = 20,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 886,
                   ProveedorId = 20,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 887,
                   ProveedorId = 20,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 888,
                   ProveedorId = 20,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 889,
                   ProveedorId = 20,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 890,
                   ProveedorId = 20,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 891,
                   ProveedorId = 20,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 892,
                   ProveedorId = 20,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 893,
                   ProveedorId = 20,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 894,
                   ProveedorId = 20,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 895,
                   ProveedorId = 20,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 896,
                   ProveedorId = 20,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 897,
                   ProveedorId = 20,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 898,
                   ProveedorId = 20,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 899,
                   ProveedorId = 20,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 900,
                   ProveedorId = 20,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 901,
                   ProveedorId = 20,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 902,
                   ProveedorId = 20,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 903,
                   ProveedorId = 20,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 904,
                   ProveedorId = 20,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 905,
                   ProveedorId = 20,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 906,
                   ProveedorId = 20,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 907,
                   ProveedorId = 20,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 908,
                   ProveedorId = 20,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 909,
                   ProveedorId = 20,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 910,
                   ProveedorId = 20,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 911,
                   ProveedorId = 20,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 912,
                   ProveedorId = 20,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 913,
                   ProveedorId = 20,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 914,
                   ProveedorId = 20,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 915,
                   ProveedorId = 20,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 916,
                   ProveedorId = 20,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 917,
                   ProveedorId = 20,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 918,
                   ProveedorId = 20,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 919,
                   ProveedorId = 20,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 920,
                   ProveedorId = 20,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 921,
                   ProveedorId = 21,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 922,
                   ProveedorId = 21,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 923,
                   ProveedorId = 21,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 924,
                   ProveedorId = 21,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 925,
                   ProveedorId = 21,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 926,
                   ProveedorId = 21,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 927,
                   ProveedorId = 21,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 928,
                   ProveedorId = 21,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 929,
                   ProveedorId = 21,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 930,
                   ProveedorId = 21,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 931,
                   ProveedorId = 21,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 932,
                   ProveedorId = 21,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 933,
                   ProveedorId = 21,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 934,
                   ProveedorId = 21,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 935,
                   ProveedorId = 21,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 936,
                   ProveedorId = 21,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 937,
                   ProveedorId = 21,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 938,
                   ProveedorId = 21,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 939,
                   ProveedorId = 21,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 940,
                   ProveedorId = 21,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 941,
                   ProveedorId = 21,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 942,
                   ProveedorId = 21,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 943,
                   ProveedorId = 21,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 944,
                   ProveedorId = 21,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 945,
                   ProveedorId = 21,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 946,
                   ProveedorId = 21,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 947,
                   ProveedorId = 21,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 948,
                   ProveedorId = 21,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 949,
                   ProveedorId = 21,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 950,
                   ProveedorId = 21,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 951,
                   ProveedorId = 21,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 952,
                   ProveedorId = 21,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 953,
                   ProveedorId = 21,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 954,
                   ProveedorId = 21,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 955,
                   ProveedorId = 21,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 956,
                   ProveedorId = 21,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 957,
                   ProveedorId = 21,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 958,
                   ProveedorId = 21,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 959,
                   ProveedorId = 21,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 960,
                   ProveedorId = 21,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 961,
                   ProveedorId = 21,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 962,
                   ProveedorId = 21,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 963,
                   ProveedorId = 21,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 964,
                   ProveedorId = 21,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 965,
                   ProveedorId = 21,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 966,
                   ProveedorId = 22,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 967,
                   ProveedorId = 22,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 968,
                   ProveedorId = 22,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 969,
                   ProveedorId = 22,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 970,
                   ProveedorId = 22,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 971,
                   ProveedorId = 22,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 972,
                   ProveedorId = 22,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 973,
                   ProveedorId = 22,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 974,
                   ProveedorId = 22,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 975,
                   ProveedorId = 22,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 976,
                   ProveedorId = 22,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 977,
                   ProveedorId = 22,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 978,
                   ProveedorId = 22,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 979,
                   ProveedorId = 22,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 980,
                   ProveedorId = 22,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 981,
                   ProveedorId = 22,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 982,
                   ProveedorId = 22,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 983,
                   ProveedorId = 22,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 984,
                   ProveedorId = 22,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 985,
                   ProveedorId = 22,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 986,
                   ProveedorId = 22,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 987,
                   ProveedorId = 22,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 988,
                   ProveedorId = 22,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 989,
                   ProveedorId = 22,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 990,
                   ProveedorId = 22,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 991,
                   ProveedorId = 22,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 992,
                   ProveedorId = 22,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 993,
                   ProveedorId = 22,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 994,
                   ProveedorId = 22,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 995,
                   ProveedorId = 22,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 996,
                   ProveedorId = 22,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 997,
                   ProveedorId = 22,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 998,
                   ProveedorId = 22,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 999,
                   ProveedorId = 22,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1000,
                   ProveedorId = 22,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1001,
                   ProveedorId = 22,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1002,
                   ProveedorId = 22,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1003,
                   ProveedorId = 22,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1004,
                   ProveedorId = 22,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1005,
                   ProveedorId = 22,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1006,
                   ProveedorId = 22,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1007,
                   ProveedorId = 22,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1008,
                   ProveedorId = 22,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1009,
                   ProveedorId = 22,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1010,
                   ProveedorId = 22,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1011,
                   ProveedorId = 23,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1012,
                   ProveedorId = 23,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1013,
                   ProveedorId = 23,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1014,
                   ProveedorId = 23,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1015,
                   ProveedorId = 23,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1016,
                   ProveedorId = 23,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1017,
                   ProveedorId = 23,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1018,
                   ProveedorId = 23,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1019,
                   ProveedorId = 23,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1020,
                   ProveedorId = 23,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1021,
                   ProveedorId = 23,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1022,
                   ProveedorId = 23,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1023,
                   ProveedorId = 23,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1024,
                   ProveedorId = 23,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1025,
                   ProveedorId = 23,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1026,
                   ProveedorId = 23,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1027,
                   ProveedorId = 23,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1028,
                   ProveedorId = 23,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1029,
                   ProveedorId = 23,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1030,
                   ProveedorId = 23,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1031,
                   ProveedorId = 23,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1032,
                   ProveedorId = 23,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1033,
                   ProveedorId = 23,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1034,
                   ProveedorId = 23,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1035,
                   ProveedorId = 23,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1036,
                   ProveedorId = 23,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1037,
                   ProveedorId = 23,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1038,
                   ProveedorId = 23,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1039,
                   ProveedorId = 23,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1040,
                   ProveedorId = 23,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1041,
                   ProveedorId = 23,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1042,
                   ProveedorId = 23,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1043,
                   ProveedorId = 23,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1044,
                   ProveedorId = 23,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1045,
                   ProveedorId = 23,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1046,
                   ProveedorId = 23,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1047,
                   ProveedorId = 23,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1048,
                   ProveedorId = 23,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1049,
                   ProveedorId = 23,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1050,
                   ProveedorId = 23,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1051,
                   ProveedorId = 23,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1052,
                   ProveedorId = 23,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1053,
                   ProveedorId = 23,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1054,
                   ProveedorId = 23,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1055,
                   ProveedorId = 23,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1056,
                   ProveedorId = 24,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1057,
                   ProveedorId = 24,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1058,
                   ProveedorId = 24,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1059,
                   ProveedorId = 24,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1060,
                   ProveedorId = 24,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1061,
                   ProveedorId = 24,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1062,
                   ProveedorId = 24,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1063,
                   ProveedorId = 24,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1064,
                   ProveedorId = 24,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1065,
                   ProveedorId = 24,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1066,
                   ProveedorId = 24,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1067,
                   ProveedorId = 24,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1068,
                   ProveedorId = 24,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1069,
                   ProveedorId = 24,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1070,
                   ProveedorId = 24,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1071,
                   ProveedorId = 24,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1072,
                   ProveedorId = 24,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1073,
                   ProveedorId = 24,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1074,
                   ProveedorId = 24,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1075,
                   ProveedorId = 24,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1076,
                   ProveedorId = 24,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1077,
                   ProveedorId = 24,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1078,
                   ProveedorId = 24,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1079,
                   ProveedorId = 24,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1080,
                   ProveedorId = 24,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1081,
                   ProveedorId = 24,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1082,
                   ProveedorId = 24,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1083,
                   ProveedorId = 24,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1084,
                   ProveedorId = 24,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1085,
                   ProveedorId = 24,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1086,
                   ProveedorId = 24,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1087,
                   ProveedorId = 24,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1088,
                   ProveedorId = 24,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1089,
                   ProveedorId = 24,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1090,
                   ProveedorId = 24,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1091,
                   ProveedorId = 24,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1092,
                   ProveedorId = 24,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1093,
                   ProveedorId = 24,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1094,
                   ProveedorId = 24,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1095,
                   ProveedorId = 24,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1096,
                   ProveedorId = 24,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1097,
                   ProveedorId = 24,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1098,
                   ProveedorId = 24,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1099,
                   ProveedorId = 24,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1100,
                   ProveedorId = 24,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1101,
                   ProveedorId = 25,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1102,
                   ProveedorId = 25,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1103,
                   ProveedorId = 25,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1104,
                   ProveedorId = 25,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1105,
                   ProveedorId = 25,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1106,
                   ProveedorId = 25,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1107,
                   ProveedorId = 25,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1108,
                   ProveedorId = 25,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1109,
                   ProveedorId = 25,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1110,
                   ProveedorId = 25,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1111,
                   ProveedorId = 25,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1112,
                   ProveedorId = 25,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1113,
                   ProveedorId = 25,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1114,
                   ProveedorId = 25,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1115,
                   ProveedorId = 25,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1116,
                   ProveedorId = 25,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1117,
                   ProveedorId = 25,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1118,
                   ProveedorId = 25,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1119,
                   ProveedorId = 25,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1120,
                   ProveedorId = 25,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1121,
                   ProveedorId = 25,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1122,
                   ProveedorId = 25,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1123,
                   ProveedorId = 25,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1124,
                   ProveedorId = 25,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1125,
                   ProveedorId = 25,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1126,
                   ProveedorId = 25,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1127,
                   ProveedorId = 25,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1128,
                   ProveedorId = 25,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1129,
                   ProveedorId = 25,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1130,
                   ProveedorId = 25,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1131,
                   ProveedorId = 25,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1132,
                   ProveedorId = 25,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1133,
                   ProveedorId = 25,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1134,
                   ProveedorId = 25,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1135,
                   ProveedorId = 25,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1136,
                   ProveedorId = 25,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1137,
                   ProveedorId = 25,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1138,
                   ProveedorId = 25,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1139,
                   ProveedorId = 25,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1140,
                   ProveedorId = 25,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1141,
                   ProveedorId = 25,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1142,
                   ProveedorId = 25,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1143,
                   ProveedorId = 25,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1144,
                   ProveedorId = 25,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1145,
                   ProveedorId = 25,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1146,
                   ProveedorId = 26,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1147,
                   ProveedorId = 26,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1148,
                   ProveedorId = 26,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1149,
                   ProveedorId = 26,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1150,
                   ProveedorId = 26,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1151,
                   ProveedorId = 26,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1152,
                   ProveedorId = 26,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1153,
                   ProveedorId = 26,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1154,
                   ProveedorId = 26,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1155,
                   ProveedorId = 26,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1156,
                   ProveedorId = 26,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1157,
                   ProveedorId = 26,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1158,
                   ProveedorId = 26,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1159,
                   ProveedorId = 26,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1160,
                   ProveedorId = 26,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1161,
                   ProveedorId = 26,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1162,
                   ProveedorId = 26,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1163,
                   ProveedorId = 26,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1164,
                   ProveedorId = 26,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1165,
                   ProveedorId = 26,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1166,
                   ProveedorId = 26,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1167,
                   ProveedorId = 26,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1168,
                   ProveedorId = 26,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1169,
                   ProveedorId = 26,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1170,
                   ProveedorId = 26,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1171,
                   ProveedorId = 26,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1172,
                   ProveedorId = 26,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1173,
                   ProveedorId = 26,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1174,
                   ProveedorId = 26,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1175,
                   ProveedorId = 26,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1176,
                   ProveedorId = 26,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1177,
                   ProveedorId = 26,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1178,
                   ProveedorId = 26,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1179,
                   ProveedorId = 26,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1180,
                   ProveedorId = 26,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1181,
                   ProveedorId = 26,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1182,
                   ProveedorId = 26,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1183,
                   ProveedorId = 26,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1184,
                   ProveedorId = 26,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1185,
                   ProveedorId = 26,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1186,
                   ProveedorId = 26,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1187,
                   ProveedorId = 26,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1188,
                   ProveedorId = 26,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1189,
                   ProveedorId = 26,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1190,
                   ProveedorId = 26,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1191,
                   ProveedorId = 27,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1192,
                   ProveedorId = 27,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1193,
                   ProveedorId = 27,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1194,
                   ProveedorId = 27,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1195,
                   ProveedorId = 27,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1196,
                   ProveedorId = 27,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1197,
                   ProveedorId = 27,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1198,
                   ProveedorId = 27,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1199,
                   ProveedorId = 27,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1200,
                   ProveedorId = 27,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1201,
                   ProveedorId = 27,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1202,
                   ProveedorId = 27,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1203,
                   ProveedorId = 27,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1204,
                   ProveedorId = 27,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1205,
                   ProveedorId = 27,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1206,
                   ProveedorId = 27,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1207,
                   ProveedorId = 27,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1208,
                   ProveedorId = 27,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1209,
                   ProveedorId = 27,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1210,
                   ProveedorId = 27,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1211,
                   ProveedorId = 27,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1212,
                   ProveedorId = 27,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1213,
                   ProveedorId = 27,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1214,
                   ProveedorId = 27,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1215,
                   ProveedorId = 27,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1216,
                   ProveedorId = 27,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1217,
                   ProveedorId = 27,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1218,
                   ProveedorId = 27,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1219,
                   ProveedorId = 27,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1220,
                   ProveedorId = 27,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1221,
                   ProveedorId = 27,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1222,
                   ProveedorId = 27,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1223,
                   ProveedorId = 27,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1224,
                   ProveedorId = 27,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1225,
                   ProveedorId = 27,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1226,
                   ProveedorId = 27,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1227,
                   ProveedorId = 27,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1228,
                   ProveedorId = 27,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1229,
                   ProveedorId = 27,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1230,
                   ProveedorId = 27,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1231,
                   ProveedorId = 27,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1232,
                   ProveedorId = 27,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1233,
                   ProveedorId = 27,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1234,
                   ProveedorId = 27,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1235,
                   ProveedorId = 27,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1236,
                   ProveedorId = 28,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1237,
                   ProveedorId = 28,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1238,
                   ProveedorId = 28,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1239,
                   ProveedorId = 28,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1240,
                   ProveedorId = 28,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1241,
                   ProveedorId = 28,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1242,
                   ProveedorId = 28,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1243,
                   ProveedorId = 28,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1244,
                   ProveedorId = 28,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1245,
                   ProveedorId = 28,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1246,
                   ProveedorId = 28,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1247,
                   ProveedorId = 28,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1248,
                   ProveedorId = 28,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1249,
                   ProveedorId = 28,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1250,
                   ProveedorId = 28,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1251,
                   ProveedorId = 28,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1252,
                   ProveedorId = 28,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1253,
                   ProveedorId = 28,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1254,
                   ProveedorId = 28,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1255,
                   ProveedorId = 28,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1256,
                   ProveedorId = 28,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1257,
                   ProveedorId = 28,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1258,
                   ProveedorId = 28,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1259,
                   ProveedorId = 28,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1260,
                   ProveedorId = 28,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1261,
                   ProveedorId = 28,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1262,
                   ProveedorId = 28,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1263,
                   ProveedorId = 28,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1264,
                   ProveedorId = 28,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1265,
                   ProveedorId = 28,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1266,
                   ProveedorId = 28,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1267,
                   ProveedorId = 28,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1268,
                   ProveedorId = 28,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1269,
                   ProveedorId = 28,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1270,
                   ProveedorId = 28,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1271,
                   ProveedorId = 28,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1272,
                   ProveedorId = 28,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1273,
                   ProveedorId = 28,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1274,
                   ProveedorId = 28,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1275,
                   ProveedorId = 28,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1276,
                   ProveedorId = 28,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1277,
                   ProveedorId = 28,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1278,
                   ProveedorId = 28,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1279,
                   ProveedorId = 28,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1280,
                   ProveedorId = 28,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1281,
                   ProveedorId = 29,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1282,
                   ProveedorId = 29,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1283,
                   ProveedorId = 29,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1284,
                   ProveedorId = 29,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1285,
                   ProveedorId = 29,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1286,
                   ProveedorId = 29,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1287,
                   ProveedorId = 29,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1288,
                   ProveedorId = 29,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1289,
                   ProveedorId = 29,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1290,
                   ProveedorId = 29,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1291,
                   ProveedorId = 29,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1292,
                   ProveedorId = 29,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1293,
                   ProveedorId = 29,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1294,
                   ProveedorId = 29,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1295,
                   ProveedorId = 29,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1296,
                   ProveedorId = 29,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1297,
                   ProveedorId = 29,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1298,
                   ProveedorId = 29,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1299,
                   ProveedorId = 29,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1300,
                   ProveedorId = 29,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1301,
                   ProveedorId = 29,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1302,
                   ProveedorId = 29,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1303,
                   ProveedorId = 29,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1304,
                   ProveedorId = 29,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1305,
                   ProveedorId = 29,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1306,
                   ProveedorId = 29,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1307,
                   ProveedorId = 29,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1308,
                   ProveedorId = 29,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1309,
                   ProveedorId = 29,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1310,
                   ProveedorId = 29,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1311,
                   ProveedorId = 29,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1312,
                   ProveedorId = 29,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1313,
                   ProveedorId = 29,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1314,
                   ProveedorId = 29,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1315,
                   ProveedorId = 29,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1316,
                   ProveedorId = 29,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1317,
                   ProveedorId = 29,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1318,
                   ProveedorId = 29,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1319,
                   ProveedorId = 29,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1320,
                   ProveedorId = 29,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1321,
                   ProveedorId = 29,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1322,
                   ProveedorId = 29,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1323,
                   ProveedorId = 29,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1324,
                   ProveedorId = 29,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1325,
                   ProveedorId = 29,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               },
               new ProveedorInsumo
               {
                   Id = 1326,
                   ProveedorId = 30,
                   InsumoId = 1,
                   Precio = (decimal)0.30
               },
               new ProveedorInsumo
               {
                   Id = 1327,
                   ProveedorId = 30,
                   InsumoId = 2,
                   Precio = (decimal)0.25
               },
               new ProveedorInsumo
               {
                   Id = 1328,
                   ProveedorId = 30,
                   InsumoId = 3,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1329,
                   ProveedorId = 30,
                   InsumoId = 4,
                   Precio = (decimal)3.40
               },
               new ProveedorInsumo
               {
                   Id = 1330,
                   ProveedorId = 30,
                   InsumoId = 5,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1331,
                   ProveedorId = 30,
                   InsumoId = 6,
                   Precio = (decimal)3.30
               },
               new ProveedorInsumo
               {
                   Id = 1332,
                   ProveedorId = 30,
                   InsumoId = 7,
                   Precio = (decimal)1.45
               },
               new ProveedorInsumo
               {
                   Id = 1333,
                   ProveedorId = 30,
                   InsumoId = 8,
                   Precio = (decimal)1.10
               },
               new ProveedorInsumo
               {
                   Id = 1334,
                   ProveedorId = 30,
                   InsumoId = 9,
                   Precio = (decimal)3.25
               },
               new ProveedorInsumo
               {
                   Id = 1335,
                   ProveedorId = 30,
                   InsumoId = 10,
                   Precio = (decimal)1.62
               },
               new ProveedorInsumo
               {
                   Id = 1336,
                   ProveedorId = 30,
                   InsumoId = 11,
                   Precio = (decimal)2.11
               },
               new ProveedorInsumo
               {
                   Id = 1337,
                   ProveedorId = 30,
                   InsumoId = 12,
                   Precio = (decimal)2.75
               },
               new ProveedorInsumo
               {
                   Id = 1338,
                   ProveedorId = 30,
                   InsumoId = 13,
                   Precio = (decimal)2.68
               },
               new ProveedorInsumo
               {
                   Id = 1339,
                   ProveedorId = 30,
                   InsumoId = 14,
                   Precio = (decimal)2.94
               },
               new ProveedorInsumo
               {
                   Id = 1340,
                   ProveedorId = 30,
                   InsumoId = 15,
                   Precio = (decimal)0.48
               },
               new ProveedorInsumo
               {
                   Id = 1341,
                   ProveedorId = 30,
                   InsumoId = 16,
                   Precio = (decimal)0.53
               },
               new ProveedorInsumo
               {
                   Id = 1342,
                   ProveedorId = 30,
                   InsumoId = 17,
                   Precio = (decimal)0.50
               },
               new ProveedorInsumo
               {
                   Id = 1343,
                   ProveedorId = 30,
                   InsumoId = 18,
                   Precio = (decimal)1.05
               },
               new ProveedorInsumo
               {
                   Id = 1344,
                   ProveedorId = 30,
                   InsumoId = 19,
                   Precio = (decimal)0.95
               },
               new ProveedorInsumo
               {
                   Id = 1345,
                   ProveedorId = 30,
                   InsumoId = 20,
                   Precio = (decimal)345.80
               },
               new ProveedorInsumo
               {
                   Id = 1346,
                   ProveedorId = 30,
                   InsumoId = 21,
                   Precio = (decimal)532.58
               },
               new ProveedorInsumo
               {
                   Id = 1347,
                   ProveedorId = 30,
                   InsumoId = 22,
                   Precio = (decimal)1275.85
               },
               new ProveedorInsumo
               {
                   Id = 1348,
                   ProveedorId = 30,
                   InsumoId = 23,
                   Precio = (decimal)1.69
               },
               new ProveedorInsumo
               {
                   Id = 1349,
                   ProveedorId = 30,
                   InsumoId = 24,
                   Precio = (decimal)0.05
               },
               new ProveedorInsumo
               {
                   Id = 1350,
                   ProveedorId = 30,
                   InsumoId = 25,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1351,
                   ProveedorId = 30,
                   InsumoId = 26,
                   Precio = (decimal)0.10
               },
               new ProveedorInsumo
               {
                   Id = 1352,
                   ProveedorId = 30,
                   InsumoId = 27,
                   Precio = (decimal)1.55
               },
               new ProveedorInsumo
               {
                   Id = 1353,
                   ProveedorId = 30,
                   InsumoId = 28,
                   Precio = (decimal)9.28
               },
               new ProveedorInsumo
               {
                   Id = 1354,
                   ProveedorId = 30,
                   InsumoId = 29,
                   Precio = (decimal)5.26
               },
               new ProveedorInsumo
               {
                   Id = 1355,
                   ProveedorId = 30,
                   InsumoId = 30,
                   Precio = (decimal)2.45
               },
               new ProveedorInsumo
               {
                   Id = 1356,
                   ProveedorId = 30,
                   InsumoId = 31,
                   Precio = (decimal)2.10
               },
               new ProveedorInsumo
               {
                   Id = 1357,
                   ProveedorId = 30,
                   InsumoId = 32,
                   Precio = (decimal)55.00
               },
               new ProveedorInsumo
               {
                   Id = 1358,
                   ProveedorId = 30,
                   InsumoId = 33,
                   Precio = (decimal)15.00
               },
               new ProveedorInsumo
               {
                   Id = 1359,
                   ProveedorId = 30,
                   InsumoId = 34,
                   Precio = (decimal)25.00
               },
               new ProveedorInsumo
               {
                   Id = 1360,
                   ProveedorId = 30,
                   InsumoId = 35,
                   Precio = (decimal)1.47
               },
               new ProveedorInsumo
               {
                   Id = 1361,
                   ProveedorId = 30,
                   InsumoId = 36,
                   Precio = (decimal)1.24
               },
               new ProveedorInsumo
               {
                   Id = 1362,
                   ProveedorId = 30,
                   InsumoId = 37,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1363,
                   ProveedorId = 30,
                   InsumoId = 38,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1364,
                   ProveedorId = 30,
                   InsumoId = 39,
                   Precio = (decimal)0.45
               },
               new ProveedorInsumo
               {
                   Id = 1365,
                   ProveedorId = 30,
                   InsumoId = 40,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1366,
                   ProveedorId = 30,
                   InsumoId = 41,
                   Precio = (decimal)4.75
               },
               new ProveedorInsumo
               {
                   Id = 1367,
                   ProveedorId = 30,
                   InsumoId = 42,
                   Precio = (decimal)9.83
               },
               new ProveedorInsumo
               {
                   Id = 1368,
                   ProveedorId = 30,
                   InsumoId = 43,
                   Precio = (decimal)8.75
               },
               new ProveedorInsumo
               {
                   Id = 1369,
                   ProveedorId = 30,
                   InsumoId = 44,
                   Precio = (decimal)7.92
               },
               new ProveedorInsumo
               {
                   Id = 1370,
                   ProveedorId = 30,
                   InsumoId = 45,
                   Precio = (decimal)1.50
               }
            );
        }
    }
}
