using System.Collections.Generic;

namespace Humidifier;

/// <summary>The supported principal kinds in an IAM resource or trust policy.</summary>
public class PolicyPrincipal
{
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AWS { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Service { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Federated { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CanonicalUser { get; set; }
}
