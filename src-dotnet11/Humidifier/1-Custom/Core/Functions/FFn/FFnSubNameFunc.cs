using System;
using System.Collections.Generic;

namespace Humidifier;

public class FFnSubNameFunc(IResultFactory result, Func<string, string> stringFunction, Dictionary<string, object> variables = null) : BaseFunction, IHaveResultFactory
{
    public Dictionary<string, object> Variables { get; } = variables;
    public IResultFactory Result { get; set; } = result;
    public Func<string, string> StringFunction { get; set; } = stringFunction;
}