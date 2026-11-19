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
        new(22, "Iván Torres", 22),
        new(23, "Óscar Castillo", 23)
    ];


    
public static readonly Article[] Articles =
[
    // ==================================================
    // CARNE (22)
    // ==================================================
    new("A001", "Pollo entero fresco", "CARNE", "POLLO ENTERO", 2.85m, 4.49m),
    new("A002", "Pechuga de pollo fresca", "CARNE", "PECHUGA DE POLLO", 5.40m, 8.95m),
    new("A003", "Alitas de pollo frescas", "CARNE", "ALITAS DE POLLO", 2.60m, 4.25m),
    new("A004", "Muslos de pollo frescos", "CARNE", "MUSLOS DE POLLO", 3.10m, 5.20m),
    new("A005", "Contramuslos de pollo frescos", "CARNE", "CONTRAMUSLOS DE POLLO", 3.45m, 5.75m),
    new("A006", "Pavo entero fresco", "CARNE", "PAVO ENTERO", 4.80m, 7.90m),
    new("A007", "Pechuga de pavo fresca", "CARNE", "PECHUGA DE PAVO", 6.50m, 10.50m),
    new("A008", "Lomo de cerdo fresco", "CARNE", "LOMO DE CERDO", 5.20m, 8.49m),
    new("A009", "Costilla de cerdo fresca", "CARNE", "COSTILLA DE CERDO", 4.30m, 7.20m),
    new("A010", "Paleta de cerdo fresca", "CARNE", "PALETA DE CERDO", 4.10m, 6.90m),
    new("A011", "Secreto de cerdo ibérico", "CARNE", "SECRETO DE CERDO", 8.90m, 14.50m),
    new("A012", "Solomillo de cerdo fresco", "CARNE", "SOLOMILLO DE CERDO", 7.50m, 12.20m),
    new("A013", "Carne picada de cerdo", "CARNE", "CARNE PICADA DE CERDO", 4.60m, 7.50m),
    new("A014", "Carne de ternera para guisar", "CARNE", "TERNERA PARA GUISAR", 8.20m, 13.50m),
    new("A015", "Filete de ternera fresco", "CARNE", "FILETE DE TERNERA", 10.50m, 17.90m),
    new("A016", "Solomillo de ternera fresco", "CARNE", "SOLOMILLO DE TERNERA", 22.00m, 34.90m),
    new("A017", "Entrecot de ternera fresco", "CARNE", "ENTRECOT DE TERNERA", 15.50m, 25.90m),
    new("A018", "Carne picada de ternera", "CARNE", "CARNE PICADA DE TERNERA", 7.80m, 12.90m),
    new("A019", "Hamburguesa de vacuno", "CARNE", "HAMBURGUESA DE VACUNO", 7.20m, 11.90m),
    new("A020", "Cordero lechal fresco", "CARNE", "CORDERO LECHAL", 13.50m, 21.90m),
    new("A021", "Conejo entero fresco", "CARNE", "CONEJO ENTERO", 5.80m, 9.49m),
    new("A022", "Magret de pato fresco", "CARNE", "MAGRET DE PATO", 12.00m, 19.90m),

    // ==================================================
    // PESCADO (20)
    // ==================================================
    new("A023", "Merluza fresca entera", "PESCADO", "MERLUZA", 7.80m, 12.90m),
    new("A024", "Filetes de merluza frescos", "PESCADO", "MERLUZA EN FILETES", 9.20m, 14.90m),
    new("A025", "Salmón fresco", "PESCADO", "SALMON FRESCO", 10.50m, 17.90m),
    new("A026", "Salmón ahumado en lonchas", "PESCADO", "SALMON AHUMADO", 22.00m, 34.90m),
    new("A027", "Bacalao fresco", "PESCADO", "BACALAO FRESCO", 10.80m, 17.50m),
    new("A028", "Bacalao desalado", "PESCADO", "BACALAO DESALADO", 13.50m, 21.90m),
    new("A029", "Atún fresco en lomos", "PESCADO", "ATUN FRESCO", 14.50m, 23.90m),
    new("A030", "Sardinas frescas", "PESCADO", "SARDINAS", 3.80m, 6.49m),
    new("A031", "Boquerones frescos", "PESCADO", "BOQUERONES", 4.50m, 7.49m),
    new("A032", "Dorada fresca", "PESCADO", "DORADA", 6.90m, 11.49m),
    new("A033", "Lubina fresca", "PESCADO", "LUBINA", 7.80m, 12.90m),
    new("A034", "Rodaballo fresco", "PESCADO", "RODABALLO", 12.50m, 20.90m),
    new("A035", "Rape fresco", "PESCADO", "RAPE", 13.90m, 22.90m),
    new("A036", "Trucha fresca", "PESCADO", "TRUCHA", 5.90m, 9.90m),
    new("A037", "Pulpo fresco", "PESCADO", "PULPO", 14.00m, 23.50m),
    new("A038", "Calamar fresco", "PESCADO", "CALAMAR", 9.50m, 15.90m),
    new("A039", "Sepia fresca", "PESCADO", "SEPIA", 10.50m, 17.50m),
    new("A040", "Gambas frescas", "PESCADO", "GAMBAS", 11.50m, 18.90m),
    new("A041", "Langostinos frescos", "PESCADO", "LANGOSTINOS", 13.50m, 22.90m),
    new("A042", "Mejillones frescos", "PESCADO", "MEJILLONES", 2.80m, 4.90m),

    // ==================================================
    // FRUTA (20)
    // ==================================================
    new("A043", "Manzana Golden nacional", "FRUTA", "MANZANA GOLDEN", 1.05m, 1.89m),
    new("A044", "Manzana Royal Gala", "FRUTA", "MANZANA ROYAL GALA", 1.35m, 2.39m),
    new("A045", "Manzana Fuji", "FRUTA", "MANZANA FUJI", 1.55m, 2.79m),
    new("A046", "Pera Conferencia", "FRUTA", "PERA CONFERENCIA", 1.45m, 2.59m),
    new("A047", "Pera de agua fresca", "FRUTA", "PERA DE AGUA", 1.60m, 2.89m),
    new("A048", "Naranja de mesa", "FRUTA", "NARANJA DE MESA", 0.95m, 1.79m),
    new("A049", "Naranja para zumo", "FRUTA", "NARANJA DE ZUMO", 0.75m, 1.39m),
    new("A050", "Mandarina fresca", "FRUTA", "MANDARINA", 1.30m, 2.29m),
    new("A051", "Plátano de Canarias", "FRUTA", "PLATANO DE CANARIAS", 1.55m, 2.69m),
    new("A052", "Plátano de importación", "FRUTA", "PLATANO DE IMPORTACION", 1.10m, 1.99m),
    new("A053", "Fresas frescas", "FRUTA", "FRESA", 3.20m, 5.49m),
    new("A054", "Frambuesas frescas", "FRUTA", "FRAMBUESA", 8.50m, 13.90m),
    new("A055", "Arándanos frescos", "FRUTA", "ARANDANO", 7.20m, 11.90m),
    new("A056", "Uva blanca sin semillas", "FRUTA", "UVA BLANCA", 2.20m, 3.90m),
    new("A057", "Uva negra fresca", "FRUTA", "UVA NEGRA", 2.60m, 4.49m),
    new("A058", "Kiwi verde", "FRUTA", "KIWI VERDE", 2.10m, 3.69m),
    new("A059", "Kiwi amarillo", "FRUTA", "KIWI AMARILLO", 3.80m, 6.49m),
    new("A060", "Melocotón amarillo", "FRUTA", "MELOCOTON", 1.80m, 3.19m),
    new("A061", "Sandía fresca", "FRUTA", "SANDIA", 0.65m, 1.29m),
    new("A062", "Aguacate fresco", "FRUTA", "AGUACATE", 3.40m, 5.90m),

    // ==================================================
    // VERDURA (20)
    // ==================================================
    new("A063", "Patata blanca de consumo", "VERDURA", "PATATA BLANCA", 0.55m, 1.09m),
    new("A064", "Patata roja de consumo", "VERDURA", "PATATA ROJA", 0.75m, 1.49m),
    new("A065", "Cebolla amarilla", "VERDURA", "CEBOLLA AMARILLA", 0.65m, 1.29m),
    new("A066", "Cebolla morada", "VERDURA", "CEBOLLA MORADA", 1.10m, 2.09m),
    new("A067", "Tomate de ensalada", "VERDURA", "TOMATE DE ENSALADA", 1.35m, 2.49m),
    new("A068", "Tomate cherry fresco", "VERDURA", "TOMATE CHERRY", 2.40m, 4.29m),
    new("A069", "Tomate Raf", "VERDURA", "TOMATE RAF", 3.80m, 6.49m),
    new("A070", "Zanahoria fresca", "VERDURA", "ZANAHORIA", 0.75m, 1.39m),
    new("A071", "Lechuga romana", "VERDURA", "LECHUGA ROMANA", 0.85m, 1.59m),
    new("A072", "Lechuga iceberg", "VERDURA", "LECHUGA ICEBERG", 0.95m, 1.79m),
    new("A073", "Pepino fresco", "VERDURA", "PEPINO", 0.90m, 1.69m),
    new("A074", "Pimiento rojo", "VERDURA", "PIMIENTO ROJO", 2.10m, 3.69m),
    new("A075", "Pimiento verde", "VERDURA", "PIMIENTO VERDE", 1.70m, 2.99m),
    new("A076", "Calabacín fresco", "VERDURA", "CALABACIN", 1.10m, 1.99m),
    new("A077", "Berenjena fresca", "VERDURA", "BERENJENA", 1.30m, 2.39m),
    new("A078", "Brócoli fresco", "VERDURA", "BROCOLI", 1.80m, 3.19m),
    new("A079", "Coliflor fresca", "VERDURA", "COLIFLOR", 1.50m, 2.69m),
    new("A080", "Espinacas frescas en bolsa", "VERDURA", "ESPINACAS FRESCAS", 2.50m, 4.29m),
    new("A081", "Champiñón fresco", "VERDURA", "CHAMPIÑON", 2.60m, 4.49m),
    new("A082", "Espárrago verde fresco", "VERDURA", "ESPARRAGO VERDE", 5.50m, 9.49m),

    // ==================================================
    // LACTEOS Y HUEVOS (20)
    // ==================================================
    new("A083", "Leche entera UHT", "LACTEOS", "LECHE ENTERA", 0.72m, 1.09m),
    new("A084", "Leche semidesnatada UHT", "LACTEOS", "LECHE SEMIDESNATADA", 0.70m, 1.05m),
    new("A085", "Leche desnatada UHT", "LACTEOS", "LECHE DESNATADA", 0.68m, 1.02m),
    new("A086", "Leche sin lactosa", "LACTEOS", "LECHE SIN LACTOSA", 0.88m, 1.39m),
    new("A087", "Leche de cabra", "LACTEOS", "LECHE DE CABRA", 1.45m, 2.39m),
    new("A088", "Yogur natural", "LACTEOS", "YOGUR NATURAL", 1.65m, 2.69m),
    new("A089", "Yogur griego cremoso", "LACTEOS", "YOGUR GRIEGO", 2.40m, 3.99m),
    new("A090", "Yogur de fresa", "LACTEOS", "YOGUR DE FRESA", 1.95m, 3.19m),
    new("A091", "Queso fresco natural", "LACTEOS", "QUESO FRESCO", 4.20m, 6.90m),
    new("A092", "Queso curado de oveja", "LACTEOS", "QUESO CURADO", 9.50m, 15.90m),
    new("A093", "Queso semicurado", "LACTEOS", "QUESO SEMICURADO", 7.20m, 11.90m),
    new("A094", "Queso manchego", "LACTEOS", "QUESO MANCHEGO", 13.50m, 21.90m),
    new("A095", "Queso mozzarella", "LACTEOS", "QUESO MOZZARELLA", 5.50m, 8.90m),
    new("A096", "Queso parmesano", "LACTEOS", "QUESO PARMESANO", 14.00m, 22.90m),
    new("A097", "Queso azul", "LACTEOS", "QUESO AZUL", 8.50m, 13.90m),
    new("A098", "Mantequilla tradicional", "LACTEOS", "MANTEQUILLA", 5.80m, 9.49m),
    new("A099", "Nata para cocinar", "LACTEOS", "NATA PARA COCINAR", 2.80m, 4.49m),
    new("A100", "Requesón fresco", "LACTEOS", "REQUESON", 4.10m, 6.90m),
    new("A101", "Huevos camperos", "LACTEOS", "HUEVOS CAMPEROS", 2.60m, 4.20m),
    new("A102", "Huevos ecológicos", "LACTEOS", "HUEVOS ECOLOGICOS", 3.50m, 5.69m),

    // ==================================================
    // CHARCUTERIA (18)
    // ==================================================
    new("A103", "Jamón serrano curado", "CHARCUTERIA", "JAMON SERRANO", 13.50m, 21.90m),
    new("A104", "Jamón ibérico de cebo", "CHARCUTERIA", "JAMON IBERICO DE CEBO", 28.00m, 44.90m),
    new("A105", "Jamón ibérico de bellota", "CHARCUTERIA", "JAMON IBERICO DE BELLOTA", 65.00m, 99.90m),
    new("A106", "Jamón cocido en lonchas", "CHARCUTERIA", "JAMON COCIDO", 5.20m, 8.49m),
    new("A107", "Paleta cocida en lonchas", "CHARCUTERIA", "PALETA COCIDA", 4.80m, 7.90m),
    new("A108", "Chorizo curado", "CHARCUTERIA", "CHORIZO CURADO", 7.20m, 11.90m),
    new("A109", "Salchichón tradicional", "CHARCUTERIA", "SALCHICHON", 7.50m, 12.20m),
    new("A110", "Lomo embuchado curado", "CHARCUTERIA", "LOMO EMBUCHADO", 15.50m, 24.90m),
    new("A111", "Fuet tradicional", "CHARCUTERIA", "FUET", 8.20m, 13.50m),
    new("A112", "Salami en lonchas", "CHARCUTERIA", "SALAMI", 6.80m, 11.20m),
    new("A113", "Mortadela italiana", "CHARCUTERIA", "MORTADELA", 4.10m, 6.79m),
    new("A114", "Bacon ahumado en lonchas", "CHARCUTERIA", "BACON AHUMADO", 6.20m, 10.20m),
    new("A115", "Panceta de cerdo", "CHARCUTERIA", "PANCETA", 5.50m, 9.20m),
    new("A116", "Pechuga de pavo loncheada", "CHARCUTERIA", "PECHUGA DE PAVO LONCHEADA", 8.20m, 13.50m),
    new("A117", "Chopped de cerdo", "CHARCUTERIA", "CHOPPED DE CERDO", 3.90m, 6.49m),
    new("A118", "Morcilla tradicional", "CHARCUTERIA", "MORCILLA", 4.50m, 7.49m),
    new("A119", "Butifarra fresca", "CHARCUTERIA", "BUTIFARRA", 6.50m, 10.90m),
    new("A120", "Longaniza fresca", "CHARCUTERIA", "LONGANIZA", 6.90m, 11.49m),

    // ==================================================
    // PANADERIA (16)
    // ==================================================
    new("A121", "Barra de pan tradicional", "PANADERIA", "BARRA DE PAN", 1.10m, 1.95m),
    new("A122", "Baguette francesa", "PANADERIA", "BAGUETTE", 1.20m, 2.10m),
    new("A123", "Pan integral de trigo", "PANADERIA", "PAN INTEGRAL", 1.55m, 2.69m),
    new("A124", "Pan de centeno", "PANADERIA", "PAN DE CENTENO", 2.10m, 3.59m),
    new("A125", "Pan de espelta", "PANADERIA", "PAN DE ESPELTA", 2.80m, 4.69m),
    new("A126", "Pan de molde blanco", "PANADERIA", "PAN DE MOLDE BLANCO", 1.65m, 2.79m),
    new("A127", "Pan de molde integral", "PANADERIA", "PAN DE MOLDE INTEGRAL", 1.85m, 3.19m),
    new("A128", "Pan de hamburguesa clásico", "PANADERIA", "PAN DE HAMBURGUESA", 2.20m, 3.79m),
    new("A129", "Pan de hot dog", "PANADERIA", "PAN DE HOT DOG", 2.10m, 3.59m),
    new("A130", "Croissant de mantequilla", "PANADERIA", "CROISSANT", 5.50m, 9.20m),
    new("A131", "Napolitana rellena de chocolate", "PANADERIA", "NAPOLITANA DE CHOCOLATE", 6.20m, 10.20m),
    new("A132", "Magdalenas tradicionales", "PANADERIA", "MAGDALENAS", 3.80m, 6.29m),
    new("A133", "Donuts glaseados", "PANADERIA", "DONUTS", 5.20m, 8.49m),
    new("A134", "Bizcocho casero", "PANADERIA", "BIZCOCHO", 4.10m, 6.90m),
    new("A135", "Ensaimada tradicional", "PANADERIA", "ENSAIMADA", 6.50m, 10.90m),
    new("A136", "Empanada gallega", "PANADERIA", "EMPANADA", 6.80m, 11.20m),

    // ==================================================
    // CONGELADOS (18)
    // ==================================================
    new("A137", "Guisantes congelados", "CONGELADOS", "GUISANTES", 1.70m, 2.89m),
    new("A138", "Judías verdes congeladas", "CONGELADOS", "JUDIAS VERDES", 1.90m, 3.19m),
    new("A139", "Menestra de verduras congelada", "CONGELADOS", "MENESTRA DE VERDURAS", 2.10m, 3.59m),
    new("A140", "Espinacas congeladas", "CONGELADOS", "ESPINACAS", 1.60m, 2.79m),
    new("A141", "Brócoli congelado", "CONGELADOS", "BROCOLI", 2.00m, 3.39m),
    new("A142", "Patatas fritas congeladas", "CONGELADOS", "PATATAS FRITAS", 1.50m, 2.59m),
    new("A143", "Patatas gajo congeladas", "CONGELADOS", "PATATAS GAJO", 2.10m, 3.59m),
    new("A144", "Pizza margarita congelada", "CONGELADOS", "PIZZA MARGARITA", 3.80m, 6.29m),
    new("A145", "Pizza cuatro quesos congelada", "CONGELADOS", "PIZZA CUATRO QUESOS", 4.50m, 7.49m),
    new("A146", "Lasaña boloñesa congelada", "CONGELADOS", "LASAÑA BOLOÑESA", 4.80m, 7.90m),
    new("A147", "Croquetas de jamón congeladas", "CONGELADOS", "CROQUETAS DE JAMON", 5.20m, 8.49m),
    new("A148", "Nuggets de pollo congelados", "CONGELADOS", "NUGGETS DE POLLO", 4.10m, 6.90m),
    new("A149", "Filetes de merluza congelados", "CONGELADOS", "FILETES DE MERLUZA", 7.50m, 12.20m),
    new("A150", "Gambas peladas congeladas", "CONGELADOS", "GAMBAS PELADAS", 10.50m, 17.20m),
    new("A151", "Calamares a la romana congelados", "CONGELADOS", "CALAMARES A LA ROMANA", 6.50m, 10.90m),
    new("A152", "Helado de vainilla", "CONGELADOS", "HELADO DE VAINILLA", 3.80m, 6.29m),
    new("A153", "Helado de chocolate", "CONGELADOS", "HELADO DE CHOCOLATE", 4.20m, 6.90m),
    new("A154", "Mezcla de frutos rojos congelados", "CONGELADOS", "FRUTOS ROJOS", 5.20m, 8.49m),

    // ==================================================
    // LEGUMBRES Y CEREALES (18)
    // ==================================================
    new("A155", "Lentejas secas", "LEGUMBRES Y CEREALES", "LENTEJAS", 1.40m, 2.39m),
    new("A156", "Garbanzos secos", "LEGUMBRES Y CEREALES", "GARBANZOS", 1.50m, 2.59m),
    new("A157", "Alubias blancas secas", "LEGUMBRES Y CEREALES", "ALUBIAS BLANCAS", 1.70m, 2.89m),
    new("A158", "Alubias rojas secas", "LEGUMBRES Y CEREALES", "ALUBIAS ROJAS", 2.10m, 3.59m),
    new("A159", "Arroz redondo", "LEGUMBRES Y CEREALES", "ARROZ REDONDO", 1.30m, 2.19m),
    new("A160", "Arroz basmati", "LEGUMBRES Y CEREALES", "ARROZ BASMATI", 2.10m, 3.49m),
    new("A161", "Arroz integral", "LEGUMBRES Y CEREALES", "ARROZ INTEGRAL", 1.80m, 2.99m),
    new("A162", "Arroz bomba", "LEGUMBRES Y CEREALES", "ARROZ BOMBA", 2.80m, 4.69m),
    new("A163", "Espaguetis de trigo", "LEGUMBRES Y CEREALES", "ESPAGUETIS", 1.20m, 1.99m),
    new("A164", "Macarrones de trigo", "LEGUMBRES Y CEREALES", "MACARRONES", 1.10m, 1.89m),
    new("A165", "Pasta integral", "LEGUMBRES Y CEREALES", "PASTA INTEGRAL", 1.50m, 2.49m),
    new("A166", "Pasta fresca refrigerada", "LEGUMBRES Y CEREALES", "PASTA FRESCA", 3.20m, 5.29m),
    new("A167", "Cuscús de trigo", "LEGUMBRES Y CEREALES", "CUSCUS", 1.90m, 3.19m),
    new("A168", "Quinoa natural", "LEGUMBRES Y CEREALES", "QUINOA", 3.80m, 6.29m),
    new("A169", "Avena en copos", "LEGUMBRES Y CEREALES", "AVENA", 1.70m, 2.89m),
    new("A170", "Harina de trigo", "LEGUMBRES Y CEREALES", "HARINA DE TRIGO", 0.85m, 1.49m),
    new("A171", "Harina integral de trigo", "LEGUMBRES Y CEREALES", "HARINA INTEGRAL", 1.10m, 1.89m),
    new("A172", "Sémola de maíz", "LEGUMBRES Y CEREALES", "SEMOLA DE MAIZ", 1.60m, 2.69m),

    // ==================================================
    // CONSERVAS (16)
    // ==================================================
    new("A173", "Atún en aceite de oliva", "CONSERVAS", "ATUN EN ACEITE", 8.50m, 13.90m),
    new("A174", "Atún al natural", "CONSERVAS", "ATUN AL NATURAL", 9.20m, 14.90m),
    new("A175", "Sardinas en aceite", "CONSERVAS", "SARDINAS EN ACEITE", 5.50m, 9.20m),
    new("A176", "Caballa en aceite", "CONSERVAS", "CABALLA EN ACEITE", 6.80m, 11.20m),
    new("A177", "Mejillones en escabeche", "CONSERVAS", "MEJILLONES EN ESCABECHE", 9.50m, 15.50m),
    new("A178", "Berberechos en conserva", "CONSERVAS", "BERBERECHOS", 24.00m, 38.90m),
    new("A179", "Almejas en conserva", "CONSERVAS", "ALMEJAS", 15.50m, 24.90m),
    new("A180", "Tomate triturado en conserva", "CONSERVAS", "TOMATE TRITURADO", 1.20m, 2.09m),
    new("A181", "Tomate frito en conserva", "CONSERVAS", "TOMATE FRITO", 1.70m, 2.89m),
    new("A182", "Maíz dulce en conserva", "CONSERVAS", "MAIZ DULCE", 2.10m, 3.49m),
    new("A183", "Champiñones laminados en conserva", "CONSERVAS", "CHAMPIÑONES", 3.20m, 5.29m),
    new("A184", "Espárragos blancos en conserva", "CONSERVAS", "ESPARRAGOS BLANCOS", 5.80m, 9.49m),
    new("A185", "Aceitunas verdes sin hueso", "CONSERVAS", "ACEITUNAS VERDES", 3.50m, 5.79m),
    new("A186", "Aceitunas negras sin hueso", "CONSERVAS", "ACEITUNAS NEGRAS", 4.10m, 6.79m),
    new("A187", "Pepinillos en vinagre", "CONSERVAS", "PEPINILLOS", 3.80m, 6.29m),
    new("A188", "Pimientos del piquillo", "CONSERVAS", "PIQUILLOS", 5.20m, 8.49m),

    // ==================================================
    // BEBIDAS (16)
    // ==================================================
    new("A189", "Agua mineral natural", "BEBIDAS", "AGUA MINERAL", 0.12m, 0.25m),
    new("A190", "Agua mineral con gas", "BEBIDAS", "AGUA CON GAS", 0.25m, 0.49m),
    new("A191", "Zumo de naranja", "BEBIDAS", "ZUMO DE NARANJA", 1.10m, 1.89m),
    new("A192", "Zumo de melocotón", "BEBIDAS", "ZUMO DE MELOCOTON", 0.95m, 1.69m),
    new("A193", "Zumo multifrutas", "BEBIDAS", "ZUMO MULTIFRUTAS", 1.00m, 1.79m),
    new("A194", "Refresco de cola", "BEBIDAS", "REFRESCO DE COLA", 1.10m, 1.89m),
    new("A195", "Refresco de limón", "BEBIDAS", "REFRESCO DE LIMON", 0.95m, 1.69m),
    new("A196", "Refresco de naranja", "BEBIDAS", "REFRESCO DE NARANJA", 0.95m, 1.69m),
    new("A197", "Bebida isotónica", "BEBIDAS", "BEBIDA ISOTONICA", 1.20m, 2.09m),
    new("A198", "Bebida energética", "BEBIDAS", "BEBIDA ENERGETICA", 2.10m, 3.49m),
    new("A199", "Té helado", "BEBIDAS", "TE HELADO", 1.10m, 1.89m),
    new("A200", "Café molido natural", "BEBIDAS", "CAFE MOLIDO", 8.50m, 13.90m),
    new("A201", "Café en grano natural", "BEBIDAS", "CAFE EN GRANO", 12.00m, 19.90m),
    new("A202", "Café soluble", "BEBIDAS", "CAFE SOLUBLE", 18.00m, 28.90m),
    new("A203", "Té negro en bolsitas", "BEBIDAS", "TE NEGRO", 12.50m, 19.90m),
    new("A204", "Cacao puro en polvo", "BEBIDAS", "CACAO EN POLVO", 5.50m, 9.20m),

    // ==================================================
    // FRUTOS SECOS Y APERITIVOS (18)
    // ==================================================
    new("A205", "Almendras naturales", "FRUTOS SECOS", "ALMENDRAS NATURALES", 8.50m, 13.90m),
    new("A206", "Almendras tostadas", "FRUTOS SECOS", "ALMENDRAS TOSTADAS", 10.00m, 16.50m),
    new("A207", "Nueces peladas", "FRUTOS SECOS", "NUECES", 8.20m, 13.50m),
    new("A208", "Avellanas naturales", "FRUTOS SECOS", "AVELLANAS", 9.50m, 15.50m),
    new("A209", "Pistachos tostados", "FRUTOS SECOS", "PISTACHOS", 13.50m, 21.90m),
    new("A210", "Anacardos tostados", "FRUTOS SECOS", "ANACARDOS", 10.50m, 17.20m),
    new("A211", "Cacahuetes tostados", "FRUTOS SECOS", "CACAHUETES", 3.80m, 6.29m),
    new("A212", "Pipas de girasol", "FRUTOS SECOS", "PIPAS DE GIRASOL", 4.20m, 6.90m),
    new("A213", "Pipas de calabaza", "FRUTOS SECOS", "PIPAS DE CALABAZA", 8.50m, 13.90m),
    new("A214", "Pasas de uva", "FRUTOS SECOS", "PASAS", 4.10m, 6.79m),
    new("A215", "Orejones de albaricoque", "FRUTOS SECOS", "OREJONES", 7.50m, 12.20m),
    new("A216", "Dátiles sin hueso", "FRUTOS SECOS", "DATILES", 5.20m, 8.49m),
    new("A217", "Patatas fritas clásicas", "APERITIVOS", "PATATAS FRITAS", 3.50m, 5.79m),
    new("A218", "Patatas fritas onduladas", "APERITIVOS", "PATATAS ONDULADAS", 3.80m, 6.29m),
    new("A219", "Gusanitos de maíz", "APERITIVOS", "GUSANITOS DE MAIZ", 4.20m, 6.90m),
    new("A220", "Palomitas de maíz", "APERITIVOS", "PALOMITAS", 3.10m, 5.20m),
    new("A221", "Tortitas de arroz", "APERITIVOS", "TORTITAS DE ARROZ", 3.80m, 6.29m),
    new("A222", "Nachos de maíz", "APERITIVOS", "NACHOS DE MAIZ", 4.50m, 7.49m),

    // ==================================================
    // PANADERIA Y REPOSTERIA (A223-A233)
    // ==================================================
    new("A223", "Pan artesanal de masa madre", "PANADERIA", "PAN DE MASA MADRE", 2.40m, 4.20m),
    new("A224", "Pan tradicional de payés", "PANADERIA", "PAN DE PAYES", 2.80m, 4.90m),
    new("A225", "Pan tostado con ajo", "PANADERIA", "PAN DE AJO", 2.10m, 3.69m),
    new("A226", "Pan de pita mediterráneo", "PANADERIA", "PAN DE PITA", 1.80m, 3.19m),
    new("A227", "Pan brioche para hamburguesa", "PANADERIA", "PAN DE HAMBURGUESA BRIOCHE", 2.90m, 4.90m),
    new("A228", "Pan integral con semillas", "PANADERIA", "PAN DE SEMILLAS", 2.30m, 3.99m),
    new("A229", "Pan de maíz tradicional", "PANADERIA", "PAN DE MAIZ", 2.10m, 3.69m),
    new("A230", "Panecillos rústicos variados", "PANADERIA", "PANECILLOS RUSTICOS", 2.50m, 4.29m),
    new("A231", "Tarta artesanal de queso", "PANADERIA", "TARTA DE QUESO", 8.50m, 13.90m),
    new("A232", "Tarta de chocolate", "PANADERIA", "TARTA DE CHOCOLATE", 9.20m, 15.50m),
    new("A233", "Palmeritas de hojaldre", "PANADERIA", "PALMERITAS DE HOJALDRE", 4.50m, 7.49m),

    // ==================================================
    // CARNE (A234-A244)
    // ==================================================
    new("A234", "Costillar de ternera fresco", "CARNE", "COSTILLAR DE TERNERA", 12.50m, 20.90m),
    new("A235", "Chuletón de ternera madurado", "CARNE", "CHULETON DE TERNERA", 19.50m, 31.90m),
    new("A236", "Rabo de ternera troceado", "CARNE", "RABO DE TERNERA", 8.50m, 13.90m),
    new("A237", "Carrillera de ternera fresca", "CARNE", "CARRILLERA DE TERNERA", 10.50m, 17.50m),
    new("A238", "Aguja de cerdo fresca", "CARNE", "AGUJA DE CERDO", 4.80m, 7.90m),
    new("A239", "Presa de cerdo ibérico", "CARNE", "PRESA IBERICA", 15.50m, 24.90m),
    new("A240", "Pluma de cerdo ibérico", "CARNE", "PLUMA IBERICA", 16.50m, 26.90m),
    new("A241", "Chuletas de cordero frescas", "CARNE", "CHULETAS DE CORDERO", 14.50m, 23.90m),
    new("A242", "Paletilla de cordero fresca", "CARNE", "PALETILLA DE CORDERO", 13.50m, 21.90m),
    new("A243", "Codornices enteras", "CARNE", "CODORNICES", 8.50m, 13.90m),
    new("A244", "Pechuga de pato fresca", "CARNE", "PECHUGA DE PATO", 12.50m, 20.90m),

    // ==================================================
    // PESCADO (A245-A255)
    // ==================================================
    new("A245", "Lenguado fresco", "PESCADO", "LENGUADO", 13.50m, 22.50m),
    new("A246", "Salmonetes frescos", "PESCADO", "SALMONETES", 9.50m, 15.90m),
    new("A247", "Corvina fresca", "PESCADO", "CORVINA", 10.50m, 17.50m),
    new("A248", "Besugo fresco", "PESCADO", "BESUGO", 12.50m, 20.90m),
    new("A249", "Emperador fresco en filetes", "PESCADO", "EMPERADOR", 14.50m, 23.90m),
    new("A250", "Caballa fresca entera", "PESCADO", "CABALLA FRESCA", 4.50m, 7.49m),
    new("A251", "Anchoas frescas", "PESCADO", "ANCHOAS FRESCAS", 5.50m, 9.20m),
    new("A252", "Vieiras frescas", "PESCADO", "VIEIRAS", 18.50m, 29.90m),
    new("A253", "Almejas frescas", "PESCADO", "ALMEJAS FRESCAS", 12.50m, 20.90m),
    new("A254", "Cigalas frescas", "PESCADO", "CIGALAS", 19.50m, 31.90m),
    new("A255", "Bogavante fresco", "PESCADO", "BOGAVANTE", 28.00m, 44.90m),

    // ==================================================
    // FRUTA (A256-A266)
    // ==================================================
    new("A256", "Piña natural entera", "FRUTA", "PIÑA NATURAL", 1.40m, 2.49m),
    new("A257", "Mango tropical", "FRUTA", "MANGO", 2.20m, 3.90m),
    new("A258", "Papaya tropical", "FRUTA", "PAPAYA", 2.80m, 4.90m),
    new("A259", "Granada fresca", "FRUTA", "GRANADA", 2.10m, 3.69m),
    new("A260", "Caqui fresco", "FRUTA", "CAQUI", 1.80m, 3.19m),
    new("A261", "Ciruela roja fresca", "FRUTA", "CIRUELA ROJA", 1.90m, 3.39m),
    new("A262", "Ciruela amarilla fresca", "FRUTA", "CIRUELA AMARILLA", 2.10m, 3.69m),
    new("A263", "Cerezas frescas", "FRUTA", "CEREZAS", 5.50m, 9.49m),
    new("A264", "Melón Galia", "FRUTA", "MELON GALIA", 1.10m, 1.99m),
    new("A265", "Pomelo rosa", "FRUTA", "POMELO ROSA", 1.50m, 2.69m),
    new("A266", "Limón fresco", "FRUTA", "LIMON", 0.90m, 1.69m),

    // ==================================================
    // VERDURA (A267-A277)
    // ==================================================
    new("A267", "Batata fresca", "VERDURA", "BATATA", 1.20m, 2.19m),
    new("A268", "Boniato naranja", "VERDURA", "BONIATO", 1.30m, 2.29m),
    new("A269", "Puerro fresco", "VERDURA", "PUERRO", 1.10m, 1.99m),
    new("A270", "Apio fresco", "VERDURA", "APIO", 1.20m, 2.19m),
    new("A271", "Acelgas frescas", "VERDURA", "ACELGAS", 1.50m, 2.69m),
    new("A272", "Col lombarda fresca", "VERDURA", "COL LOMBARDA", 1.40m, 2.49m),
    new("A273", "Coles de Bruselas frescas", "VERDURA", "COL DE BRUSELAS", 2.20m, 3.90m),
    new("A274", "Rábanos frescos", "VERDURA", "RABANOS", 1.60m, 2.79m),
    new("A275", "Remolacha fresca", "VERDURA", "REMOLACHA", 1.30m, 2.29m),
    new("A276", "Judía verde fresca", "VERDURA", "JUDIA VERDE FRESCA", 2.50m, 4.29m),
    new("A277", "Calabaza fresca", "VERDURA", "CALABAZA", 1.10m, 1.99m),

    // ==================================================
    // LACTEOS (A278-A288)
    // ==================================================
    new("A278", "Queso de cabra curado", "LACTEOS", "QUESO DE CABRA", 10.50m, 17.50m),
    new("A279", "Queso Brie francés", "LACTEOS", "QUESO BRIE", 8.50m, 13.90m),
    new("A280", "Queso Gorgonzola italiano", "LACTEOS", "QUESO GORGONZOLA", 11.50m, 18.90m),
    new("A281", "Queso Cheddar madurado", "LACTEOS", "QUESO CHEDDAR", 7.50m, 12.50m),
    new("A282", "Queso fresco de Burgos", "LACTEOS", "QUESO DE BURGOS", 4.50m, 7.49m),
    new("A283", "Queso Ricotta italiano", "LACTEOS", "QUESO RICOTTA", 5.50m, 9.20m),
    new("A284", "Queso Feta griego", "LACTEOS", "QUESO FETA", 8.20m, 13.50m),
    new("A285", "Nata montada refrigerada", "LACTEOS", "NATA MONTADA", 3.20m, 5.49m),
    new("A286", "Kéfir natural", "LACTEOS", "KEFIR NATURAL", 2.10m, 3.69m),
    new("A287", "Yogur natural sin azúcar", "LACTEOS", "YOGUR NATURAL SIN AZUCAR", 1.80m, 2.99m),
    new("A288", "Huevos de codorniz", "LACTEOS", "HUEVOS DE CODORNIZ", 2.50m, 4.29m),

    // ==================================================
    // CHARCUTERIA (A289-A299)
    // ==================================================
    new("A289", "Jamón de pato curado", "CHARCUTERIA", "JAMON DE PATO", 18.50m, 29.90m),
    new("A290", "Cecina de León curada", "CHARCUTERIA", "CECINA DE LEON", 22.00m, 35.90m),
    new("A291", "Lomo ibérico curado", "CHARCUTERIA", "LOMO IBERICO", 24.00m, 38.90m),
    new("A292", "Chorizo ibérico curado", "CHARCUTERIA", "CHORIZO IBERICO", 15.50m, 24.90m),
    new("A293", "Salchichón ibérico curado", "CHARCUTERIA", "SALCHICHON IBERICO", 16.50m, 26.90m),
    new("A294", "Sobrasada mallorquina", "CHARCUTERIA", "SOBRASADA", 7.50m, 12.50m),
    new("A295", "Morcilla de Burgos", "CHARCUTERIA", "MORCILLA DE BURGOS", 5.50m, 9.20m),
    new("A296", "Paté tradicional de cerdo", "CHARCUTERIA", "PATE DE CERDO", 4.20m, 6.90m),
    new("A297", "Paté de pato", "CHARCUTERIA", "PATE DE PATO", 8.50m, 13.90m),
    new("A298", "Salchichas Frankfurt", "CHARCUTERIA", "SALCHICHAS FRANKFURT", 4.50m, 7.49m),
    new("A299", "Salchichas frescas de cerdo", "CHARCUTERIA", "SALCHICHAS FRESCAS", 5.20m, 8.49m),

    // ==================================================
    // CONGELADOS (A300-A310)
    // ==================================================
    new("A300", "Anillas de calamar congeladas", "CONGELADOS", "ANILLAS DE CALAMAR", 7.50m, 12.50m),
    new("A301", "Merluza rebozada congelada", "CONGELADOS", "MERLUZA REBOZADA", 6.50m, 10.90m),
    new("A302", "Lomos de bacalao congelados", "CONGELADOS", "LOMOS DE BACALAO", 12.50m, 20.90m),
    new("A303", "Filetes de salmón congelados", "CONGELADOS", "FILETES DE SALMON", 11.50m, 18.90m),
    new("A304", "Gyozas rellenas de pollo", "CONGELADOS", "GYOZAS DE POLLO", 5.50m, 9.20m),
    new("A305", "Empanadillas de atún", "CONGELADOS", "EMPANADILLAS DE ATUN", 4.50m, 7.49m),
    new("A306", "Canelones rellenos de carne", "CONGELADOS", "CANELONES DE CARNE", 5.20m, 8.49m),
    new("A307", "Mezcla de verduras para wok", "CONGELADOS", "VERDURAS PARA WOK", 2.80m, 4.90m),
    new("A308", "Maíz dulce congelado", "CONGELADOS", "MAIZ DULCE CONGELADO", 1.80m, 3.19m),
    new("A309", "Tarta helada de nata", "CONGELADOS", "TARTA HELADA DE NATA", 5.50m, 9.20m),
    new("A310", "Sorbete de limón congelado", "CONGELADOS", "SORBETE DE LIMON", 3.50m, 5.90m),

    // ==================================================
    // LEGUMBRES Y CEREALES (A311-A321)
    // ==================================================
    new("A311", "Arroz salvaje", "LEGUMBRES Y CEREALES", "ARROZ SALVAJE", 4.50m, 7.49m),
    new("A312", "Arroz jazmín", "LEGUMBRES Y CEREALES", "ARROZ JAZMIN", 2.50m, 4.29m),
    new("A313", "Bulgur de trigo", "LEGUMBRES Y CEREALES", "BULGUR", 2.80m, 4.90m),
    new("A314", "Trigo sarraceno", "LEGUMBRES Y CEREALES", "TRIGO SARRACENO", 3.20m, 5.49m),
    new("A315", "Semillas de chía", "LEGUMBRES Y CEREALES", "SEMILLAS DE CHIA", 5.50m, 9.20m),
    new("A316", "Semillas de lino", "LEGUMBRES Y CEREALES", "SEMILLAS DE LINO", 3.50m, 5.90m),
    new("A317", "Copos de avena", "LEGUMBRES Y CEREALES", "COPOS DE AVENA", 2.10m, 3.69m),
    new("A318", "Granola con cereales", "LEGUMBRES Y CEREALES", "GRANOLA", 4.20m, 6.90m),
    new("A319", "Muesli de cereales", "LEGUMBRES Y CEREALES", "MUESLI", 3.80m, 6.29m),
    new("A320", "Harina de garbanzo", "LEGUMBRES Y CEREALES", "HARINA DE GARBANZO", 2.50m, 4.29m),
    new("A321", "Polenta de maíz", "LEGUMBRES Y CEREALES", "POLENTA", 2.20m, 3.79m),

    // ==================================================
    // CONSERVAS (A322-A332)
    // ==================================================
    new("A322", "Pimientos del piquillo rellenos", "CONSERVAS", "PIMIENTO DEL PIQUILLO RELLENO", 7.50m, 12.50m),
    new("A323", "Corazones de alcachofa", "CONSERVAS", "CORAZONES DE ALCACHOFA", 5.50m, 9.20m),
    new("A324", "Espárragos trigueros en conserva", "CONSERVAS", "ESPARRAGOS TRIGUEROS", 5.20m, 8.49m),
    new("A325", "Alubias blancas cocidas", "CONSERVAS", "ALUBIAS BLANCAS COCIDAS", 1.50m, 2.59m),
    new("A326", "Garbanzos cocidos", "CONSERVAS", "GARBANZOS COCIDOS", 1.40m, 2.39m),
    new("A327", "Lentejas cocidas", "CONSERVAS", "LENTEJAS COCIDAS", 1.30m, 2.29m),
    new("A328", "Pisto de verduras", "CONSERVAS", "PISTO DE VERDURAS", 2.80m, 4.90m),
    new("A329", "Piña en su jugo", "CONSERVAS", "PIÑA EN SU JUGO", 2.20m, 3.79m),
    new("A330", "Melocotón en almíbar", "CONSERVAS", "MELOCOTON EN ALMIBAR", 2.50m, 4.29m),
    new("A331", "Peras en almíbar", "CONSERVAS", "PERAS EN ALMIBAR", 2.60m, 4.49m),
    new("A332", "Mermelada de fresa", "CONSERVAS", "MERMELADA DE FRESA", 2.80m, 4.90m),

    // ==================================================
    // BEBIDAS (A333)
    // ==================================================
    new("A333", "Agua de coco natural", "BEBIDAS", "AGUA DE COCO", 1.80m, 3.19m)
];


    public static readonly Customer[] Customers =
    [
    // EUROPA

    new(1, "Mercadona", "España"),
    new(2, "Carrefour", "España"),
    new(3, "Eroski", "España"),
    new(4, "Lidl", "España"),

    new(5, "E.Leclerc", "Francia"),
    new(6, "Carrefour", "Francia"),
    new(7, "Intermarché", "Francia"),
    new(8, "Auchan", "Francia"),

    new(9, "Edeka", "Alemania"),
    new(10, "Rewe", "Alemania"),
    new(11, "Aldi", "Alemania"),
    new(12, "Lidl", "Alemania"),

    new(13, "Conad", "Italia"),
    new(14, "Coop", "Italia"),
    new(15, "Esselunga", "Italia"),
    new(16, "Eurospin", "Italia"),

    new(17, "Continente", "Portugal"),
    new(18, "Pingo Doce", "Portugal"),
    new(19, "Auchan", "Portugal"),
    new(20, "Lidl", "Portugal"),

    new(21, "Albert Heijn", "Países Bajos"),
    new(22, "Jumbo", "Países Bajos"),   
    new(23, "Lidl", "Países Bajos"),
    new(24, "Aldi", "Países Bajos"),

    new(25, "Tesco", "Reino Unido"),
    new(26, "Sainsbury's", "Reino Unido"),
    new(27, "Asda", "Reino Unido"),
    new(28, "Morrisons", "Reino Unido"),

    // ASIA

    new(29, "Aeon", "Japón"),
    new(30, "Ito-Yokado", "Japón"),
    new(31, "Life", "Japón"),
    new(32, "Seiyu", "Japón"),

    new(33, "CR Vanguard", "China"),
    new(34, "RT-Mart", "China"),
    new(35, "Walmart", "China"),
    new(36, "Hema", "China"),

    new(37, "Reliance Smart Bazaar", "India"),
    new(38, "DMart", "India"),
    new(39, "More", "India"),
    new(40, "Spencer's", "India"),

    new(41, "E-Mart", "Corea del Sur"),
    new(42, "Homeplus", "Corea del Sur"),
    new(43, "Lotte Mart", "Corea del Sur"),
    new(44, "Hanaro Mart", "Corea del Sur"),

    new(45, "FairPrice", "Singapur"),
    new(46, "Sheng Siong", "Singapur"),
    new(47, "Cold Storage", "Singapur"),
    new(48, "Giant", "Singapur"),

    // AMÉRICA DEL NORTE

    new(49, "Walmart", "Estados Unidos"),
    new(50, "Kroger", "Estados Unidos"),
    new(51, "Costco", "Estados Unidos"),
    new(52, "Albertsons", "Estados Unidos"),

    new(53, "Loblaws", "Canadá"),
    new(54, "Sobeys", "Canadá"),
    new(55, "Metro", "Canadá"),
    new(56, "Walmart Canada", "Canadá"),

    new(57, "Walmart de México", "México"),
    new(58, "Soriana", "México"),
    new(59, "Chedraui", "México"),
    new(60, "La Comer", "México"),

    // AMÉRICA DEL SUR

    new(61, "Carrefour Brasil", "Brasil"),
    new(62, "Assaí Atacadista", "Brasil"),
    new(63, "Pão de Açúcar", "Brasil"),
    new(64, "Grupo Mateus", "Brasil"),

    new(65, "Carrefour", "Argentina"),
    new(66, "Coto", "Argentina"),
    new(67, "Día", "Argentina"),
    new(68, "La Anónima", "Argentina"),

    new(69, "Líder", "Chile"),
    new(70, "Jumbo", "Chile"),
    new(71, "Santa Isabel", "Chile"),
    new(72, "Unimarc", "Chile"),

    new(73, "Éxito", "Colombia"),
    new(74, "Carulla", "Colombia"),
    new(75, "Jumbo", "Colombia"),
    new(76, "Olímpica", "Colombia"),

    new(77, "Plaza Vea", "Perú"),
    new(78, "Wong", "Perú"),
    new(79, "Metro", "Perú"),
    new(80, "Tottus", "Perú"),

    // OCEANÍA

    new(81, "Woolworths", "Australia"),
    new(82, "Coles", "Australia"),
    new(83, "ALDI", "Australia"),
    new(84, "IGA", "Australia"),

    new(85, "Woolworths", "Nueva Zelanda"),
    new(86, "New World", "Nueva Zelanda"),
    new(87, "PAK'nSAVE", "Nueva Zelanda"),
    new(88, "Four Square", "Nueva Zelanda"),

    new(89, "RB Patel", "Fiyi"),
    new(90, "Shop N Save", "Fiyi"),
    new(91, "New World IGA", "Fiyi"),
    new(92, "MaxVal-u", "Fiyi")
    ];

    public static readonly DelegateCustomer[] DelegateCustomers =
    [
    // EUROPA

    // España - Alejandro García
    new(1, 1),
    new(1, 2),
    new(1, 3),
    new(1, 4),

    // Francia - Daniel Rodríguez
    new(2, 5),
    new(2, 6),
    new(2, 7),
    new(2, 8),

    // Alemania - Pablo González
    new(3, 9),
    new(3, 10),
    new(3, 11),
    new(3, 12),

    // Italia - Manuel Fernández
    new(4, 13),
    new(4, 14),
    new(4, 15),
    new(4, 16),

    // Portugal - Álvaro López
    new(5, 17),
    new(5, 18),
    new(5, 19),
    new(5, 20),

    // Países Bajos - David Martínez
    new(6, 21),
    new(6, 22),
    new(6, 23),
    new(6, 24),

    // Reino Unido - Javier Sánchez
    new(7, 25),
    new(7, 26),
    new(7, 27),
    new(7, 28),

    // ASIA

    // Japón - Sergio Pérez
    new(8, 29),
    new(8, 30),
    new(8, 31),
    new(8, 32),

    // China - Carlos Gómez
    new(9, 33),
    new(9, 34),
    new(9, 35),
    new(9, 36),

    // India - Adrián Martín
    new(10, 37),
    new(10, 38),
    new(10, 39),
    new(10, 40),

    // Corea del Sur - Diego Jiménez
    new(11, 41),
    new(11, 42),
    new(11, 43),
    new(11, 44),

    // Singapur - Mario Ruiz
    new(12, 45),
    new(12, 46),
    new(12, 47),
    new(12, 48),

    // AMÉRICA DEL NORTE

    // Estados Unidos - Hugo Hernández
    new(13, 49),
    new(13, 50),
    new(13, 51),
    new(13, 52),

    // Canadá - Lucas Díaz
    new(14, 53),
    new(14, 54),
    new(14, 55),
    new(14, 56),

    // México - Marcos Moreno
    new(15, 57),
    new(15, 58),
    new(15, 59),
    new(15, 60),

    // AMÉRICA DEL SUR

    // Brasil - Antonio Álvarez
    new(16, 61),
    new(16, 62),
    new(16, 63),
    new(16, 64),

    // Argentina - Miguel Muñoz
    new(17, 65),
    new(17, 66),
    new(17, 67),
    new(17, 68),

    // Chile - José Romero
    new(18, 69),
    new(18, 70),
    new(18, 71),
    new(18, 72),

    // Colombia - Fernando Alonso
    new(19, 73),
    new(19, 74),
    new(19, 75),
    new(19, 76),

    // Perú - Raúl Gutiérrez
    new(20, 77),
    new(20, 78),
    new(20, 79),
    new(20, 80),

    // OCEANÍA

    // Australia - Rubén Navarro
    new(21, 81),
    new(21, 82),
    new(21, 83),
    new(21, 84),

    // Nueva Zelanda - Iván Torres
    new(22, 85),
    new(22, 86),
    new(22, 87),
    new(22, 88),

    // Fiyi - Óscar Castillo
    new(23, 89),
    new(23, 90),
    new(23, 91),
    new(23, 92)
    ];
}