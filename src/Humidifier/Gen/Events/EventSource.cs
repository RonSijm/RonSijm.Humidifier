namespace Humidifier.Events
{
    using global::System.Collections.Generic;

    public class EventSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
            public static string ExpirationTime =  "ExpirationTime" ;
        }

        public override string AWSTypeName { get => AWS.Events.EventSource; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}