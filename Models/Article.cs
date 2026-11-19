namespace bi.Models;

public record Article(
    string Code,
    string Description,
    string Family,
    string Subfamily,
    decimal CostPrice,
    decimal SalePrice
);