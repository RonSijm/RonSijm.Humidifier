namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCEndpointConnectionTypes;

    public class VPCEndpointConnection : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string IpAddressType =  "IpAddressType" ;
            public static string NetworkLoadBalancerArns =  "NetworkLoadBalancerArns" ;
            public static string VpcEndpointState =  "VpcEndpointState" ;
            public static string CreationTimestamp =  "CreationTimestamp" ;
            public static string DnsEntries =  "DnsEntries" ;
            public static string Arn =  "Arn" ;
            public static string VpcEndpointId =  "VpcEndpointId" ;
            public static string VpcEndpointOwner =  "VpcEndpointOwner" ;
            public static string VpcEndpointConnectionId =  "VpcEndpointConnectionId" ;
            public static string Tags =  "Tags" ;
            public static string ServiceId =  "ServiceId" ;
            public static string VpcEndpointRegion =  "VpcEndpointRegion" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCEndpointConnection; }
    }

    namespace VPCEndpointConnectionTypes
    {
        public class DnsEntry : Humidifier.Base.BaseSubResource, IHaveHostedZoneId, IHaveDnsName
        {
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpointconnection-dnsentry.html#cfn-ec2-vpcendpointconnection-dnsentry-dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsName { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpointconnection-dnsentry.html#cfn-ec2-vpcendpointconnection-dnsentry-hostedzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId { get; set; }
        }
    }
}