namespace Humidifier;

#pragma warning disable CS0660, CS0661
public class FFnREF(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;

    public static bool operator ==(FFnREF obj1, string obj2)
    {
        if (obj2 == null)
        {
            return obj1?.Result?.Result == null;
        }

        return obj1.Result.Result.GivenName == obj2;
    }

    public static bool operator !=(FFnREF obj1, string obj2)
    {
        return !(obj1 == obj2);
    }
}