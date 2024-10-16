using System;
using System.Collections.Generic;

namespace Humidifier;

public class FFnSubNameFunc(IResultFactory result, Func<string, string> stringFunction, Dictionary<string, dynamic> variables = null) : IHaveResultFactory
{
    public Dictionary<string, dynamic> Variables { get; } = variables;
    public IResultFactory Result { get; set; } = result;
    public Func<string, string> StringFunction { get; set; } = stringFunction;
}