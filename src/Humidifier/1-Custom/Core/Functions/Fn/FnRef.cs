using System;

namespace Humidifier;

/// <summary>
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-ref.html
///  </summary>
public class FnRef : BaseFunction
{
    public string Reference { get; }
    public FnRef(string reference) => Reference = reference ?? throw new ArgumentNullException(nameof(reference));
}