using System;
using System.Collections.Generic;
using Humidifier.Base;

namespace Humidifier;

public class Statement : BaseSubResource
{
    public string Sid { get; set; }
    public string Effect { get; set; }
    public Union<string, PolicyPrincipal, IReadOnlyDictionary<string, object>, BaseFunction>? Principal { get; set; }
    public Union<string, PolicyPrincipal, IReadOnlyDictionary<string, object>, BaseFunction>? NotPrincipal { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Action { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotAction { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, Lazy<string>, BaseFunction>? Resource { get; set; }
    public Union<string, IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, Lazy<string>, BaseFunction>? NotResource { get; set; }

    // Condition operators accept arbitrary JSON values, including arrays and expressions.
    public Dictionary<string, Dictionary<string, object>> Condition { get; set; }
}
