using Humidifier.Base;

namespace Humidifier
{
    public class ResultHolder(BaseResource result) : IResultFactory
    {
        public BaseResource Result { get; set; } = result;
    }
}
