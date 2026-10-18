using System;

namespace Humidifier;

/// <summary>
/// TODO: Example
/// </summary>
public class FnImportValue : BaseFunction
{
    public object SharedValueToImport { get; }

    public FnImportValue(object sharedValueToImport)
    {
        SharedValueToImport = sharedValueToImport ?? throw new ArgumentNullException(nameof(sharedValueToImport));
    }
}