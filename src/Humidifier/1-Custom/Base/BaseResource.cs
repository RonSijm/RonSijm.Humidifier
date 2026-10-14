using Humidifier.Helpers;

namespace Humidifier.Base;

public interface IHaveGivenName
{
    dynamic GivenName { get; set; }
}

public abstract class BaseResource : BaseHumidifierDTO, IHaveGivenName
{
    [Ignore]
    public abstract string AWSTypeName { get; }

    private dynamic _givenName;
    private string _resourceName;

    [Ignore]
    public virtual dynamic GivenName
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
    public dynamic DependsOn { get; set; }

    [Ignore]
    public bool Export { get; set; }

    [Ignore]
    public CreationPolicy CreationPolicy { get; set; }
}
