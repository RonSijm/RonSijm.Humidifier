namespace Humidifier;

/// <summary>
/// Explicitly supplies a JSON literal without CloudFormation function syntax. This is useful
/// for CloudFormation's alternative wire representations, such as numbers in string properties.
/// </summary>
public sealed class FnLiteral(object value) : BaseFunction
{
    public object Value { get; } = value;
}
