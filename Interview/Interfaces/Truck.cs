namespace bi.Interview.Interfaces;

public class Truck : ITransportable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TypeTruck { get; set; }


    public Truck(int id, string name, string type){
        Id        = id;
        Name      = name;
        TypeTruck = type;
    }

    public void Finish() {
    }

    public void Start() {
    }
}