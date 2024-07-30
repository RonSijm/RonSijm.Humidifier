using Humidifier.Base;

namespace Humidifier
{
    public static class FFn
    {
        public static FnORef Ref<T>(IResultFactory<T> factory) where T : BaseResource
        {
            var result = factory;
            var wrapper = new FnORef(result);

            return wrapper;
        }
    }

    public class FnORef(IResultFactory result)
    {
        public IResultFactory Result { get; set; } = result;
    }
}