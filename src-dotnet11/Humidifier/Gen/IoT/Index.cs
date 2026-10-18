namespace Humidifier.IoT
{
    using global::System.Collections.Generic;

    public class Index : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveIndexName
    {
        public class Attributes
        {
            public static string IndexStatus =  "IndexStatus" ;
            public static string Schema =  "Schema" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.Index; }
        public Union<string, BaseFunction>? IndexName { get => GivenName; set => GivenName = value; }
    }
}