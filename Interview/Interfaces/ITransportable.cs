namespace bi.Interview.Interfaces;

public interface ITransportable
{
    int Id { get; set; }
    string Name { get; set; }
    string TypeTruck { get; set; }
    void Start();
    void Finish();
}