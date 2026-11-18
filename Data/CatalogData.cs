using bi.Models;
namespace bi.Data;

public static class CatalogData
{
    public static readonly Market[] Markets =
    [
        // EUROPA (MarketId = 1)
        new(1, "España", 1),
        new(2, "Francia", 1),
        new(3, "Alemania", 1),
        new(4, "Italia", 1),
        new(5, "Portugal", 1),
        new(6, "Países Bajos", 1),
        new(7, "Reino Unido", 1),

        // ASIA (MarketId = 2)
        new(8, "Japón", 2),
        new(9, "China", 2),
        new(10, "India", 2),
        new(11, "Corea del Sur", 2),
        new(12, "Singapur", 2),

        // AMÉRICA DEL NORTE (MarketId = 3)
        new(13, "Estados Unidos", 3),
        new(14, "Canadá", 3),
        new(15, "México", 3),

        // AMÉRICA DEL SUR (MarketId = 4)
        new(16, "Brasil", 4),
        new(17, "Argentina", 4),
        new(18, "Chile", 4),
        new(19, "Colombia", 4),
        new(20, "Perú", 4),

        // OCEANÍA (MarketId = 5)
        new(21, "Australia", 5),
        new(22, "Nueva Zelanda", 5),
        new(23, "Fiyi", 5)
    ];
}