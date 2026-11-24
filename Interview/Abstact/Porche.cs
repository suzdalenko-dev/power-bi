using bi.Interview.Interfaces;

namespace bi.Interview.Abstact;

public class Porche : AutoMovil, ITransportable
{
    public required string TypeTruck { get; set; }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Finish()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        Console.WriteLine($"{this.Name} MOVING");
    }
}

/*
    De la clase Abstracta se hereda y de la interfaz se implementa

    Clase abstracta: 
        representa qué es un objeto y permite compartir código y estado entre clases relacionadas.
    Interfaz: 
        representa qué capacidades o contratos debe cumplir una clase, independientemente de su tipo.


    ¿Cuándo utilizarías una clase abstracta y cuándo una interfaz?
        - Clase abstracta: cuando varias clases comparten características, propiedades y comportamiento.
        - Interfaz: cuando distintas clases deben cumplir un contrato común, aunque sean de tipos diferentes.





*/