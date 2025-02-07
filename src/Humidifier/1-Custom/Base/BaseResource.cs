using Humidifier.Helpers;

namespace Humidifier.Base;

public interface IHaveGivenName
{
    string GivenName { get; set; }
}

public abstract class BaseResource : BaseHumidifierDTO, IHaveGivenName
{
    [Ignore]
    public abstract string AWSTypeName { get; }

    private string _givenName;
    private string _resourceName;

    [Ignore]
    public virtual string GivenName
    {
        get => _givenName;
        set
        {
            _givenName = value;
            ResourceName = value;
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