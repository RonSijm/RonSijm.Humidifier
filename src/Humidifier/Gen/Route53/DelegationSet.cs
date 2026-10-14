namespace Humidifier.Route53
{
    using global::System.Collections.Generic;

    public class DelegationSet : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string CallerReference =  "CallerReference" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string NameServers =  "NameServers" ;
        }

        public override string AWSTypeName { get => AWS.Route53.DelegationSet; }
    }
}