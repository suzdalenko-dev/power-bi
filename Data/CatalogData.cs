using bi.Models;
namespace bi.Data;

public static class CatalogData
{
    public static readonly Market[] Markets =
    [
        new(1, "Europa"),
        new(2, "Asia"),
        new(3, "América del Norte"),
        new(4, "América del Sur"),
        new(5, "Oceanía")
    ];

    public static readonly Country[] Countries =
    [
        // EUROPA
        new(1, "España", 1),
        new(2, "Francia", 1),
        new(3, "Alemania", 1),
        new(4, "Italia", 1),
        new(5, "Portugal", 1),
        new(6, "Países Bajos", 1),
        new(7, "Reino Unido", 1),
    
        // ASIA
        new(8, "Japón", 2),
        new(9, "China", 2),
        new(10, "India", 2),
        new(11, "Corea del Sur", 2),
        new(12, "Singapur", 2),
    
        // AMÉRICA DEL NORTE
        new(13, "Estados Unidos", 3),
        new(14, "Canadá", 3),
        new(15, "México", 3),
    
        // AMÉRICA DEL SUR
        new(16, "Brasil", 4),
        new(17, "Argentina", 4),
        new(18, "Chile", 4),
        new(19, "Colombia", 4),
        new(20, "Perú", 4),
    
        // OCEANÍA
        new(21, "Australia", 5),
        new(22, "Nueva Zelanda", 5),
        new(23, "Fiyi", 5)
    ];
}