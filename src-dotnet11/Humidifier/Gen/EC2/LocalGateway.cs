namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class LocalGateway : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string LocalGatewayId =  "LocalGatewayId" ;
            public static string State =  "State" ;
            public static string OutpostArn =  "OutpostArn" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGateway; }
    }
}