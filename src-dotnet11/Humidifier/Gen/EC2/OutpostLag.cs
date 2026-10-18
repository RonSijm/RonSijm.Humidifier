namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class OutpostLag : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string OutpostLagId =  "OutpostLagId" ;
            public static string LocalGatewayVirtualInterfaceIds =  "LocalGatewayVirtualInterfaceIds" ;
            public static string ServiceLinkVirtualInterfaceIds =  "ServiceLinkVirtualInterfaceIds" ;
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string OutpostArn =  "OutpostArn" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.EC2.OutpostLag; }
    }
}