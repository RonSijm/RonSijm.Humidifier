using System;

namespace Humidifier;

public class Condition
{
    public BaseFunction Fn { get; }

    public Condition(BaseFunction fn)
    {
        if (fn == null)
        {
            throw new ArgumentNullException(nameof(fn));
        }

        Fn = fn;
    }
}
