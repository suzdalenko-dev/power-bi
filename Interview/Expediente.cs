namespace bi.Interview;

public class Expediente
{
    public int Id {get; init;}
    public string Numero {get; set;}

    public string Estado {get; set;}

    public void Aprobar()
    {
        Estado = "APROBADO";
    }
    // propiedades
    public float saldo {get; set;} = 1.0f;  // unos 7 dígitos en total.
    public double pend {get; set;} = 1.0;   // 15-16 dígitos en total
    public decimal IVA => Importe * 0.21m;  // 28-29 dígitos en total.


    public decimal Importe {get; set; }
    
    public decimal Total => Importe + IVA;

    private decimal Suedo = 0.5m;

    public virtual void Calcular()
    {
        Console.WriteLine("Calculando expediente...");
    }
    
}

/*
TRAGSA ENTREVISTA TECNICA:
Clases y objetos.
Propiedades y métodos.
Encapsulación (private, public, private set).   <- acceso a methodos o propiedades
Herencia (:).                                   <- heredar los metodos y propiedades de la clase padre -> abuelo -> abuelo
Polimorfismo (virtual y override).              <- padre metodo(virtual) -> hijo(override) o suscribir una clase abstacta
Interfaces.
Tipos valor y referencia.

Concepto	            Qué debes aprender	                                            Prioridad
Constructores	        Inicializar objetos	                                            Alta
Sobrecarga de métodos	Mismo método, distintos parámetros	                            Alta
this	                Referenciar el objeto actual	                                Media
base	                Acceder al constructor o miembros de la clase padre	            Media
Clases abstractas	    Definir clases que no se instancian directamente	            Alta
Interfaces	            Contratos e implementación	                                    Alta
static	                Miembros que pertenecen a la clase	                            Alta
sealed	                Impedir herencia o sobrescritura	                            Media
record	                Tipos orientados a datos	                                    Media
struct	                Crear tipos valor personalizados	                            Media
Modificadores de acceso	public, private, protected, internal	                        Alta
*/  