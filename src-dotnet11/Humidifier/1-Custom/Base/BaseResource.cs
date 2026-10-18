using Humidifier.Helpers;

using System.Collections.Generic;

namespace Humidifier.Base;

public interface IHaveGivenName
{
    Union<string, BaseFunction>? GivenName { get; set; }
}

public abstract class BaseResource : BaseHumidifierDTO, IHaveGivenName
{
    [Ignore]
    public abstract string AWSTypeName { get; }

    private Union<string, BaseFunction>? _givenName;
    private string _resourceName;

    [Ignore]
    public virtual Union<string, BaseFunction>? GivenName
    {
        get => _givenName;
        set
        {
            _givenName = value;
            if (value is string name)
            {
                ResourceName = name;
            }
        }
    }

    [Ignore]
    public virtual string ResourceName
    {
        get => _resourceName;
        set => _resourceName = value.CleanName();
    }

    [Ignore]
    public Union<string, IReadOnlyList<string>, BaseFunction>? DependsOn { get; set; }

    [Ignore]
    public bool Export { get; set; }

    [Ignore]
    public CreationPolicy CreationPolicy { get; set; }
}
