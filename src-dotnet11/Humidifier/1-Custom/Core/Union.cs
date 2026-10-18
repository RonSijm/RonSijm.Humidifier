namespace Humidifier;

/// <summary>
/// A property value that is one of the listed types. Case values can be assigned directly,
/// including in object initializers. The CloudFormation serializer writes the contained value.
/// </summary>
public union Union<TFirst, TSecond>(TFirst, TSecond)
{
    public override string ToString() => Value?.ToString() ?? string.Empty;
}

/// <summary>
/// A collection property accepting ordinary entries, entries containing expressions,
/// or an expression for the entire collection.
/// </summary>
public union Union<TFirst, TSecond, TThird>(TFirst, TSecond, TThird)
{
    public override string ToString() => Value?.ToString() ?? string.Empty;
}

/// <summary>A property with four supported literal or expression shapes.</summary>
public union Union<TFirst, TSecond, TThird, TFourth>(TFirst, TSecond, TThird, TFourth)
{
    public override string ToString() => Value?.ToString() ?? string.Empty;
}

/// <summary>A property with five supported literal or expression shapes.</summary>
public union Union<TFirst, TSecond, TThird, TFourth, TFifth>(TFirst, TSecond, TThird, TFourth, TFifth)
{
    public override string ToString() => Value?.ToString() ?? string.Empty;
}
