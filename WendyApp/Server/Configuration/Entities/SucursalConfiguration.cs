using WendyApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WendyApp.Server.Configuration.Entities
{
    public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
    {
        public void Configure(EntityTypeBuilder<Sucursal> builder)
        {
            builder.HasData(
                new Sucursal
                {
                    SucursalId = 1,
                    Nombre = "Sucursal Metrocentro",
                    Direccion = "Metrocentro 8va etapa, El Salvador",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 1
                },
                new Sucursal
                {
                    SucursalId = 2,
                    Nombre = "Sucursal Galerías",
                    Direccion = "CC Galerías, paseo Gral Escalón, El Salvador",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 1
                },
                new Sucursal
                {
                    SucursalId = 3,
                    Nombre = "Sucursal Multiplaza",
                    Direccion = "Antiguo Cuscatlán - La Libertad, El Salvador",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 1
                },
                new Sucursal
                {
                    SucursalId = 4,
                    Nombre = "Sucursal Naranjo Mall",
                    Direccion = "Calle 23 10-00 zona 4 de Mixco Condado Naranjo, Guatemala",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 2
                },
                new Sucursal
                {
                    SucursalId = 5,
                    Nombre = "Sucursal FontaBella",
                    Direccion = "Zona Viva, cuarta avenida 12-44, Guatemala",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 2
                },
                new Sucursal
                {
                    SucursalId = 6,
                    Nombre = "Sucursal Oakland",
                    Direccion = "Diagonal 6 13-01, Guatemala",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 2
                },
                new Sucursal
                {
                    SucursalId = 7,
                    Nombre = "Sucursal Los Próceres",
                    Direccion = "Zona 10, calle 16 2.00, Guatemala",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 2
                },
                new Sucursal
                {
                    SucursalId = 8,
                    Nombre = "Sucursal Multiplaza Escazú",
                    Direccion = "Autop. Próspero Fernández, San José, Escazú, Costa Rica",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 3
                },
                new Sucursal
                {
                    SucursalId = 9,
                    Nombre = "Sucursal Lincoln Plaza",
                    Direccion = "C. 55, Florencia, San José, San Vicente, Costa Rica",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 3
                },
                new Sucursal
                {
                    SucursalId = 10,
                    Nombre = "Sucursal Terrazas Lindora",
                    Direccion = "diagonal a Forum, Radial Sta. Ana - San Rafael - Belén 2 Lindora, San José, Pozos, Costa Rica",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 3
                },
                new Sucursal
                {
                    SucursalId = 11,
                    Nombre = "Sucursal Multiplaza Curridabat",
                    Direccion = "El Hogar, San José, Curridabat, 11801, Costa Rica",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 3
                },
                new Sucursal
                {
                    SucursalId = 12,
                    Nombre = "Sucursal Village Mall",
                    Direccion = "Rio de Janeiro, Brasil",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 4
                },
                new Sucursal
                {
                    SucursalId = 13,
                    Nombre = "Sucursal Cidade Jardim",
                    Direccion = "Sao Paulo, Brasil",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 4
                },
                new Sucursal
                {
                    SucursalId = 14,
                    Nombre = "Sucursal Centro Santa Fe",
                    Direccion = "Ciudad de Mexico, México",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 5
                },
                new Sucursal
                {
                    SucursalId = 15,
                    Nombre = "Sucursal Plaza Universidad",
                    Direccion = "Benito Juárez - México DF, México",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 5
                },
                new Sucursal
                {
                    SucursalId = 16,
                    Nombre = "Sucursal Paseo Interlomas",
                    Direccion = "Interlomas - Huixquilucan, México",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 5
                },
                new Sucursal
                {
                    SucursalId = 17,
                    Nombre = "Sucursal Unicenter",
                    Direccion = "Buenos Aires, Argentina",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 6
                },
                new Sucursal
                {
                    SucursalId = 18,
                    Nombre = "Sucursal Alto Palermo",
                    Direccion = "Palermo - Buenos Aires, Argentina",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 6
                },
                new Sucursal
                {
                    SucursalId = 19,
                    Nombre = "Sucursal Plaza Oeste",
                    Direccion = "Castelar - Morón - Buenos Aires, Argentina",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 6
                },
                new Sucursal
                {
                    SucursalId = 20,
                    Nombre = "Sucursal Soleil Factory",
                    Direccion = "Boulogne - Buenos Aires, Argentina",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 6
                },
                new Sucursal
                {
                    SucursalId = 21,
                    Nombre = "Sucursal Portal Rosario",
                    Direccion = "Rosario, Argentina",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 6
                },
                new Sucursal
                {
                    SucursalId = 22,
                    Nombre = "Sucursal Centro Sambil",
                    Direccion = "Caracas, Venezuela",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 7
                },
                new Sucursal
                {
                    SucursalId = 23,
                    Nombre = "Sucursal Matrópolis Valencia",
                    Direccion = "Valencia, Venezuela",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 7
                },
                new Sucursal
                {
                    SucursalId = 24,
                    Nombre = "Sucursal Plaza Las Américas",
                    Direccion = "San Juán, Puerto Rico",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 8
                },
                new Sucursal
                {
                    SucursalId = 25,
                    Nombre = "Sucursal The Mall of San Juan",
                    Direccion = "San Juan, Puerto Rico",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 8
                },
                new Sucursal
                {
                    SucursalId = 26,
                    Nombre = "Sucursal San Patricio Plaza",
                    Direccion = "Guaynabo, Puerto Rico",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 8
                },
                new Sucursal
                {
                    SucursalId = 27,
                    Nombre = "Sucursal Alto Las Condes",
                    Direccion = "Las condes - RM Santiago, Chile",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 9
                },
                new Sucursal
                {
                    SucursalId = 28,
                    Nombre = "Sucursal Mall Plaza Trébol",
                    Direccion = "Talcahuano - AM Concepción, Chile",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 9
                },
                new Sucursal
                {
                    SucursalId = 29,
                    Nombre = "Sucursal Unicentroi Bogotá",
                    Direccion = "Bogotá, Colombia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 10
                },
                new Sucursal
                {
                    SucursalId = 30,
                    Nombre = "Sucursal El Tesoro",
                    Direccion = "Medellín, Colombia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 10
                },
                new Sucursal
                {
                    SucursalId = 31,
                    Nombre = "Sucursal AltaPlaza Mall",
                    Direccion = "Vía Centenario, Panamá",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 11
                },
                new Sucursal
                {
                    SucursalId = 32,
                    Nombre = "Sucursal Albrook Mall",
                    Direccion = "XCCW+5R6, Marginal, Avenida Roosevelt, Panamá",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 11
                },
                new Sucursal
                {
                    SucursalId = 33,
                    Nombre = "Sucursal Multiplaza Panamá",
                    Direccion = "Vía Israel, Panamá",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 11
                },
                new Sucursal
                {
                    SucursalId = 34,
                    Nombre = "Sucursal Nuevocentro Shopping",
                    Direccion = "v. Luis Alberto de Herrera 3365, 11600 Montevideo, Departamento de Montevideo, Uruguay",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 12
                },
                new Sucursal
                {
                    SucursalId = 35,
                    Nombre = "Sucursal Almenara Mall",
                    Direccion = "Ruta Gral. Líber Seregni km22.5, 15000 Ciudad de la Costa, Departamento de Canelones, Uruguay",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 12
                },
                new Sucursal
                {
                    SucursalId = 36,
                    Nombre = "Sucursal Quicentro Shopping",
                    Direccion = "Avenida Naciones Unidas entre, Av. 6 de Diciembre, Quito, Ecuador",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 13
                },
                new Sucursal
                {
                    SucursalId = 37,
                    Nombre = "Sucursal Mall del Sol",
                    Direccion = "4º Pasaje 1 NE, Guayaquil 090513, Ecuador",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 13
                },
                new Sucursal
                {
                    SucursalId = 38,
                    Nombre = "Sucursal Jockey Plaza",
                    Direccion = "Santiago de Surco - Lima, Perú",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 14
                },
                new Sucursal
                {
                    SucursalId = 39,
                    Nombre = "Sucursal Plaza San Miguel",
                    Direccion = "San Miguel - Lima, Perú",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 14
                },
                new Sucursal
                {
                    SucursalId = 40,
                    Nombre = "Sucursal Paseo La Galería",
                    Direccion = "Av. Sta. Teresa 1827, Asunción, Paraguay",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 15
                },
                new Sucursal
                {
                    SucursalId = 41,
                    Nombre = "Sucursal Shopping Paris",
                    Direccion = "F9PV+PG6, Avenida Doctor Luis Maria Argaña, Cd. del Este, Paraguay",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 15
                },
                new Sucursal
                {
                    SucursalId = 42,
                    Nombre = "Sucursal Sambil Santo Domingo",
                    Direccion = "Corner of, P.º de los Aviadores, Santo Domingo 10413, República Dominicana",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 16
                },
                new Sucursal
                {
                    SucursalId = 43,
                    Nombre = "Sucursal BlueMall Puntacana",
                    Direccion = "esquina Carretera de Juanillo, Blvd. Turístico del Este, Punta Cana 23000, República Dominicana",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 16
                },
                new Sucursal
                {
                    SucursalId = 44,
                    Nombre = "Sucursal City Mall",
                    Direccion = "1Calle ,Frente A Farmacia Kielsa ,Carretera a San Pedro SULA, Tegucigalpa, Honduras",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 17
                },
                new Sucursal
                {
                    SucursalId = 45,
                    Nombre = "Sucursal Multicentro Las Américas",
                    Direccion = "Semaforos de Villa Progreso 1 cuadra al Oeste, Nicaragua",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 18
                },
                new Sucursal
                {
                    SucursalId = 46,
                    Nombre = "Sucursal Centro Comercial Parquesur",
                    Direccion = "Av. de Gran Bretaña, s/n, 28916 Leganés, Madrid, España",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 19
                },
                new Sucursal
                {
                    SucursalId = 47,
                    Nombre = "Sucursal Centro Comercial Parque Corredor",
                    Direccion = "Ctra. Ajalvir Centro Comerci, s/n, 28850 Torrejón de Ardoz, Madrid, España",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 19
                },
                new Sucursal
                {
                    SucursalId = 48,
                    Nombre = "Sucursal Evropeysky",
                    Direccion = "Kiyevsky Station Square, 2, Moscow, Rusia, 121059",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 20
                },
                new Sucursal
                {
                    SucursalId = 49,
                    Nombre = "Sucursal Outlet Village Belaya Dacha",
                    Direccion = "Novoryazanskoye Shosse, 8, Kotelniki, Moscow Oblast, Rusia, 140053",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 20
                },
                new Sucursal
                {
                    SucursalId = 50,
                    Nombre = "Sucursal Westfield Shopping City Süd",
                    Direccion = "Vösendorfer Südring, 2334 Vösendorf, Austria",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 21
                },
                new Sucursal
                {
                    SucursalId = 51,
                    Nombre = "Sucursal DEZ Innsbruck",
                    Direccion = "Amraser-See-Straße 56a, 6020 Innsbruck, Austria",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 21
                },
                new Sucursal
                {
                    SucursalId = 52,
                    Nombre = "Sucursal Mall of Scandinaviaultiplaza Curridabat",
                    Direccion = "Stjärntorget 13 C, 169 79 Solna, Suecia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 22
                },
                new Sucursal
                {
                    SucursalId = 53,
                    Nombre = "Sucursal Centro de Täby",
                    Direccion = "Stora Marknadsvägen 15, 183 70 Täby, Suecia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 22
                },
                new Sucursal
                {
                    SucursalId = 54,
                    Nombre = "Sucursal Les Quatre Temps",
                    Direccion = "15 Parvis De La Défense, 92092 Puteaux, Francia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 23
                },
                new Sucursal
                {
                    SucursalId = 55,
                    Nombre = "Sucursal Blagnac",
                    Direccion = "2 All. Emile Zola, 31700 Blagnac, Francia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 23
                },
                new Sucursal
                {
                    SucursalId = 56,
                    Nombre = "Sucursal Vasco da Gama",
                    Direccion = "Av. Dom João II 40, 1990-094 Lisboa, Portugal",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 24
                },
                new Sucursal
                {
                    SucursalId = 57,
                    Nombre = "Sucursal Dolce Vita Tejo",
                    Direccion = "Av. Cruzeiro Seixas 5 e 7, 2650-505 Amadora, Portugal",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 24
                },
                new Sucursal
                {
                    SucursalId = 58,
                    Nombre = "Sucursal The Brunswick Center",
                    Direccion = "Bernard St, London WC1N 1BS, Reino Unido",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 25
                },
                new Sucursal
                {
                    SucursalId = 59,
                    Nombre = "Sucursal Coral Drops Yard",
                    Direccion = "Stable St, London N1C 4DQ, Reino Unido",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 25
                },
                new Sucursal
                {
                    SucursalId = 60,
                    Nombre = "Sucursal Stephen's Green",
                    Direccion = "St Stephen's Green, Dublin, D02 HX65, Irlanda",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 26
                },
                new Sucursal
                {
                    SucursalId = 61,
                    Nombre = "Sucursal Talbot Mall",
                    Direccion = "1 Talbot St, North City, Dublin, D01 XW65, Irlanda",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 26
                },
                new Sucursal
                {
                    SucursalId = 62,
                    Nombre = "Sucursal Ruhr Park",
                    Direccion = "Am Einkaufszentrum 1, 44791 Bochum, Alemania",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 27
                },
                new Sucursal
                {
                    SucursalId = 63,
                    Nombre = "Sucursal Columbus Center",
                    Direccion = "Ob. Bürger 127, 27568 Bremerhaven, Alemania",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 27
                },
                new Sucursal
                {
                    SucursalId = 64,
                    Nombre = "Sucursal Il Centro",
                    Direccion = "Via Giuseppe Eugenio Luraghi, 11, 20044 Arese MI, Italia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 28
                },
                new Sucursal
                {
                    SucursalId = 65,
                    Nombre = "Sucursal La Fiumara",
                    Direccion = "Via alla Fiumara, 15/16, 16149 Genova GE, Italia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 28
                },
                new Sucursal
                {
                    SucursalId = 66,
                    Nombre = "Sucursal Talos Plaza",
                    Direccion = "Sofikli Venizelou, Minoos & Pelasgon Σοφοκλή Bενιζέλου, Μίνωος &, Pelasgon, Iraklio 713 03, Grecia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 29
                },
                new Sucursal
                {
                    SucursalId = 67,
                    Nombre = "Sucursal 3Quarters",
                    Direccion = "Agiou Dimitriou 19, Athina 105 54, Grecia",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 29
                },
                new Sucursal
                {
                    SucursalId = 68,
                    Nombre = "Sucursal Docks Bruxsel",
                    Direccion = "Bd Lambermont 1, 1000 Bruxelles, Bélgica",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 30
                },
                new Sucursal
                {
                    SucursalId = 69,
                    Nombre = "Sucursal L'esplanade",
                    Direccion = "Pl. de l'Accueil 10, 1348 Ottignies-Louvain-la-Neuve, Bélgica",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 30
                }
            );
        }
    }
}
