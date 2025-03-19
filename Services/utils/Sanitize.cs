using ProductsApi.Models.dtos;

namespace ProductsApi.Services.utils;

public interface ISanitizer
{
    public string SanitizeString(string stringToSanitize);
    public int ValidateInt(int intToSanitize);
    public decimal ValidateDecimal(decimal decimalToSanitize);
}