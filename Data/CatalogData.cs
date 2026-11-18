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


    public static readonly Article[] Articles =
    [
    // ==================================================
    // CARNE (22)
    // ==================================================
    new("A001", "CARNE", "POLLO ENTERO", 2.85m, 4.49m),
    new("A002", "CARNE", "PECHUGA DE POLLO", 5.40m, 8.95m),
    new("A003", "CARNE", "ALITAS DE POLLO", 2.60m, 4.25m),
    new("A004", "CARNE", "MUSLOS DE POLLO", 3.10m, 5.20m),
    new("A005", "CARNE", "CONTRAMUSLOS DE POLLO", 3.45m, 5.75m),
    new("A006", "CARNE", "PAVO ENTERO", 4.80m, 7.90m),
    new("A007", "CARNE", "PECHUGA DE PAVO", 6.50m, 10.50m),
    new("A008", "CARNE", "LOMO DE CERDO", 5.20m, 8.49m),
    new("A009", "CARNE", "COSTILLA DE CERDO", 4.30m, 7.20m),
    new("A010", "CARNE", "PALETA DE CERDO", 4.10m, 6.90m),
    new("A011", "CARNE", "SECRETO DE CERDO", 8.90m, 14.50m),
    new("A012", "CARNE", "SOLOMILLO DE CERDO", 7.50m, 12.20m),
    new("A013", "CARNE", "CARNE PICADA DE CERDO", 4.60m, 7.50m),
    new("A014", "CARNE", "TERNERA PARA GUISAR", 8.20m, 13.50m),
    new("A015", "CARNE", "FILETE DE TERNERA", 10.50m, 17.90m),
    new("A016", "CARNE", "SOLOMILLO DE TERNERA", 22.00m, 34.90m),
    new("A017", "CARNE", "ENTRECOT DE TERNERA", 15.50m, 25.90m),
    new("A018", "CARNE", "CARNE PICADA DE TERNERA", 7.80m, 12.90m),
    new("A019", "CARNE", "HAMBURGUESA DE VACUNO", 7.20m, 11.90m),
    new("A020", "CARNE", "CORDERO LECHAL", 13.50m, 21.90m),
    new("A021", "CARNE", "CONEJO ENTERO", 5.80m, 9.49m),
    new("A022", "CARNE", "MAGRET DE PATO", 12.00m, 19.90m),

    // ==================================================
    // PESCADO Y MARISCO (20)
    // ==================================================
    new("A023", "PESCADO", "MERLUZA", 7.80m, 12.90m),
    new("A024", "PESCADO", "MERLUZA EN FILETES", 9.20m, 14.90m),
    new("A025", "PESCADO", "SALMON FRESCO", 10.50m, 17.90m),
    new("A026", "PESCADO", "SALMON AHUMADO", 22.00m, 34.90m),
    new("A027", "PESCADO", "BACALAO FRESCO", 10.80m, 17.50m),
    new("A028", "PESCADO", "BACALAO DESALADO", 13.50m, 21.90m),
    new("A029", "PESCADO", "ATUN FRESCO", 14.50m, 23.90m),
    new("A030", "PESCADO", "SARDINAS", 3.80m, 6.49m),
    new("A031", "PESCADO", "BOQUERONES", 4.50m, 7.49m),
    new("A032", "PESCADO", "DORADA", 6.90m, 11.49m),
    new("A033", "PESCADO", "LUBINA", 7.80m, 12.90m),
    new("A034", "PESCADO", "RODABALLO", 12.50m, 20.90m),
    new("A035", "PESCADO", "RAPE", 13.90m, 22.90m),
    new("A036", "PESCADO", "TRUCHA", 5.90m, 9.90m),
    new("A037", "PESCADO", "PULPO", 14.00m, 23.50m),
    new("A038", "PESCADO", "CALAMAR", 9.50m, 15.90m),
    new("A039", "PESCADO", "SEPIA", 10.50m, 17.50m),
    new("A040", "PESCADO", "GAMBAS", 11.50m, 18.90m),
    new("A041", "PESCADO", "LANGOSTINOS", 13.50m, 22.90m),
    new("A042", "PESCADO", "MEJILLONES", 2.80m, 4.90m),

    // ==================================================
    // FRUTA (20)
    // ==================================================
    new("A043", "FRUTA", "MANZANA GOLDEN", 1.05m, 1.89m),
    new("A044", "FRUTA", "MANZANA ROYAL GALA", 1.35m, 2.39m),
    new("A045", "FRUTA", "MANZANA FUJI", 1.55m, 2.79m),
    new("A046", "FRUTA", "PERA CONFERENCIA", 1.45m, 2.59m),
    new("A047", "FRUTA", "PERA DE AGUA", 1.60m, 2.89m),
    new("A048", "FRUTA", "NARANJA DE MESA", 0.95m, 1.79m),
    new("A049", "FRUTA", "NARANJA DE ZUMO", 0.75m, 1.39m),
    new("A050", "FRUTA", "MANDARINA", 1.30m, 2.29m),
    new("A051", "FRUTA", "PLATANO DE CANARIAS", 1.55m, 2.69m),
    new("A052", "FRUTA", "PLATANO DE IMPORTACION", 1.10m, 1.99m),
    new("A053", "FRUTA", "FRESA", 3.20m, 5.49m),
    new("A054", "FRUTA", "FRAMBUESA", 8.50m, 13.90m),
    new("A055", "FRUTA", "ARANDANO", 7.20m, 11.90m),
    new("A056", "FRUTA", "UVA BLANCA", 2.20m, 3.90m),
    new("A057", "FRUTA", "UVA NEGRA", 2.60m, 4.49m),
    new("A058", "FRUTA", "KIWI VERDE", 2.10m, 3.69m),
    new("A059", "FRUTA", "KIWI AMARILLO", 3.80m, 6.49m),
    new("A060", "FRUTA", "MELOCOTON", 1.80m, 3.19m),
    new("A061", "FRUTA", "SANDIA", 0.65m, 1.29m),
    new("A062", "FRUTA", "AGUACATE", 3.40m, 5.90m),

    // ==================================================
    // VERDURA Y HORTALIZA (20)
    // ==================================================
    new("A063", "VERDURA", "PATATA BLANCA", 0.55m, 1.09m),
    new("A064", "VERDURA", "PATATA ROJA", 0.75m, 1.49m),
    new("A065", "VERDURA", "CEBOLLA AMARILLA", 0.65m, 1.29m),
    new("A066", "VERDURA", "CEBOLLA MORADA", 1.10m, 2.09m),
    new("A067", "VERDURA", "TOMATE DE ENSALADA", 1.35m, 2.49m),
    new("A068", "VERDURA", "TOMATE CHERRY", 2.40m, 4.29m),
    new("A069", "VERDURA", "TOMATE RAF", 3.80m, 6.49m),
    new("A070", "VERDURA", "ZANAHORIA", 0.75m, 1.39m),
    new("A071", "VERDURA", "LECHUGA ROMANA", 0.85m, 1.59m),
    new("A072", "VERDURA", "LECHUGA ICEBERG", 0.95m, 1.79m),
    new("A073", "VERDURA", "PEPINO", 0.90m, 1.69m),
    new("A074", "VERDURA", "PIMIENTO ROJO", 2.10m, 3.69m),
    new("A075", "VERDURA", "PIMIENTO VERDE", 1.70m, 2.99m),
    new("A076", "VERDURA", "CALABACIN", 1.10m, 1.99m),
    new("A077", "VERDURA", "BERENJENA", 1.30m, 2.39m),
    new("A078", "VERDURA", "BROCOLI", 1.80m, 3.19m),
    new("A079", "VERDURA", "COLIFLOR", 1.50m, 2.69m),
    new("A080", "VERDURA", "ESPINACAS FRESCAS", 2.50m, 4.29m),
    new("A081", "VERDURA", "CHAMPIÑON", 2.60m, 4.49m),
    new("A082", "VERDURA", "ESPARRAGO VERDE", 5.50m, 9.49m),

    // ==================================================
    // LACTEOS Y HUEVOS (20)
    // ==================================================
    new("A083", "LACTEOS", "LECHE ENTERA", 0.72m, 1.09m),
    new("A084", "LACTEOS", "LECHE SEMIDESNATADA", 0.70m, 1.05m),
    new("A085", "LACTEOS", "LECHE DESNATADA", 0.68m, 1.02m),
    new("A086", "LACTEOS", "LECHE SIN LACTOSA", 0.88m, 1.39m),
    new("A087", "LACTEOS", "LECHE DE CABRA", 1.45m, 2.39m),
    new("A088", "LACTEOS", "YOGUR NATURAL", 1.65m, 2.69m),
    new("A089", "LACTEOS", "YOGUR GRIEGO", 2.40m, 3.99m),
    new("A090", "LACTEOS", "YOGUR DE FRESA", 1.95m, 3.19m),
    new("A091", "LACTEOS", "QUESO FRESCO", 4.20m, 6.90m),
    new("A092", "LACTEOS", "QUESO CURADO", 9.50m, 15.90m),
    new("A093", "LACTEOS", "QUESO SEMICURADO", 7.20m, 11.90m),
    new("A094", "LACTEOS", "QUESO MANCHEGO", 13.50m, 21.90m),
    new("A095", "LACTEOS", "QUESO MOZZARELLA", 5.50m, 8.90m),
    new("A096", "LACTEOS", "QUESO PARMESANO", 14.00m, 22.90m),
    new("A097", "LACTEOS", "QUESO AZUL", 8.50m, 13.90m),
    new("A098", "LACTEOS", "MANTEQUILLA", 5.80m, 9.49m),
    new("A099", "LACTEOS", "NATA PARA COCINAR", 2.80m, 4.49m),
    new("A100", "LACTEOS", "REQUESON", 4.10m, 6.90m),
    new("A101", "LACTEOS", "HUEVOS CAMPEROS", 2.60m, 4.20m),
    new("A102", "LACTEOS", "HUEVOS ECOLOGICOS", 3.50m, 5.69m),

    // ==================================================
    // CHARCUTERIA Y EMBUTIDOS (18)
    // ==================================================
    new("A103", "CHARCUTERIA", "JAMON SERRANO", 13.50m, 21.90m),
    new("A104", "CHARCUTERIA", "JAMON IBERICO DE CEBO", 28.00m, 44.90m),
    new("A105", "CHARCUTERIA", "JAMON IBERICO DE BELLOTA", 65.00m, 99.90m),
    new("A106", "CHARCUTERIA", "JAMON COCIDO", 5.20m, 8.49m),
    new("A107", "CHARCUTERIA", "PALETA COCIDA", 4.80m, 7.90m),
    new("A108", "CHARCUTERIA", "CHORIZO CURADO", 7.20m, 11.90m),
    new("A109", "CHARCUTERIA", "SALCHICHON", 7.50m, 12.20m),
    new("A110", "CHARCUTERIA", "LOMO EMBUCHADO", 15.50m, 24.90m),
    new("A111", "CHARCUTERIA", "FUET", 8.20m, 13.50m),
    new("A112", "CHARCUTERIA", "SALAMI", 6.80m, 11.20m),
    new("A113", "CHARCUTERIA", "MORTADELA", 4.10m, 6.79m),
    new("A114", "CHARCUTERIA", "BACON AHUMADO", 6.20m, 10.20m),
    new("A115", "CHARCUTERIA", "PANCETA", 5.50m, 9.20m),
    new("A116", "CHARCUTERIA", "PECHUGA DE PAVO LONCHEADA", 8.20m, 13.50m),
    new("A117", "CHARCUTERIA", "CHOPPED DE CERDO", 3.90m, 6.49m),
    new("A118", "CHARCUTERIA", "MORCILLA", 4.50m, 7.49m),
    new("A119", "CHARCUTERIA", "BUTIFARRA", 6.50m, 10.90m),
    new("A120", "CHARCUTERIA", "LONGANIZA", 6.90m, 11.49m),

    // ==================================================
    // PANADERIA Y BOLLERIA (16)
    // ==================================================
    new("A121", "PANADERIA", "BARRA DE PAN", 1.10m, 1.95m),
    new("A122", "PANADERIA", "BAGUETTE", 1.20m, 2.10m),
    new("A123", "PANADERIA", "PAN INTEGRAL", 1.55m, 2.69m),
    new("A124", "PANADERIA", "PAN DE CENTENO", 2.10m, 3.59m),
    new("A125", "PANADERIA", "PAN DE ESPELTA", 2.80m, 4.69m),
    new("A126", "PANADERIA", "PAN DE MOLDE BLANCO", 1.65m, 2.79m),
    new("A127", "PANADERIA", "PAN DE MOLDE INTEGRAL", 1.85m, 3.19m),
    new("A128", "PANADERIA", "PAN DE HAMBURGUESA", 2.20m, 3.79m),
    new("A129", "PANADERIA", "PAN DE HOT DOG", 2.10m, 3.59m),
    new("A130", "PANADERIA", "CROISSANT", 5.50m, 9.20m),
    new("A131", "PANADERIA", "NAPOLITANA DE CHOCOLATE", 6.20m, 10.20m),
    new("A132", "PANADERIA", "MAGDALENAS", 3.80m, 6.29m),
    new("A133", "PANADERIA", "DONUTS", 5.20m, 8.49m),
    new("A134", "PANADERIA", "BIZCOCHO", 4.10m, 6.90m),
    new("A135", "PANADERIA", "ENSaimada", 6.50m, 10.90m),
    new("A136", "PANADERIA", "EMPANADA", 6.80m, 11.20m),

    // ==================================================
    // CONGELADOS (18)
    // ==================================================
    new("A137", "CONGELADOS", "GUISANTES", 1.70m, 2.89m),
    new("A138", "CONGELADOS", "JUDIAS VERDES", 1.90m, 3.19m),
    new("A139", "CONGELADOS", "MENESTRA DE VERDURAS", 2.10m, 3.59m),
    new("A140", "CONGELADOS", "ESPINACAS", 1.60m, 2.79m),
    new("A141", "CONGELADOS", "BROCOLI", 2.00m, 3.39m),
    new("A142", "CONGELADOS", "PATATAS FRITAS", 1.50m, 2.59m),
    new("A143", "CONGELADOS", "PATATAS GAJO", 2.10m, 3.59m),
    new("A144", "CONGELADOS", "PIZZA MARGARITA", 3.80m, 6.29m),
    new("A145", "CONGELADOS", "PIZZA CUATRO QUESOS", 4.50m, 7.49m),
    new("A146", "CONGELADOS", "LASAÑA BOLOÑESA", 4.80m, 7.90m),
    new("A147", "CONGELADOS", "CROQUETAS DE JAMON", 5.20m, 8.49m),
    new("A148", "CONGELADOS", "NUGGETS DE POLLO", 4.10m, 6.90m),
    new("A149", "CONGELADOS", "FILETES DE MERLUZA", 7.50m, 12.20m),
    new("A150", "CONGELADOS", "GAMBAS PELADAS", 10.50m, 17.20m),
    new("A151", "CONGELADOS", "CALAMARES A LA ROMANA", 6.50m, 10.90m),
    new("A152", "CONGELADOS", "HELADO DE VAINILLA", 3.80m, 6.29m),
    new("A153", "CONGELADOS", "HELADO DE CHOCOLATE", 4.20m, 6.90m),
    new("A154", "CONGELADOS", "FRUTOS ROJOS", 5.20m, 8.49m),

    // ==================================================
    // LEGUMBRES Y CEREALES (18)
    // ==================================================
    new("A155", "LEGUMBRES Y CEREALES", "LENTEJAS", 1.40m, 2.39m),
    new("A156", "LEGUMBRES Y CEREALES", "GARBANZOS", 1.50m, 2.59m),
    new("A157", "LEGUMBRES Y CEREALES", "ALUBIAS BLANCAS", 1.70m, 2.89m),
    new("A158", "LEGUMBRES Y CEREALES", "ALUBIAS ROJAS", 2.10m, 3.59m),
    new("A159", "LEGUMBRES Y CEREALES", "ARROZ REDONDO", 1.30m, 2.19m),
    new("A160", "LEGUMBRES Y CEREALES", "ARROZ BASMATI", 2.10m, 3.49m),
    new("A161", "LEGUMBRES Y CEREALES", "ARROZ INTEGRAL", 1.80m, 2.99m),
    new("A162", "LEGUMBRES Y CEREALES", "ARROZ BOMBA", 2.80m, 4.69m),
    new("A163", "LEGUMBRES Y CEREALES", "ESPAGUETIS", 1.20m, 1.99m),
    new("A164", "LEGUMBRES Y CEREALES", "MACARRONES", 1.10m, 1.89m),
    new("A165", "LEGUMBRES Y CEREALES", "PASTA INTEGRAL", 1.50m, 2.49m),
    new("A166", "LEGUMBRES Y CEREALES", "PASTA FRESCA", 3.20m, 5.29m),
    new("A167", "LEGUMBRES Y CEREALES", "CUSCUS", 1.90m, 3.19m),
    new("A168", "LEGUMBRES Y CEREALES", "QUINOA", 3.80m, 6.29m),
    new("A169", "LEGUMBRES Y CEREALES", "AVENA", 1.70m, 2.89m),
    new("A170", "LEGUMBRES Y CEREALES", "HARINA DE TRIGO", 0.85m, 1.49m),
    new("A171", "LEGUMBRES Y CEREALES", "HARINA INTEGRAL", 1.10m, 1.89m),
    new("A172", "LEGUMBRES Y CEREALES", "SEMOLA DE MAIZ", 1.60m, 2.69m),

    // ==================================================
    // CONSERVAS Y ENCURTIDOS (16)
    // ==================================================
    new("A173", "CONSERVAS", "ATUN EN ACEITE", 8.50m, 13.90m),
    new("A174", "CONSERVAS", "ATUN AL NATURAL", 9.20m, 14.90m),
    new("A175", "CONSERVAS", "SARDINAS EN ACEITE", 5.50m, 9.20m),
    new("A176", "CONSERVAS", "CABALLA EN ACEITE", 6.80m, 11.20m),
    new("A177", "CONSERVAS", "MEJILLONES EN ESCABECHE", 9.50m, 15.50m),
    new("A178", "CONSERVAS", "BERBERECHOS", 24.00m, 38.90m),
    new("A179", "CONSERVAS", "ALMEJAS", 15.50m, 24.90m),
    new("A180", "CONSERVAS", "TOMATE TRITURADO", 1.20m, 2.09m),
    new("A181", "CONSERVAS", "TOMATE FRITO", 1.70m, 2.89m),
    new("A182", "CONSERVAS", "MAIZ DULCE", 2.10m, 3.49m),
    new("A183", "CONSERVAS", "CHAMPIÑONES", 3.20m, 5.29m),
    new("A184", "CONSERVAS", "ESPARRAGOS BLANCOS", 5.80m, 9.49m),
    new("A185", "CONSERVAS", "ACEITUNAS VERDES", 3.50m, 5.79m),
    new("A186", "CONSERVAS", "ACEITUNAS NEGRAS", 4.10m, 6.79m),
    new("A187", "CONSERVAS", "PEPINILLOS", 3.80m, 6.29m),
    new("A188", "CONSERVAS", "PIQUILLOS", 5.20m, 8.49m),

    // ==================================================
    // BEBIDAS (16)
    // ==================================================
    new("A189", "BEBIDAS", "AGUA MINERAL", 0.12m, 0.25m),
    new("A190", "BEBIDAS", "AGUA CON GAS", 0.25m, 0.49m),
    new("A191", "BEBIDAS", "ZUMO DE NARANJA", 1.10m, 1.89m),
    new("A192", "BEBIDAS", "ZUMO DE MELOCOTON", 0.95m, 1.69m),
    new("A193", "BEBIDAS", "ZUMO MULTIFRUTAS", 1.00m, 1.79m),
    new("A194", "BEBIDAS", "REFRESCO DE COLA", 1.10m, 1.89m),
    new("A195", "BEBIDAS", "REFRESCO DE LIMON", 0.95m, 1.69m),
    new("A196", "BEBIDAS", "REFRESCO DE NARANJA", 0.95m, 1.69m),
    new("A197", "BEBIDAS", "BEBIDA ISOTONICA", 1.20m, 2.09m),
    new("A198", "BEBIDAS", "BEBIDA ENERGETICA", 2.10m, 3.49m),
    new("A199", "BEBIDAS", "TE HELADO", 1.10m, 1.89m),
    new("A200", "BEBIDAS", "CAFE MOLIDO", 8.50m, 13.90m),
    new("A201", "BEBIDAS", "CAFE EN GRANO", 12.00m, 19.90m),
    new("A202", "BEBIDAS", "CAFE SOLUBLE", 18.00m, 28.90m),
    new("A203", "BEBIDAS", "TE NEGRO", 12.50m, 19.90m),
    new("A204", "BEBIDAS", "CACAO EN POLVO", 5.50m, 9.20m),

    // ==================================================
    // FRUTOS SECOS Y APERITIVOS (18)
    // ==================================================
    new("A205", "FRUTOS SECOS", "ALMENDRAS NATURALES", 8.50m, 13.90m),
    new("A206", "FRUTOS SECOS", "ALMENDRAS TOSTADAS", 10.00m, 16.50m),
    new("A207", "FRUTOS SECOS", "NUECES", 8.20m, 13.50m),
    new("A208", "FRUTOS SECOS", "AVELLANAS", 9.50m, 15.50m),
    new("A209", "FRUTOS SECOS", "PISTACHOS", 13.50m, 21.90m),
    new("A210", "FRUTOS SECOS", "ANACARDOS", 10.50m, 17.20m),
    new("A211", "FRUTOS SECOS", "CACAHUETES", 3.80m, 6.29m),
    new("A212", "FRUTOS SECOS", "PIPAS DE GIRASOL", 4.20m, 6.90m),
    new("A213", "FRUTOS SECOS", "PIPAS DE CALABAZA", 8.50m, 13.90m),
    new("A214", "FRUTOS SECOS", "PASAS", 4.10m, 6.79m),
    new("A215", "FRUTOS SECOS", "OREJONES", 7.50m, 12.20m),
    new("A216", "FRUTOS SECOS", "DATILES", 5.20m, 8.49m),
    new("A217", "APERITIVOS", "PATATAS FRITAS", 3.50m, 5.79m),
    new("A218", "APERITIVOS", "PATATAS ONDULADAS", 3.80m, 6.29m),
    new("A219", "APERITIVOS", "GUSANITOS DE MAIZ", 4.20m, 6.90m),
    new("A220", "APERITIVOS", "PALOMITAS", 3.10m, 5.20m),
    new("A221", "APERITIVOS", "TORTITAS DE ARROZ", 3.80m, 6.29m),
    new("A222", "APERITIVOS", "NACHOS DE MAIZ", 4.50m, 7.49m)
    ];

}