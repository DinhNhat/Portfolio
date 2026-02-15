using System.Text.RegularExpressions;

namespace Portfolio.ParameterTransformers;

public class KebabPageRouteParameterTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value)
    {
        if (value == null)
        {
            return null;
        }
        return Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2");
    }
}