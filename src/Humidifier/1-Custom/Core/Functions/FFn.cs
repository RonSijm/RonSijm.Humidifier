using System.Collections.Generic;
using System.Linq;
using Humidifier.Base;

namespace Humidifier
{
    public static class FFn
    {
        public static FFnARN FFnARN<T>(IResultFactory<T> factory) where T : BaseResource
        {
            var result = factory;
            var wrapper = new FFnARN(result);

            return wrapper;
        }

        public static FFnREF FnORef<T>(IResultFactory<T> factory) where T : BaseResource
        {
            var result = factory;
            var wrapper = new FFnREF(result);

            return wrapper;
        }

        public static FFnREFList FFRefList<T>(List<IResultFactory<T>> factories) where T : BaseResource
        {
            var untyped = factories.Cast<IResultFactory>().ToList();
            var wrapper = new FFnREFList(untyped);

            return wrapper;
        }

        public static FFnREFList FFRefList(List<IResultFactory> factories)
        {
            var wrapper = new FFnREFList(factories);

            return wrapper;
        }


        public static FFNamedList FFNamedList<T>(IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFNamedList([factory]);

            return wrapper;
        }

        public static FFNamedList FFNamedList<T>(List<IResultFactory<T>> factories) where T : BaseResource
        {
            var untyped = factories.Cast<IResultFactory>().ToList();
            var wrapper = new FFNamedList(untyped);

            return wrapper;
        }

        public static FFNamedList FFNamedList(List<IResultFactory> factories)
        {
            var wrapper = new FFNamedList(factories);

            return wrapper;
        }
    }
}