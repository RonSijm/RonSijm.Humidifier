﻿using System;

namespace Humidifier;

public class FFnRawFunc(IResultFactory result, Func<string, string> stringFunction) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
    public Func<string, string> StringFunction { get; set; } = stringFunction;
}