namespace Humidifier.ApplicationSignals
{
    using global::System.Collections.Generic;

    public class Discovery : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationSignals.Discovery; }
    }
}