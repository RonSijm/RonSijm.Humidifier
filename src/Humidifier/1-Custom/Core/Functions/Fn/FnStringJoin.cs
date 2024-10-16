using System;
using System.Collections.Generic;

namespace Humidifier;

public class FnStringJoin
{
    public List<dynamic> Values { get; }

    public FnStringJoin(params dynamic[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        Values = [..values];
    }
}