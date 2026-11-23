namespace bi.Interview;

public class Expediente
{
    public int Id {get; set;}
    public string Numero {get; set;}

    public string Estado {get; set;}

    public void Aprobar()
    {
        Estado = "APROBADO";
    }
}