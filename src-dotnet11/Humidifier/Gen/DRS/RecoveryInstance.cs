namespace Humidifier.DRS
{
    using global::System.Collections.Generic;

    public class RecoveryInstance : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string RecoveryInstanceID =  "RecoveryInstanceID" ;
            public static string OriginEnvironment =  "OriginEnvironment" ;
            public static string EC2InstanceState =  "EC2InstanceState" ;
            public static string IsDrill =  "IsDrill" ;
            public static string EC2InstanceID =  "EC2InstanceID" ;
            public static string Arn =  "Arn" ;
            public static string SourceServerID =  "SourceServerID" ;
            public static string JobID =  "JobID" ;
            public static string Tags =  "Tags" ;
            public static string OriginAvailabilityZone =  "OriginAvailabilityZone" ;
        }

        public override string AWSTypeName { get => AWS.DRS.RecoveryInstance; }
    }
}