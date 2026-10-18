using Humidifier.Base;

namespace Humidifier.Interfaces;

public interface IResultFactory
{
    BaseResource Result { get; set; }
}

public interface IResultFactory<T> : IResultFactory where T : BaseResource
{
    BaseResource IResultFactory.Result
    {
        get => Result;
        set => Result = (T)value;
    }

    new T Result { get; set; }
}