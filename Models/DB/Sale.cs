
namespace bi.Models.DB;

public class Sale
{
    public DateTime Date { get; set; }
    public string Market { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Family { get; set; } = string.Empty;
    public string Subfamily { get; set; } = string.Empty;
    public string Delegate { get; set; } = string.Empty;
    public string Customer { get; set; } = string.Empty;
    public string Article { get; set; } = string.Empty;


    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
    public decimal Kg { get; set; }

    // Precio de venta x kilogramos
    public decimal TotalSale => SalePrice * Kg;
    

    

}


    
