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

    public static readonly SalesDelegate[] Delegates =
    [
        // EUROPA
        new(1, "Alejandro García", 1),
        new(2, "Daniel Rodríguez", 2),
        new(3, "Pablo González", 3),
        new(4, "Manuel Fernández", 4),
        new(5, "Álvaro López", 5),
        new(6, "David Martínez", 6),
        new(7, "Javier Sánchez", 7),

        // ASIA
        new(8, "Sergio Pérez", 8),
        new(9, "Carlos Gómez", 9),
        new(10, "Adrián Martín", 10),
        new(11, "Diego Jiménez", 11),
        new(12, "Mario Ruiz", 12),

        // AMÉRICA DEL NORTE
        new(13, "Hugo Hernández", 13),
        new(14, "Lucas Díaz", 14),
        new(15, "Marcos Moreno", 15),

        // AMÉRICA DEL SUR
        new(16, "Antonio Álvarez", 16),
        new(17, "Miguel Muñoz", 17),
        new(18, "José Romero", 18),
        new(19, "Fernando Alonso", 19),
        new(20, "Raúl Gutiérrez", 20),

        // OCEANÍA
        new(21, "Rubén Navarro", 21),
        new(22, "Iván Torres", 22)
    ];
}