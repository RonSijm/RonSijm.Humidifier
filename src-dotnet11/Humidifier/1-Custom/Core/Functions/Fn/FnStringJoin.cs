using System;
using System.Collections.Generic;

namespace Humidifier;

public class FnStringJoin : BaseFunction
{
    public List<object> Values { get; }

    public FnStringJoin(params object[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        Values = [..values];
    }
}