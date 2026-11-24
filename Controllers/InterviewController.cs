using bi.Interview;
using bi.Interview.Abstact;
using bi.Interview.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace bi.Controllers;

[ApiController]
public class InterviewController: Controller
{
    [HttpGet("/interview")]
    public async Task<IActionResult> InterViewFunc(){

        Expediente exp = new Expediente
        {
            Id=1, Numero="1", Estado="Estado"
        };

        List<Expediente> expedientes = new List<Expediente>{ new ExpedienteAgrario(), new ExpedienteGanadero() };
        List<ITransportable> trans = new List<ITransportable>{ 
            new Truck(1, "name 1", "type truck"), 
            new Porche{ TypeTruck = "Deportivo" }
        };

        Console.WriteLine(trans);
        

        var coche = new Porche
        {
            Id=1, Name="911", TypeTruck = "Deportivo"
        };

        coche.Move();

        return Ok(
            new
            {
                expedientes = expedientes,
                coche = coche,
                trans = trans
            }
        );
    }
}