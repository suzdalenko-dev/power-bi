namespace bi.Models;

public record Article(
    string Code,
    string Family,
    string Subfamily,
    decimal CostPrice,
    decimal SalePrice
);