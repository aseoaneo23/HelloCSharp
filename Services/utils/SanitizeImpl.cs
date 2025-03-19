using System.Text.RegularExpressions;


namespace ProductsApi.Services.utils;
public class SanitizeImpl : ISanitizer
{
    public string SanitizeString(string stringToSanitize)
    {
        if (String.IsNullOrWhiteSpace(stringToSanitize))
        {
            throw new ArgumentException("String cannot be null, empty, or whitespace.");
        }
        
        // Replace disruptive chars
        var stringSanitized = Regex.Replace(stringToSanitize, @"[^\w\s-]", "");
        return stringSanitized;
    }

    public int ValidateInt(int intToSanitize)
    {
        if (intToSanitize < 0)
        {
            throw new ArgumentException("Int cannot be negative.");
        }
        return intToSanitize;
    }

    public Decimal ValidateDecimal(decimal decimalToSanitize)
    {
        if (decimalToSanitize < 0)
        {
            throw new ArgumentException("Decimal cannot be negative.");
        }

        return decimalToSanitize;
    }
    
}