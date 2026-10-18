namespace Humidifier.DataExchange
{
    using global::System.Collections.Generic;

    public class Job : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DataExchange.Job; }
    }
}