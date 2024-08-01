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

        public static FFnREF FFnREF(IResultFactory factory)
        {
            var wrapper = new FFnREF(factory);

            return wrapper;
        }

        public static FFnImportValue ImportValue(IResultFactory factory)
        {
            var wrapper = new FFnImportValue(factory);
            return wrapper;
        }

        public static FFnREF FFnREF<T>(IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFnREF(factory);

            return wrapper;
        }

        public static FFnName FFnName<T>(IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFnName(factory);

            return wrapper;
        }

        public static FFnName FFnName(IResultFactory factory)
        {
            var wrapper = new FFnName(factory);

            return wrapper;
        }

        public static FFnName FFnName(BaseResource resource)
        {
            var holder = new ResultHolder(resource);
            var wrapper = new FFnName(holder);

            return wrapper;
        }

        public static FnStringJoin FnStringJoin(params dynamic[] conditions)
        {
            var wrapper = new FnStringJoin(conditions);

            return wrapper;
        }

        public static FFnREFList FFnREFList<T>(List<IResultFactory<T>> factories) where T : BaseResource
        {
            var untyped = factories.Cast<IResultFactory>().ToList();
            var wrapper = new FFnREFList(untyped);

            return wrapper;
        }

        public static FFnREFList FFnREFList(List<IResultFactory> factories)
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