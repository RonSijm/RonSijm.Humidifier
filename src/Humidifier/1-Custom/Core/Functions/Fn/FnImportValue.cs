using System;

namespace Humidifier;

/// <summary>
/// TODO: Example
/// </summary>
public class FnImportValue : BaseFunction
{
    public dynamic SharedValueToImport { get; }

    public FnImportValue(dynamic sharedValueToImport)
    {
        SharedValueToImport = sharedValueToImport ?? throw new ArgumentNullException(nameof(sharedValueToImport));
    }
}